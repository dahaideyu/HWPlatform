using System;
using HW.Core.Repositories;
using HW.SF.Models.SYSModel;
using HW.SF.Models;

namespace HW.SF.IRepositories
{
    public interface IWorkerRepository:IRepository<G_Worker, String>
    {
    }
}