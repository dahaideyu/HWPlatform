using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class WorkerStatusService: BaseService<G_WorkerStatus, String>, IWorkerStatusService
    {
        public WorkerStatusService(IWorkerStatusRepository repository) : base(repository)
        {
        }
    }
}