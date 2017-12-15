using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class RoleAuthorizeService: BaseService<Sys_RoleAuthorize, String>, IRoleAuthorizeService
    {
        public RoleAuthorizeService(IRoleAuthorizeRepository repository) : base(repository)
        {
        }
    }
}