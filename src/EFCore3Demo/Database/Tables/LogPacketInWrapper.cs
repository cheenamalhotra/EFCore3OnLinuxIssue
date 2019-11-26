using System;

namespace DemoProject.Database.Tables
{
    public class LogPacketInWrapper
    {
        public short EventYear { get; set; }

        public string EventId { get; set; }

        public string MatchId { get; set; }

        public DateTime ReceivedAt { get; set; }

        public string CourtId { get; set; }

        public string MatchState { get; set; }

        public string ITFUmpireId { get; set; }

        public string PacketId { get; set; }

        public string PacketDataBase64 { get; set; }

        public string PacketState { get; set; }

        public string PacketType { get; set; }

        public int? PacketSequenceNumber { get; set; }

        public string ReceivedFrom { get; set; }

        public DateTime SDOutTimestamp { get; set; }

        public DateTime PSOutTimestamp { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}