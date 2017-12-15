using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class WorkerStatusTypeService: BaseService<Sys_WorkerStatusType, String>, IWorkerStatusTypeService
    {
        public WorkerStatusTypeService(IWorkerStatusTypeRepository repository) : base(repository)
        {
        }
    }
}