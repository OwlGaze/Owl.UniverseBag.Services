using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Owl.UniverseBag.Repository.EntityTypeConfiguration.AccountModule;

namespace Owl.UniverseBag.Domain.DbConfig
{
    public static class ModelCreatingConfiguration
    {
        public static void Initial(ModelBuilder modelBuilder)
        {
            #region AccountModule

            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());

            #endregion
        }
    }
}
