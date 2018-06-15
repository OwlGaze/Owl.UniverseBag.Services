using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Owl.UniverseBag.Application.DTO.AccountModule;
using Owl.UniverseBag.Core.Security;
using Owl.UniverseBag.Domain;
using Owl.UniverseBag.Repository.Repositories.AccountModule;

namespace Owl.UniverseBag.Application.Services.AccountModule
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IPasswordHandler _passwordHandler;

        public AccountService(IUserRepository userRepository, IMapper mapper, IPasswordHandler passwordHandler)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
            this._passwordHandler = passwordHandler;
        }


        public string SignUp(SignUpDto options)
        {
            var user = _userRepository.GetSingleByPhonerNumber(options.PhoneNumber);
            if (user != null)
                throw new ArgumentException("该用户已注册！");

            var salt = _passwordHandler.GenerateSalt();
            var password = _passwordHandler.Encryption(options.Password, salt);
            _userRepository.AddUser(new User
            {
                PhoneNumber = options.PhoneNumber,
                Password = password,
                Salt = salt,
                RegisterTime = DateTime.Now
            });
        }
    }
}
