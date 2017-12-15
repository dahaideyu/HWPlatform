using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class FilterIPService: BaseService<Sys_FilterIP, String>, IFilterIPService
    {
        public FilterIPService(IFilterIPRepository repository) : base(repository)
        {
        }
    }
}