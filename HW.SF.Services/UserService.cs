using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class UserService: BaseService<Sys_User, String>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }
    }
}