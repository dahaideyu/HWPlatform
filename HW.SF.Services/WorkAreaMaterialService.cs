using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class WorkAreaMaterialService: BaseService<Sys_WorkAreaMaterial, String>, IWorkAreaMaterialService
    {
        public WorkAreaMaterialService(IWorkAreaMaterialRepository repository) : base(repository)
        {
        }
    }
}