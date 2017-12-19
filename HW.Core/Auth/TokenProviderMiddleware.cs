using log4net.Core;
using log4net.Repository;
using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HW.Core.Auth
{
    /// <summary>
    /// Token generator middleware component which is added to an HTTP pipeline.
    /// This class is not created by application code directly,
    /// instead it is added by calling the <see cref="TokenProviderAppBuilderExtensions.UseSimpleTokenProvider(Microsoft.AspNetCore.Builder.IApplicationBuilder, TokenProviderOptions)"/>
    /// extension method.
    /// </summary>
    public class TokenProviderMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly TokenProviderOptions _options;
        //   private readonly ILogger _logger;
        private readonly JsonSerializerSettings _serializerSettings;
        public IAuthenticationSchemeProvider _schemes { get; set; }

        public TokenProviderMiddleware(
            RequestDelegate next,
            IOptions<TokenProviderOptions> options,
             IAuthenticationSchemeProvider schemes)
        //,ILoggerFactory loggerFactory)
        {
            _next = next;

            //  _logger = loggerFactory.CreateLogger<TokenProviderMiddleware>();

            _options = options.Value;
            _schemes = schemes;
            ThrowIfInvalidOptions(_options);

            _serializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
        }

        public async Task Invoke(HttpContext context)
        {
            context.Features.Set<IAuthenticationFeature>(new AuthenticationFeature
            {
                OriginalPath = context.Request.Path,
                OriginalPathBase = context.Request.PathBase
            });
            //获取默认Scheme（或者AuthorizeAttribute指定的Scheme）的AuthenticationHandler
            var handlers = context.RequestServices.GetRequiredService<IAuthenticationHandlerProvider>();
            foreach (var scheme in await _schemes.GetRequestHandlerSchemesAsync())
            {
                var handler = await handlers.GetHandlerAsync(context, scheme.Name) as IAuthenticationRequestHandler;
                if (handler != null && await handler.HandleRequestAsync())
                {
                    return;
                }
            }
            var defaultAuthenticate = await _schemes.GetDefaultAuthenticateSchemeAsync();
            if (defaultAuthenticate != null)
            {
                var result = await context.AuthenticateAsync(defaultAuthenticate.Name);
                if (result?.Principal != null)
                {
                    context.User = result.Principal;
                }
            }
            //
            // If the request path doesn't match, skip
            if (!context.Request.Path.Equals(_options.Path, StringComparison.Ordinal))
            {
                await _next(context);
                return;
            }

            // Request must be POST with Content-Type: application/x-www-form-urlencoded
            if (!context.Request.Method.Equals("POST")
               || !context.Request.HasFormContentType)
            {
                await ReturnBadRequest(context);
                return;
                //context.Response.StatusCode = 400;
                //return context.Response.WriteAsync("Bad request.");
            }
            //   _logger.LogInformation("Handling request: " + context.Request.Path);

            await GenerateToken(context);
        }
        private Task<ClaimsIdentity> GetIdentity(string username, string password)
        {
            var identity =   _options.IdentityResolver(username, password);

            if (identity!=null)
            {
                return Task.FromResult(new ClaimsIdentity(new System.Security.Principal.GenericIdentity(username, "Token"), new Claim[] { }));

            }
            return Task.FromResult<ClaimsIdentity>(null);
        }
        private async Task GenerateToken(HttpContext context)
        {
            var username = context.Request.Form["username"];
            var password = context.Request.Form["password"];

            var identity = await _options.IdentityResolver(username, password);
            if (identity == null)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync(
                    JsonConvert.SerializeObject(new
                    {
                        Status = false,
                        Message = "Invalid username or password."
                    }));
                return;
            }

            var now = DateTime.UtcNow;

            // Specifically add the jti (nonce), iat (issued timestamp), and sub (subject/user) claims.
            // You can add other claims here, if you want:
            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(JwtRegisteredClaimNames.Jti, await _options.NonceGenerator()),
                new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(now).ToString(), ClaimValueTypes.Integer64),
                    //用户名
                new Claim(ClaimTypes.Name,username),
                //角色
                new Claim(ClaimTypes.Role,"admin")
            };

            // Create the JWT and write it to a string
            var jwt = new JwtSecurityToken(
                issuer: _options.Issuer,
                audience: _options.Audience,
                claims: claims,
                notBefore: now,
                expires: now.Add(_options.Expiration),
                signingCredentials: _options.SigningCredentials);
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                Status=true,
                access_token = encodedJwt,
                expires_in = (int)_options.Expiration.TotalSeconds,
                token_type = "Bearer"
            };

            // Serialize and return the response
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonConvert.SerializeObject(response, _serializerSettings));
        }

        private static void ThrowIfInvalidOptions(TokenProviderOptions options)
        {
            if (string.IsNullOrEmpty(options.Path))
            {
                throw new ArgumentNullException(nameof(TokenProviderOptions.Path));
            }

            if (string.IsNullOrEmpty(options.Issuer))
            {
                throw new ArgumentNullException(nameof(TokenProviderOptions.Issuer));
            }

            if (string.IsNullOrEmpty(options.Audience))
            {
                throw new ArgumentNullException(nameof(TokenProviderOptions.Audience));
            }

            if (options.Expiration == TimeSpan.Zero)
            {
                throw new ArgumentException("Must be a non-zero TimeSpan.", nameof(TokenProviderOptions.Expiration));
            }

            if (options.IdentityResolver == null)
            {
                throw new ArgumentNullException(nameof(TokenProviderOptions.IdentityResolver));
            }

            if (options.SigningCredentials == null)
            {
                throw new ArgumentNullException(nameof(TokenProviderOptions.SigningCredentials));
            }

            if (options.NonceGenerator == null)
            {
                throw new ArgumentNullException(nameof(TokenProviderOptions.NonceGenerator));
            }
        }

        /// <summary>
        /// Get this datetime as a Unix epoch timestamp (seconds since Jan 1, 1970, midnight UTC).
        /// </summary>
        /// <param name="date">The date to convert.</param>
        /// <returns>Seconds since Unix epoch.</returns>
        public static long ToUnixEpochDate(DateTime date) => new DateTimeOffset(date).ToUniversalTime().ToUnixTimeSeconds();

        /// <summary>
        /// return the bad request (200)
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task ReturnBadRequest(HttpContext context)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync(JsonConvert.SerializeObject(new
            {
                Status = false,
                Message = "认证失败"
            }));
        }
    }
}
