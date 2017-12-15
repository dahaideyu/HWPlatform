using System;
using HW.SF.Models;
using HW.Core.Repositories;
using HW.SF.Models.SYSModel;
using HW.Core.EfDbContext;
using HW.SF.IRepositories;
using HW.SF.Models;

namespace HW.SF.Repositories
{
    public class SubRepertoryRepository : BaseRepository<G_SubRepertory, String>, ISubRepertoryRepository
    {
        public SubRepertoryRepository(DefaultDbContext dbContext) : base(dbContext)
        {
        }
    }
}