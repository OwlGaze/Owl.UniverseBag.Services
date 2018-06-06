using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Owl.UniverseBag.Application.DTO.AccountModule;
using Owl.UniverseBag.Domain;

namespace Owl.UniverseBag.Application.Services.AccountModule
{
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;

        public AccountService(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public void Test()
        {
            var dto = new UserDto { Salt = "111"};
            var user = _mapper.Map<User>(dto);
            return;
        }
    }
}
