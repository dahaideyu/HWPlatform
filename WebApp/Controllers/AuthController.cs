using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using HW.Core.Auth;
using HW.Core.CodeGenerator;
using HW.SF.IServices;
using HW.SF.Models.SYSModel;

namespace WebApp.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/Login")]
    public class AuthController : Controller
    {
        /// <summary>
        /// 自定义策略参数
        /// </summary>
        PermissionRequirement _requirement;
        IUserService _userService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requirement"></param>
        /// <param name="userService"></param>
        public AuthController(PermissionRequirement requirement, IUserService userService)
        {
            _requirement = requirement;
            _userService = userService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/api/login")]
        public IActionResult Login(string username, string password, string role)
        {
            var isValidated = username == "gsw" && password == "111111";
            if (!isValidated)
            {
                return new JsonResult(new
                {
                    Status = false,
                    Message = "认证失败"
                });
            }
            else
            {
                try {
               
                    //如果是基于用户的授权策略，这里要添加用户;如果是基于角色的授权策略，这里要添加角色
                    var claims = new Claim[] { new Claim(ClaimTypes.Name, username), new Claim(ClaimTypes.Role, role), new Claim(ClaimTypes.Expiration, DateTime.Now.AddSeconds(_requirement.Expiration.TotalSeconds).ToString()) };
                    //用户标识
                    var identity = new ClaimsIdentity(JwtBearerDefaults.AuthenticationScheme);
                    identity.AddClaims(claims);
                    var token = JwtToken.BuildJwtToken(claims, _requirement);
                    return new JsonResult(token);
                } catch(Exception ex)
                {
                    return new JsonResult(ex.Message);
                }


           
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/api/CodeGenerate")]
        public string CodeGenerate()
        {
            CodeGenerator.Generate();//生成所有实体类对应的Repository和Service层代码文件
            //CodeGenerator.GenerateSingle<TutorClassType, int>();//生成单个实体类对应的Repository和Service层代码文件
            //var list = iTutorClassTypeService.GetByCache();
            //return View(list);
            return "success";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
      //  [Authorize("Permission")]
        [AllowAnonymous]
        [HttpGet("/api/GetUserInfo")]
        public List<Sys_User> GetUserInfo()
        {
           var userinfolist=  _userService.Get(t=>t.F_EnabledMark==true).ToList();
            return userinfolist;
        }
    }
}