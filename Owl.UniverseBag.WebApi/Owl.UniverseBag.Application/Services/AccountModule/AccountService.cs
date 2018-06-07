using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Owl.UniverseBag.Application.DTO.AccountModule;
using Owl.UniverseBag.Domain;
using Owl.UniverseBag.Repository.Repositories.AccountModule;

namespace Owl.UniverseBag.Application.Services.AccountModule
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AccountService(IUserRepository userRepository, IMapper mapper)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
        }

        public void Test()
        {
            //var dto = new UserDto { Salt = "111" };
            //var user = _mapper.Map<User>(dto);
            var user = new User();
            _userRepository.AddUser(user);

            return;
        }
    }
}
