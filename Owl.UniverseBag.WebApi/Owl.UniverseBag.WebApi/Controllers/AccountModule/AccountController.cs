using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Owl.UniverseBag.Application.DTO.AccountModule;
using Owl.UniverseBag.Application.MapperConfiguration;
using Owl.UniverseBag.Application.Services.AccountModule;
using Owl.UniverseBag.Domain;

namespace Owl.UniverseBag.WebApi.Controllers.AccountModule
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            this._accountService = accountService;
            this._mapper = mapper;
        }

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
            //var logger = NLog.LogManager.GetCurrentClassLogger();
            //logger.Debug($"{nameof(AccountController)}/{nameof(Test)}");
            //throw new Exception("xxxaaat");
            //_accountService.Test();

            var userDto = new UserDto
            {
                Password = "pwd",
                PhoneNumber = "133",
                Salt = "aaa"
            };
            
            var user =  _mapper.Map<User>(userDto);

            return NoContent();
        }
    }
}