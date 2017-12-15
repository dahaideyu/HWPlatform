using System;
using HW.SF.Models;
using HW.Core.Repositories;
using HW.SF.Models.SYSModel;
using HW.Core.EfDbContext;
using HW.SF.IRepositories;
using HW.SF.Models;

namespace HW.SF.Repositories
{
    public class WorkerStatusLogRepository : BaseRepository<G_WorkerStatusLog, String>, IWorkerStatusLogRepository
    {
        public WorkerStatusLogRepository(DefaultDbContext dbContext) : base(dbContext)
        {
        }
    }
}