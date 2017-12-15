using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class LogService: BaseService<Sys_Log, String>, ILogService
    {
        public LogService(ILogRepository repository) : base(repository)
        {
        }
    }
}