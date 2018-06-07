using System;
using System.Collections.Generic;
using System.Text;
using Owl.UniverseBag.Domain;

namespace Owl.UniverseBag.Repository.Repositories.AccountModule
{
    public interface IUserRepository
    {
        Guid AddUser(User user);
    }
}
