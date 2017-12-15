using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class RoleService: BaseService<Sys_Role, String>, IRoleService
    {
        public RoleService(IRoleRepository repository) : base(repository)
        {
        }
    }
}