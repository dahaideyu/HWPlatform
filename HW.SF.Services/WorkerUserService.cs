using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class WorkerUserService: BaseService<G_WorkerUser, String>, IWorkerUserService
    {
        public WorkerUserService(IWorkerUserRepository repository) : base(repository)
        {
        }
    }
}