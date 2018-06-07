using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Owl.UniverseBag.Domain;

namespace Owl.UniverseBag.Repository.EntityTypeConfiguration.AccountModule
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey(d => d.Id);
            builder.Property(d => d.PhoneNumber).IsRequired().HasMaxLength(11);
            builder.Property(d => d.Password).IsRequired();
            builder.Property(d => d.Salt).IsRequired().HasMaxLength(8);
            builder.Property(d => d.RegisterTime).IsRequired();
            builder.Property(d => d.IsDeleted).IsRequired().HasDefaultValue(false);
        }
    }
}
