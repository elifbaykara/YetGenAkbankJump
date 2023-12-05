using Microsoft.EntityFrameworkCore;
using YetGenAkbankJump.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using YetGenAkbankJump.Domain.Identity;

namespace YetGenAkbankJump.Persistence.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Ignore<Student>();
            modelBuilder.Ignore<Product>();
            modelBuilder.Ignore<Category>();
            modelBuilder.Ignore<ProductCategory>();




            base.OnModelCreating(modelBuilder);
        }
    }
}
