using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class CallAPIResultService: BaseService<G_CallAPIResult, String>, ICallAPIResultService
    {
        public CallAPIResultService(ICallAPIResultRepository repository) : base(repository)
        {
        }
    }
}