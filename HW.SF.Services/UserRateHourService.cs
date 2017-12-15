using System;
using HW.SF.IRepositories;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;
using HW.Core.Services;
namespace HW.SF.Services
{
    public class UserRateHourService: BaseService<G_UserRateHour, String>, IUserRateHourService
    {
        public UserRateHourService(IUserRateHourRepository repository) : base(repository)
        {
        }
    }
}