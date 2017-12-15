using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class CertificateWorkAreaService: BaseService<Sys_CertificateWorkArea, String>, ICertificateWorkAreaService
    {
        public CertificateWorkAreaService(ICertificateWorkAreaRepository repository) : base(repository)
        {
        }
    }
}