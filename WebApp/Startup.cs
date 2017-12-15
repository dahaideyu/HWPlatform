using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using HW.Core.Auth;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using HW.Core.Options;
using HW.Core.IoC;
using HW.Core.EfDbContext;
using WebApp.Infrastructure;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.Distributed;
using HW.Core.Filters;
using HW.Core.Helpers;
using log4net.Repository;
using log4net;

namespace WebApp
{
    public class Startup
    {
        public static ILoggerRepository repository { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //初始化log4net
            repository = LogManager.CreateRepository("NETCoreRepository");
            Log4NetHelper.SetConfig(repository, "log4net.config");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var urls = "http://localhost:6901/";
            services.AddCors(options =>
            options.AddPolicy("MyDomain",
        builder => builder.WithOrigins(urls).AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin().AllowCredentials()));

            //读取配置文件
            var audienceConfig = Configuration.GetSection("Audience");
            var symmetricKeyAsBase64 = audienceConfig["Secret"];
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,
                ValidateIssuer = true,
                ValidIssuer = audienceConfig["Issuer"],//发行人
                ValidateAudience = true,
                ValidAudience = audienceConfig["Audience"],//订阅人
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                RequireExpirationTime = true,

            };
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            //这个集合模拟用户权限表,可从数据库中查询出来
            var permission = new List<Permission> {
                              new Permission {  Url="/", Name="admin"},
                              new Permission {  Url="/api/values", Name="admin"},
                              new Permission {  Url="/", Name="system"},
                              new Permission {  Url="/api/values1", Name="system"}
                          };
            //如果第三个参数，是ClaimTypes.Role，上面集合的每个元素的Name为角色名称，如果ClaimTypes.Name，即上面集合的每个元素的Name为用户名
            var permissionRequirement = new PermissionRequirement(
                "/api/denied", permission,
                ClaimTypes.Role,
                audienceConfig["Issuer"],
                audienceConfig["Audience"],
                signingCredentials,
                expiration: TimeSpan.FromSeconds(10)
                );
            services.AddAuthorization(options =>
            {

                options.AddPolicy("Permission",
                          policy => policy.Requirements.Add(permissionRequirement));

            }).AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                //不使用https
                o.RequireHttpsMetadata = false;
                o.TokenValidationParameters = tokenValidationParameters;
                o.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        if (context.Request.Path.Value.ToString() == "/api/logout")
                        {
                            var token = ((context as TokenValidatedContext).SecurityToken as JwtSecurityToken).RawData;
                        }
                        return Task.CompletedTask;
                    }
                };
            });
            //注入授权Handler
            services.AddSingleton<IAuthorizationHandler, PermissionHandler>();
            services.AddSingleton(permissionRequirement);
            services.AddMvc(option =>
            {
                option.Filters.Add(new GlobalExceptionFilter());
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "  Test",
                    Version = "v1",
                    Description = " 测试Web API ",
                    TermsOfService = "None",
                    Contact = new Swashbuckle.AspNetCore.Swagger.Contact
                    {
                        Name = "lucus",
                        Email = "dahaideyu@sina.com"
                    },
                });
                var filePath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "WebApp.xml");
                c.IncludeXmlComments(filePath);
                c.CustomSchemaIds((type) => type.FullName);
            });
            services.AddMemoryCache();//启用MemoryCache
            services.Configure<MemoryCacheEntryOptions>(
                    options => options.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)) //设置MemoryCache缓存有效时间为5分钟。
                .Configure<DistributedCacheEntryOptions>(option =>
                    option.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5));//设置Redis缓存有效时间为5分钟。
          return  IOCRegister.InitIoC(services, Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseMvc();
            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.Host = httpReq.Host.Value);
                c.RouteTemplate = "docs/{documentName}/swagger.json";
            });
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "docs";
                c.SwaggerEndpoint("/docs/v1/swagger.json", "API V1");
                c.InjectStylesheet("/swagger-ui/custom.css");
                c.InjectOnCompleteJavaScript("/swagger-ui/custom.js");
            });
        }

    }
}
