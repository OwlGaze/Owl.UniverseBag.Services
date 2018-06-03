using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;

namespace Owl.UniverseBag.Domain
{
    public static class DbSeed
    {
        public static void Init(UBContext ubContext)
        {
            if (ubContext.Users.Any())
                return;
            ubContext.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                PhoneNumber = "13812341234",
                Password = "666",
                Salt = "xxx",
                RegisterTime = DateTime.Now
            });
            ubContext.SaveChanges();
        }
    }
}
