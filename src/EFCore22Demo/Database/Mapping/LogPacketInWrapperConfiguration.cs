using DemoProject.Database.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoProject.Database.Mapping
{
    internal class LogPacketInWrapperConfiguration : IEntityTypeConfiguration<LogPacketInWrapper>
    {
        public void Configure(EntityTypeBuilder<LogPacketInWrapper> builder)
        {
            builder.ToTable("Log_PacketIn_Wrapper");
            builder.HasKey(x => new { x.EventYear, x.EventId, x.MatchId, DateTimeIn = x.ReceivedAt });
            builder.HasAlternateKey(x => new { x.EventYear, x.EventId, x.MatchId, DateTimeIn = x.ReceivedAt });

            builder.Property(x => x.EventYear).HasColumnName("EventYear").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.EventId).HasColumnName("EventId").HasColumnType("varchar(6)").IsRequired().IsUnicode(false).HasMaxLength(6);
            builder.Property(x => x.MatchId).HasColumnName("MatchId").HasColumnType("varchar(5)").IsRequired().IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.ReceivedAt).HasColumnName("DateTimeIn").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ReceivedFrom).HasColumnName("fromIpPort").HasColumnType("varchar(22)").IsUnicode(false).HasMaxLength(22);
            builder.Property(x => x.CreatedAt).HasColumnName("CreatedAt").HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETUTCDATE()");
            builder.Property(x => x.CourtId).HasColumnName("courtId").HasColumnType("varchar(2)").IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.PacketState).HasColumnName("pState").HasColumnType("varchar(1)").IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PacketSequenceNumber).HasColumnName("kSeq").HasColumnType("int");
            builder.Property(x => x.MatchState).HasColumnName("mState").HasColumnType("varchar(1)").IsUnicode(false).HasMaxLength(1).IsRequired(false);
            builder.Property(x => x.PacketType).HasColumnName("pType").HasColumnType("varchar(1)").IsUnicode(false).HasMaxLength(1).IsRequired(false);
            builder.Property(x => x.ITFUmpireId).HasColumnName("ITFUmpireID").HasColumnType("varchar(255)").IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.PacketId).HasColumnName("PacketIdentifier").HasColumnType("varchar(255)").IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.PSOutTimestamp).HasColumnName("tsSSOUTCStamp").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.SDOutTimestamp).HasColumnName("tsSDOUTCStamp").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.PacketDataBase64).HasColumnName("PacketDataBase64").HasColumnType("varchar(max)").IsUnicode(false);
        }
    }
}