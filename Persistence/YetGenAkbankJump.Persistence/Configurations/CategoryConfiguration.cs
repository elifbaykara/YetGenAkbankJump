using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.Domain.Entities;

namespace YetGenAkbankJump.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //id -primary key
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            //name

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(200);

            //CreatedByUserId
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

            //CreatedOn

            builder.Property(x => x.CreatedOn).IsRequired();

            //ModifiedByUserId

            builder.Property(x => x.ModifiedByUserId).IsRequired(false);
            builder.Property(x => x.ModifiedByUserId).HasMaxLength(75);

            //LastModifiedOn

            builder.Property(x => x.LastModifiedOn).IsRequired(false);

            //DeletedByUserId

            builder.Property(x => x.DeletedByUserId).IsRequired(false);
            builder.Property(x => x.DeletedByUserId).HasMaxLength(75);

            //DeletedOn

            builder.Property(x => x.DeletedOn).IsRequired(false);

            //IsDeleted
            builder.Property(x => x.IsDeleted).IsRequired();

            //RELATIONSHIPS

            //builder.HasMany<Product>(x => x.Products) //buradaki x = category !!!!!
            //    .WithOne(x => x.Category)
            //    .HasForeignKey(x => x.Category.Id);  //bire çok ilişkiyi konfigüre ettik(category tarafından)


            builder.ToTable("Categories");
        }
    }
}
