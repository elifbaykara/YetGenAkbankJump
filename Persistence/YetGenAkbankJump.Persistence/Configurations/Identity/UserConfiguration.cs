using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.Domain.Entities;
using YetGenAkbankJump.Domain.Identity;

namespace YetGenAkbankJump.Persistence.Configurations.Identity
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {

            
            builder.HasKey(u => u.Id);

           
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            
            builder.ToTable("Users");

            
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

           
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            builder.Property(x=> x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(70);

            builder.Property(x => x.SurName).IsRequired();
            builder.Property(x => x.SurName).HasMaxLength(70);

            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Gender).HasConversion<int>();

            builder.Property(x => x.BirthDate).IsRequired(false);
            
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

            builder.Property(x => x.CreatedOn).IsRequired();

            builder.Property(x => x.ModifiedByUserId).IsRequired(false);

            builder.Property(x => x.LastModifiedOn).IsRequired(false);

        }
    }
}
