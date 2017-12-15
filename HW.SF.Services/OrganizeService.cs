using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class OrganizeService: BaseService<Sys_Organize, String>, IOrganizeService
    {
        public OrganizeService(IOrganizeRepository repository) : base(repository)
        {
        }
    }
}