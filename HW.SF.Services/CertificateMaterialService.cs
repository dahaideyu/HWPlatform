using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class CertificateMaterialService: BaseService<Sys_CertificateMaterial, String>, ICertificateMaterialService
    {
        public CertificateMaterialService(ICertificateMaterialRepository repository) : base(repository)
        {
        }
    }
}