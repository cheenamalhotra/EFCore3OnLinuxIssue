using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoProject.Database.Interfaces;
using DemoProject.Database.Tables;
using DemoProject.Infrastructure;
using DemoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Database
{
    public class DataStore : IDataStore
    {
        private readonly PacketTablesContext _dbContext;

        public DataStore(PacketTablesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task PersistAsync(MatchStatus matchStatus)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            await strategy.ExecuteInTransactionAsync(async () => await PersistData(matchStatus), () => Task.FromResult(false));
        }

        private async Task PersistData(MatchStatus matchStatus)
        {
            await _dbContext.LogPacketInWrappers.Upsert(matchStatus.ToLog())
                .On(v => new { v.EventYear, v.EventId, v.MatchId, v.ReceivedAt })
                .NoUpdate()
                .RunAsync();

            await _dbContext.MatchInfos.Upsert(matchStatus.ToMatch())
                .On(v => new { v.EventYear, v.EventId, v.MatchId })
                .RunAsync();

            await _dbContext.MatchSetData.UpsertRange(matchStatus.ToSets())
                .On(v => new { v.EventYear, v.EventId, v.MatchId, v.SetNum })
                .RunAsync();

            await AddKeystrokes(matchStatus);

            await _dbContext.SaveChangesAsync();
        }

        private async Task AddKeystrokes(MatchStatus matchStatus)
        {
            var newActions = matchStatus.ToKeystrokes();

            foreach (var chunk in ChunkBy(newActions, 50))
            {
                await _dbContext.MatchKeystrokes.UpsertRange(chunk)
                    .On(keystroke => new { keystroke.EventYear, keystroke.EventId, keystroke.MatchId, keystroke.KeystrokeIndex })
                    .WhenMatched(keystroke => new MatchKeystroke
                    {
                        LastUpdated = keystroke.LastUpdated,
                        Json = keystroke.Json,
                        PacketIdentifier = keystroke.PacketIdentifier,
                        SetIndex = keystroke.SetIndex,
                        GameIndex = keystroke.GameIndex,
                        InvolvedPlayerId = keystroke.InvolvedPlayerId
                    })
                    .RunAsync();
            }
        }

        public static List<List<T>> ChunkBy<T>(IEnumerable<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}