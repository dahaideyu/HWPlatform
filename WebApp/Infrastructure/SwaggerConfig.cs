using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Infrastructure
{
    /// <summary>
    /// swagger core config
    /// </summary>
    public class  SwaggerConfig
    {
        /// <summary>
        /// addswagger genernter config
        /// </summary>
        /// <param name="services"></param>
        public static void AddSwaggerGen(IServiceCollection services)
        {
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
        }
        /// <summary>
        /// swaggerUI config
        /// </summary>
        /// <param name="app"></param>
        public static void UseSwaggerUI(IApplicationBuilder app)
        {
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
