using System;
using HW.SF.Models;
using HW.Core.Repositories;
using HW.SF.Models.SYSModel;
using HW.Core.EfDbContext;
using HW.SF.IRepositories;
using HW.SF.Models;

namespace HW.SF.Repositories
{
    public class CertificateRepository : BaseRepository<Sys_Certificate, String>, ICertificateRepository
    {
        public CertificateRepository(DefaultDbContext dbContext) : base(dbContext)
        {
        }
    }
}