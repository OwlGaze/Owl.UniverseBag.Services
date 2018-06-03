using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult SignUp()
        {
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
    }
}