using System;
using System.IO;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DemoProject.Database;
using DemoProject.Database.Interfaces;
using DemoProject.Database.Tables;
using DemoProject.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace DemoProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
                .UseEnvironment("Development")
                .ConfigureHostConfiguration(configurationBuilder => { configurationBuilder.AddEnvironmentVariables(); })
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureServices((context, collection) =>
                {
                    collection.AddTransient<IDataStore, DataStore>();
                    collection.AddHostedService<IssueDemoRunner>();
                    collection.AddDbContext<PacketTablesContext>(ctxBuilder =>
                    {
                        ctxBuilder.UseSqlServer(context.Configuration["Storage:Database:ConnectionString"], optionsBuilder =>
                        {
                            optionsBuilder.EnableRetryOnFailure(10, TimeSpan.FromSeconds(60), null);
                        });
                    }, ServiceLifetime.Transient);
                })
                .ConfigureAppConfiguration((context, configurationBuilder) =>
                {
                    configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
                    configurationBuilder.AddJsonFile("appsettings.json", optional: true);
                    configurationBuilder.AddEnvironmentVariables();
                })
                .ConfigureContainer<ContainerBuilder>(containerBuilder => { })
                .UseSerilog((context, c) => { ConfigureLogger(c, context); })
                .UseConsoleLifetime();

            using (var host = builder.Build())
            {
                var ctx = host.Services.GetService<PacketTablesContext>();
                await ctx.Database.MigrateAsync();
                await host.RunAsync();
            }
        }

        private static void ConfigureLogger(LoggerConfiguration loggerConfig, HostBuilderContext context)
        {
            loggerConfig
                .ReadFrom.Configuration(context.Configuration, "Logging")
                .WriteTo.Console()
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext();
        }
    }
}