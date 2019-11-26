using DemoProject.Database.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoProject.Database.Mapping
{
    internal class MatchSetDataConfiguration : IEntityTypeConfiguration<MatchSetData>
    {
        public void Configure(EntityTypeBuilder<MatchSetData> entity)
        {
            entity.ToTable("Match_SetData");

            entity.HasKey(e => new { e.EventYear, e.EventId, e.MatchId, e.SetNum });

            entity.Property(e => e.EventId)
                .HasColumnName("EventID")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.MatchId)
                .HasColumnName("MatchID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.AcesSSA).HasColumnName("AcesSSA");

            entity.Property(e => e.AcesSSB).HasColumnName("AcesSSB");

            entity.Property(e => e.ScoreA)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreB)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ScoreTB)
                .HasColumnName("ScoreTB")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.SetTime)
                .HasMaxLength(8)
                .IsUnicode(false);
        }
    }
}
