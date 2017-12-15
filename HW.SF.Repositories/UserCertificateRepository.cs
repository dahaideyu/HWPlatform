using System;
using HW.SF.Models;
using HW.Core.Repositories;
using HW.SF.Models.SYSModel;
using HW.Core.EfDbContext;
using HW.SF.IRepositories;
using HW.SF.Models;

namespace HW.SF.Repositories
{
    public class UserCertificateRepository : BaseRepository<Sys_UserCertificate, String>, IUserCertificateRepository
    {
        public UserCertificateRepository(DefaultDbContext dbContext) : base(dbContext)
        {
        }
    }
}