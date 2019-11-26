using DemoProject.Database.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Database.Tables
{
    public class PacketTablesContext : DbContext
    {
        public PacketTablesContext(DbContextOptions<PacketTablesContext> options) : base(options)
        {
        }

        public virtual DbSet<LogPacketInWrapper> LogPacketInWrappers { get; set; }
        public virtual DbSet<MatchInfo> MatchInfos { get; set; }
        public virtual DbSet<MatchSetData> MatchSetData { get; set; }
        public virtual DbSet<MatchKeystroke> MatchKeystrokes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LogPacketInWrapperConfiguration());
            modelBuilder.ApplyConfiguration(new MatchInfoConfiguration());
            modelBuilder.ApplyConfiguration(new MatchSetDataConfiguration());
            modelBuilder.ApplyConfiguration(new MatchKeystrokeConfiguration());
        }
    }
}