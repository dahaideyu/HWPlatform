using System;
using HW.SF.Models;
using HW.Core.Repositories;
using HW.SF.Models.SYSModel;
using HW.Core.EfDbContext;
using HW.SF.IRepositories;
using HW.SF.Models;

namespace HW.SF.Repositories
{
    public class ModuleFormInstanceRepository : BaseRepository<Sys_ModuleFormInstance, String>, IModuleFormInstanceRepository
    {
        public ModuleFormInstanceRepository(DefaultDbContext dbContext) : base(dbContext)
        {
        }
    }
}