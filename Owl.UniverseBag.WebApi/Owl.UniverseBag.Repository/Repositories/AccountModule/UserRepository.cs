using System;
using System.Collections.Generic;
using System.Linq;
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

        public User Find(Guid id)
        {
            return db.Find<User>(id);
        }


        public User GetSingleByPhonerNumber(string phoneNumber)
        {
            return db.Users.SingleOrDefault(d => d.PhoneNumber == phoneNumber);
        }

        public User GetSingleByParams(string phoneNumber, string password)
        {
            return db.Users.SingleOrDefault(d => d.PhoneNumber == phoneNumber && d.Password == password);
        }

        public Guid AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.Id;
        }

    }
}
