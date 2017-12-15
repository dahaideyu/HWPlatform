using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class UserLogOnService: BaseService<Sys_UserLogOn, String>, IUserLogOnService
    {
        public UserLogOnService(IUserLogOnRepository repository) : base(repository)
        {
        }
    }
}