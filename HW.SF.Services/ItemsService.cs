using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class ItemsService: BaseService<Sys_Items, String>, IItemsService
    {
        public ItemsService(IItemsRepository repository) : base(repository)
        {
        }
    }
}