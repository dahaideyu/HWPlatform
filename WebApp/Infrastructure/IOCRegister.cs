using HW.Core.EfDbContext;
using HW.Core.IoC;
using HW.Core.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NPOI.OpenXml4Net.OPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Infrastructure
{
    public class IOCRegister
    {

        /// <summary>
        /// IoC初始化
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceProvider InitIoC(IServiceCollection services, IConfiguration Configuration)
        {
            var connectionString = Configuration.GetConnectionString("MsSqlServer");
            var dbContextOption = new DbContextOption
            {
                ConnectionString = connectionString,
                ModelAssemblyName = "HW.SF.Models",
                DbType = DbType.MSSQLSERVER
            };
            var codeGenerateOption = new CodeGenerateOption
            {
                ModelsNamespace = "HW.SF.Models",
                IRepositoriesNamespace = "HW.SF.IRepositories",
                RepositoriesNamespace = "HW.SF.Repositories",
                IServicsNamespace = "HW.SF.IServices",
                ServicesNamespace = "HW.SF.Services"
            };
            IoCContainer.Register(Configuration);//注册配置
            IoCContainer.Register(dbContextOption);//注册数据库配置信息
            IoCContainer.Register(codeGenerateOption);//注册代码生成器相关配置信息
            IoCContainer.Register(typeof(DefaultDbContext));//注册EF上下文
            IoCContainer.Register("HW.SF.Repositories", "HW.SF.IRepositories");//注册仓储
            IoCContainer.Register("HW.SF.Services", "HW.SF.IServices");//注册service
            return IoCContainer.Build(services);
        }
    }
}
