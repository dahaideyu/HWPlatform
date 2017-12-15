using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class CertificateService: BaseService<Sys_Certificate, String>, ICertificateService
    {
        public CertificateService(ICertificateRepository repository) : base(repository)
        {
        }
    }
}