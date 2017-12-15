using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class BomService: BaseService<Sys_Bom, String>, IBomService
    {
        public BomService(IBomRepository repository) : base(repository)
        {
        }
    }
}