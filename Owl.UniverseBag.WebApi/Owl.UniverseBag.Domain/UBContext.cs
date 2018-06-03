using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Owl.UniverseBag.Domain.DbConfig;

namespace Owl.UniverseBag.Domain
{
    public class UBContext : DbContext
    {
        public UBContext(DbContextOptions<UBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelCreatingConfiguration.Initial(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<User> Users { get; set; }
    }
}
