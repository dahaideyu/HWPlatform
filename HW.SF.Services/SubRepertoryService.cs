using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class SubRepertoryService: BaseService<G_SubRepertory, String>, ISubRepertoryService
    {
        public SubRepertoryService(ISubRepertoryRepository repository) : base(repository)
        {
        }
    }
}