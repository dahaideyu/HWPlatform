using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class OutSubRepertoryService: BaseService<G_OutSubRepertory, String>, IOutSubRepertoryService
    {
        public OutSubRepertoryService(IOutSubRepertoryRepository repository) : base(repository)
        {
        }
    }
}