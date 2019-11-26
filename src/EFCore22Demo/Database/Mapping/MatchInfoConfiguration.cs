using DemoProject.Database.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoProject.Database.Mapping
{
    internal class MatchInfoConfiguration : IEntityTypeConfiguration<MatchInfo>
    {
        public void Configure(EntityTypeBuilder<MatchInfo> entity)
        {
            entity.ToTable("Match_Info");

            entity.HasKey(e => new { e.EventYear, e.EventId, e.MatchId });

            entity.Property(e => e.EventId)
                    .HasColumnName("EventID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

            entity.Property(e => e.MatchId)
                .HasColumnName("MatchID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.BinPacketBase64)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.CourtId).HasColumnName("CourtID");

            entity.Property(e => e.DrawLevelType)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DrawMatchType)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EntryTypeA)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.EntryTypeB)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.EventGender)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime");

            entity.Property(e => e.MatchState)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MatchTimeStamp).HasColumnType("datetime");

            entity.Property(e => e.MatchTimeTotal)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Message)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PacketKeystrokes)
                .HasMaxLength(3000)
                .IsUnicode(false);

            entity.Property(e => e.PlayerCountryA)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PlayerCountryA2)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PlayerCountryB)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PlayerCountryB2)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.DateSeq)
                .HasColumnType("smallint");

            entity.Property(e => e.NumSets)
                .HasColumnType("smallint");

            entity.Property(e => e.PlayerIDA)
                .HasColumnName("PlayerIDA")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.PlayerIDA2)
                .HasColumnName("PlayerIDA2")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.PlayerIDB)
                .HasColumnName("PlayerIDB")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.PlayerIDB2)
                .HasColumnName("PlayerIDB2")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.PlayerNameFirstA)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PlayerNameFirstA2)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PlayerNameFirstB)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PlayerNameFirstB2)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PlayerNameLastA)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PlayerNameLastA2)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PlayerNameLastB)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PlayerNameLastB2)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PointA)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.PointB)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ResultString)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RoundId)
                .HasColumnName("RoundID")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet1A)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet1B)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet2A)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet2B)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet3A)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet3B)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet4A)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet4B)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet5A)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSet5B)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreString)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ScoreSys)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ScoreTBSet1)
                .HasColumnName("ScoreTBSet1")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreTBSet2)
                .HasColumnName("ScoreTBSet2")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreTBSet3)
                .HasColumnName("ScoreTBSet3")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreTBSet4)
                .HasColumnName("ScoreTBSet4")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreTBSet5)
                .HasColumnName("ScoreTBSet5")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.SeedA)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.SeedB)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Serve)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Winner)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.XmlString)
                .HasColumnName("xmlstring")
                .HasColumnType("xml");
        }
    }
}