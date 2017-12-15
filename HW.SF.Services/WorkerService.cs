using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class WorkerService: BaseService<G_Worker, String>, IWorkerService
    {
        public WorkerService(IWorkerRepository repository) : base(repository)
        {
        }
    }
}