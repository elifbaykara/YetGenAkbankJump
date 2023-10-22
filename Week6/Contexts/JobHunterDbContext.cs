using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Entities;

namespace Week6.Contexts
{
    public class JobHunterDbContext : DbContext  //DbContext kullanabilmek için dependencies sağ tık nuget packages ve microsoftentityframework core indir

    {
        public DbSet<JobPost> JobPosts { get; set; } //veritabanında jobposts adında tablom olacak içinde de job postlar olacak

        //şimdi de veritabanımın adresini ve ismini gireceğim

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.151.83.102;Port=5432;Database=JobHunterElifBaykara;User Id=hakanamaratliteam;Password=oyi6IkdAQ*pL7qutMo4Q4FgpL;");
        }


    }
}
