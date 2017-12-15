using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class ModuleService: BaseService<Sys_Module, String>, IModuleService
    {
        public ModuleService(IModuleRepository repository) : base(repository)
        {
        }
    }
}