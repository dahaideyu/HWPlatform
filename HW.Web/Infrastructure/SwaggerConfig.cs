using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HW.Web.Infrastructure
{
    /// <summary>
    /// web api swagger config
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// startup service config
        /// </summary>
        /// <param name="services"></param>
        public static void ServicesConfig(IServiceCollection services)
        {
            services.AddSwaggerGen();
            services.ConfigureSwaggerGen(options =>
            {
                options.SingleApiVersion(new Swashbuckle.Swagger.Model.Info
                {
                    Version = "v1",
                    Title = "My Web Application",
                    Description = "RESTful API for My Web PMS",
                    TermsOfService = "None"
                });
                options.IncludeXmlComments(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                    "HW.Web.xml")); // 注意：此处替换成所生成的XML documentation的文件名。
                options.DescribeAllEnumsAsStrings();
            });
        }
        /// <summary>
        /// app swagger config
        /// </summary>
        /// <param name="app"></param>
        public static void AppConfig(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUi();
        }

    }
}
