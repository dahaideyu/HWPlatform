using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;

namespace HW.Web.Controllers
{

    
    public class UserController : Controller
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [Route("api/User/GetUser")]
        [HttpGet]
        [Authorize]
        public List<Sys_User> GetUser()
        {

            return _userService.Get().ToList();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
    }
}