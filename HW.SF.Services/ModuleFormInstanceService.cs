using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class ModuleFormInstanceService: BaseService<Sys_ModuleFormInstance, String>, IModuleFormInstanceService
    {
        public ModuleFormInstanceService(IModuleFormInstanceRepository repository) : base(repository)
        {
        }
    }
}