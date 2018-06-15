using System;
using System.Collections.Generic;
using System.Text;
using Owl.UniverseBag.Application.DTO.AccountModule;

namespace Owl.UniverseBag.Application.Services.AccountModule
{
    public interface IAccountService
    {
        string SignUp(SignUpDto options);
    }
}
