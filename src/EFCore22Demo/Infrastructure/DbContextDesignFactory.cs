using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using DemoProject.Database.Tables;

namespace DemoProject.Infrastructure
{
    public class DbContextDesignFactory : IDesignTimeDbContextFactory<PacketTablesContext>
    {
        public PacketTablesContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<PacketTablesContext>();

            builder.UseSqlServer(configuration["Storage:Database:ConnectionString"]);

            return new PacketTablesContext(builder.Options);
        }
    }
}