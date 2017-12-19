using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.IdentityModel.Tokens;
using HW.Core.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace HW.Web.Infrastructure
{
    public class Auth
    {
        // The secret key every token will be signed with.
        // Keep this safe on the server!
        private static readonly string secretKey = "mysupersecret_secretkey!123";
        private static readonly SymmetricSecurityKey signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));
        public void ConfigureAuthApplication(IApplicationBuilder app)
        {
            app.UseAuthentication();
            //app.UseTokenProvider(new TokenProviderOptions
            //{
            //    Path = "/api/token",
            //    Audience = "ExampleAudience",
            //    Issuer = "ExampleIssuer",
            //    SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256),
            //    IdentityResolver = GetIdentity
            //});


        }
        public void ConfigureAuthService(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "Jwt";
                options.DefaultChallengeScheme = "Jwt";
            }).AddJwtBearer("Jwt", options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    //ValidAudience = "the audience you want to validate",
                    ValidateIssuer = false,
                    //ValidIssuer = "the isser you want to validate",

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("the secret that needs to be at least 16 characeters long for HmacSha256")),

                    ValidateLifetime = true, //validate the expiration and not before values in the token

                    ClockSkew = TimeSpan.FromMinutes(5) //5 minute tolerance for the expiration date
                };
            });

            //var audienceConfig = Configuration.GetSection("Audience");
            //var symmetricKeyAsBase64 = audienceConfig["Secret"];
            //var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            //var signingKey = new SymmetricSecurityKey(keyByteArray);
            //var tokenValidationParameters = new TokenValidationParameters
            //{

            //    // The signing key must match!
            //    ValidateIssuerSigningKey = true,
            //    IssuerSigningKey = signingKey,

            //    // Validate the JWT Issuer (iss) claim
            //    ValidateIssuer = true,
            //    ValidIssuer = audienceConfig["Issuer"],

            //    // Validate the JWT Audience (aud) claim
            //    ValidateAudience = true,
            //    ValidAudience = audienceConfig["Audience"],

            //    // Validate the token expiry
            //    ValidateLifetime = true,

            //    ClockSkew = TimeSpan.Zero
            //};
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(o =>
            //{
            //    //不使用https
            //    //o.RequireHttpsMetadata = false;
            //    o.TokenValidationParameters = tokenValidationParameters;
            //});

        }

        private Task<ClaimsIdentity> GetIdentity(string username, string password)
        {
            // Don't do this in production, obviously!
            if (username == "TEST" && password == "TEST123")
            {
                return Task.FromResult(new ClaimsIdentity(new GenericIdentity(username, "Token"), new Claim[] { }));
            }

            // Credentials are invalid, or account doesn't exist
            return Task.FromResult<ClaimsIdentity>(null);
        }
    }
}
