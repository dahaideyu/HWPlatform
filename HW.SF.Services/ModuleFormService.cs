using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class ModuleFormService: BaseService<Sys_ModuleForm, String>, IModuleFormService
    {
        public ModuleFormService(IModuleFormRepository repository) : base(repository)
        {
        }
    }
}