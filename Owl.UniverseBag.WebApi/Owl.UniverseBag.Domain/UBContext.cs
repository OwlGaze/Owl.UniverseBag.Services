using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Owl.UniverseBag.Domain
{
    public class UBContext : DbContext
    {
        public UBContext(DbContextOptions<UBContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
    }
}
