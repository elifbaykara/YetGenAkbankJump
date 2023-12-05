using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJump.Persistence.Contexts
{
    public class YetGenIdentityDbContextFactory : IDesignTimeDbContextFactory<YetGenIdentityContext>
    {
 
        YetGenIdentityContext IDesignTimeDbContextFactory<YetGenIdentityContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<YetGenIdentityContext>();

            var connectionString = configuration.GetSection("YetgenPostgreSQLDB").Value;

            optionsBuilder.UseNpgsql(connectionString);

            return new YetGenIdentityContext(optionsBuilder.Options);
        }
    }
}
