using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfInterest.Models
{
    public class Db : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseNpgsql(configuration["DbConnectionString"]);
            optionsBuilder.UseLoggerFactory(new LoggerFactory().AddConsole(configuration.GetSection("Logging")));
        }
        public DbSet<Rumah> Rumah { get; set; }
    }
}
