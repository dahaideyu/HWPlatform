using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class LineService: BaseService<Sys_Line, String>, ILineService
    {
        public LineService(ILineRepository repository) : base(repository)
        {
        }
    }
}