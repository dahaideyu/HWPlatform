using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class MaterialService: BaseService<Sys_Material, String>, IMaterialService
    {
        public MaterialService(IMaterialRepository repository) : base(repository)
        {
        }
    }
}