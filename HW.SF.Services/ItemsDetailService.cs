using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class ItemsDetailService: BaseService<Sys_ItemsDetail, String>, IItemsDetailService
    {
        public ItemsDetailService(IItemsDetailRepository repository) : base(repository)
        {
        }
    }
}