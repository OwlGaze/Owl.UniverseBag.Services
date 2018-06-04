using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Owl.UniverseBag.Application.DTO.AccountModule;

namespace Owl.UniverseBag.WebApi.Controllers.AccountModule
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        [HttpPost("signup")]
        public ActionResult SignUp(SignUpDto options)
        {
            if (options == null)
                return BadRequest();
            //if(options.PhoneNumber notPhoneNumber)
            //    ModelState.AddModelError("PhoneNumber","无效的电话号码");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [HttpPost("signin")]
        public ActionResult SignIn()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:guid}/signout")]
        public ActionResult SignOut(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("test")]
        public ActionResult Test()
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Debug($"{nameof(AccountController)}/{nameof(Test)}");
            throw new Exception("xxxaaat");
        }
    }
}