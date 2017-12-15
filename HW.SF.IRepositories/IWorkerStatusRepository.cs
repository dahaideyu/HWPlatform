using System;
using HW.Core.Repositories;
using HW.SF.Models.SYSModel;
using HW.SF.Models;

namespace HW.SF.IRepositories
{
    public interface IWorkerStatusRepository:IRepository<G_WorkerStatus, String>
    {
    }
}