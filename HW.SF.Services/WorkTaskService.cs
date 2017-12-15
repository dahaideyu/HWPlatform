using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class WorkTaskService: BaseService<G_WorkTask, String>, IWorkTaskService
    {
        public WorkTaskService(IWorkTaskRepository repository) : base(repository)
        {
        }
    }
}