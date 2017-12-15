using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class DbBackupService: BaseService<Sys_DbBackup, String>, IDbBackupService
    {
        public DbBackupService(IDbBackupRepository repository) : base(repository)
        {
        }
    }
}