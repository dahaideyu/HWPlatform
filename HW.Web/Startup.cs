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
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using HW.Web.Infrastructure;
using HW.Core.Auth;

namespace HW.Web
{
    public class Startup
    {
        private Auth auth = new Auth();
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
         //   services.AddCors(options =>
         //options.AddPolicy("MyDomain",
         //builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin().AllowCredentials()));
            
            services.AddMvc();
            //配置验证
            auth.ConfigureAuthService(services, Configuration);
            return IOCRegister.InitIoC(services, Configuration);
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
            auth.ConfigureAuthApplication(app);
            app.UseExceptionHandler();
           // app.UseMiddleware<TokenProviderMiddleware>();
            app.UseMvc();
            app.UseMvcWithDefaultRoute();
        }
    }
}
