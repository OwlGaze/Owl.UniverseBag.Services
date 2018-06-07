using System;
using System.Collections.Generic;
using System.Text;
using Owl.UniverseBag.Domain;

namespace Owl.UniverseBag.Repository.Repositories.AccountModule
{
    public class UserRepository : IUserRepository
    {
        private readonly UBContext db;
        public UserRepository(UBContext ubContext)
        {
            db = ubContext;
        }

        public Guid AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.Id;
        }
    }
}
