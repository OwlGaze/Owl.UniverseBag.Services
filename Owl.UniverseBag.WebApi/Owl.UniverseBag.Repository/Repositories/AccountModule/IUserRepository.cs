using System;
using System.Collections.Generic;
using System.Text;
using Owl.UniverseBag.Domain;

namespace Owl.UniverseBag.Repository.Repositories.AccountModule
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetSingleByPhonerNumber(string phoneNumber);
        User GetSingleByParams(string phoneNumber, string password);
        Guid AddUser(User user);
    }
}
