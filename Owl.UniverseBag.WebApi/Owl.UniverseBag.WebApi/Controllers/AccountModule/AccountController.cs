using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Owl.UniverseBag.Application.DTO;
using Owl.UniverseBag.Application.DTO.AccountModule;
using Owl.UniverseBag.Application.Services.AccountModule;

namespace Owl.UniverseBag.WebApi.Controllers.AccountModule
{
    public class AccountController : BaseController
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
        public ActionResult SignUp([FromBody]SignUpDto options)
        {
            if (options == null)
                return BadRequest();
            var validResult = options.Validate<SignUpDto, SignUpDtoValidate>();
            if (!validResult.IsValid)
                return BadRequest(validResult.Errors);

            return Ok(_accountService.SignUp(options));
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