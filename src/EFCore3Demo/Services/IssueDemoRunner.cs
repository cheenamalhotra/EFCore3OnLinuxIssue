using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using DemoProject.Database.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using DemoProject.Models;

namespace DemoProject.Services
{
    internal class IssueDemoRunner : BackgroundService
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger _logger;

        public IssueDemoRunner(ILifetimeScope scope, ILogger<IssueDemoRunner> logger)
        {
            _scope = scope;
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var current = Directory.GetCurrentDirectory();
            var dataDirectory = Path.Combine(current, "Data");
            var files = Directory.GetFiles(dataDirectory);
            foreach (var file in files)
            {
                Task.Run(async () => await ProcessFile(file));
            }

            return Task.CompletedTask;
        }

        private async Task ProcessFile(string file)
        {
            var f = await File.ReadAllTextAsync(file);
            var status = JsonConvert.DeserializeObject<Payload>(f);

            _logger.LogDebug($"Writing seed data for {status.Seed.MatchPacket.MatchFullId}");
            await Persist(status.Seed);

            while (true)
            {
                _logger.LogDebug($"Updating data for {status.Seed.MatchPacket.MatchFullId}");
                await Persist(status.Data);
            }
        }

        private async Task Persist(MatchStatus data)
        {
            using (var childScope = _scope.BeginLifetimeScope())
            {
                var store = childScope.Resolve<IDataStore>();
                try
                {
                    await store.PersistAsync(data);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);
                }
            }
        }
    }
}