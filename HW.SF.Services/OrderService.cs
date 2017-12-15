using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class OrderService: BaseService<G_Order, String>, IOrderService
    {
        public OrderService(IOrderRepository repository) : base(repository)
        {
        }
    }
}