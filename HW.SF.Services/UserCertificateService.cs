using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class UserCertificateService: BaseService<Sys_UserCertificate, String>, IUserCertificateService
    {
        public UserCertificateService(IUserCertificateRepository repository) : base(repository)
        {
        }
    }
}