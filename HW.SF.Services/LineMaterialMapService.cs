using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class LineMaterialMapService: BaseService<Sys_LineMaterialMap, String>, ILineMaterialMapService
    {
        public LineMaterialMapService(ILineMaterialMapRepository repository) : base(repository)
        {
        }
    }
}