using DemoProject.Database.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoProject.Database.Mapping
{
    internal class MatchKeystrokeConfiguration : IEntityTypeConfiguration<MatchKeystroke>
    {
        public void Configure(EntityTypeBuilder<MatchKeystroke> entity)
        {
            entity.HasKey(e => new {e.EventYear, e.EventId, e.MatchId, e.KeystrokeIndex});

            entity.ToTable("Match_Keystrokes");

            entity.Property(e => e.EventYear)
                .HasColumnName("EventYear")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.EventId)
                .HasColumnName("EventID")
                .HasColumnType("varchar(6)")
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsRequired();

            entity.Property(e => e.MatchId)
                .HasColumnName("MatchID")
                .HasColumnType("varchar(6)")
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsRequired();

            entity.Property(e => e.KeystrokeIndex)
                .HasColumnName("KeystrokeIndex")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.GameIndex)
                .HasColumnName("GameIndex")
                .HasColumnType("int");

            entity.Property(e => e.SetIndex)
                .HasColumnName("SetIndex")
                .HasColumnType("int");

            entity.Property(e => e.PacketIdentifier)
                .HasColumnName("PacketIdentifier")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.KeystrokeName)
                .HasColumnName("KeystrokeName")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvolvedPlayerId)
                .HasColumnName("InvolvedPlayerID")
                .HasColumnType("int");

            entity.Property(e => e.CourtId)
                .HasColumnName("CourtIdentifier")
                .HasColumnType("tinyint");

            entity.Property(e => e.Json)
                .HasColumnType("varchar(max)");
            
            entity.Property(e => e.MatchState)
                .HasColumnName("MatchState")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2)
                .IsUnicode(false);
            
            entity.Property(e => e.TimePoint)
                .HasColumnName("TimePoint")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.DayNumber)
                .HasColumnName("DayNumber")
                .HasColumnType("tinyint");

            entity.Property(e => e.LastUpdated)
                .HasColumnName("LastUpdated")
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}