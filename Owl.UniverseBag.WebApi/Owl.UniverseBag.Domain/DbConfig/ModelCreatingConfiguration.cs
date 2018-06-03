using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Owl.UniverseBag.Domain.DbConfig
{
    public static class ModelCreatingConfiguration
    {
        public static void Initial(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().ToTable("User").Property(d => d.PhoneNumber).IsUnicode();
        }
    }
}
