using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.Domain.Entities;

namespace YetGenAkbankJump.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //id -primary key
            builder.HasKey(x=> x.Id);
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();

            //firstname

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(60);

            //lastname
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(60);

            //country
            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(60);

            //city
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.City).HasMaxLength(150);

            //company
            builder.Property(x => x.Company).IsRequired();
            builder.Property(x => x.Company).HasMaxLength(250);

            //age
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Age).HasConversion<int>();

            //registrationfee

            builder.Property(x=>x.RegistrationFee).IsRequired(false);
            builder.Property(x => x.RegistrationFee).HasColumnType("decimal(19,2)");

            //gender

            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Gender).HasConversion<int>(); //enumda değerleri 0,1 olarak atadığımız için int olarak kullanabiliriz.
            
            //IsGraduated

            builder.Property(x=>x.IsGraduated).IsRequired();
            builder.Property(x => x.IsGraduated).HasDefaultValueSql("false");
            

            //COMMON FIELDS
            
            //CreatedByUserId
            builder.Property(x=>x.CreatedByUserId).IsRequired();
            builder.Property(x=>x.CreatedByUserId).HasMaxLength(75);

            //CreatedOn

            builder.Property(x=>x.CreatedOn).IsRequired();
            
            //ModifiedByUserId

            builder.Property(x=>x.ModifiedByUserId).IsRequired(false);
            builder.Property(x => x.ModifiedByUserId).HasMaxLength(75);

            //LastModifiedOn

            builder.Property(x=>x.LastModifiedOn).IsRequired(false);

            //DeletedByUserId

            builder.Property(x=>x.DeletedByUserId).IsRequired(false);
            builder.Property(x => x.DeletedByUserId).HasMaxLength(75);

            //DeletedOn

            builder.Property(x=>x.DeletedOn).IsRequired(false);

            //IsDeleted
            builder.Property(x=>x.IsDeleted).IsRequired();



            builder.ToTable("Students");

        }
    }
}

