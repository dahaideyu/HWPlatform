using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class WorkAreaService: BaseService<Sys_WorkArea, String>, IWorkAreaService
    {
        public WorkAreaService(IWorkAreaRepository repository) : base(repository)
        {
        }
    }
}