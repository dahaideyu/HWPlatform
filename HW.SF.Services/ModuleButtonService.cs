using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class ModuleButtonService: BaseService<Sys_ModuleButton, String>, IModuleButtonService
    {
        public ModuleButtonService(IModuleButtonRepository repository) : base(repository)
        {
        }
    }
}