using System;

namespace DemoProject.Models
{
    public class MatchPacketData
    {
        public string MatchFullId => $"{EventYear}-{EventId}-{MatchId}";
        public int EventYear { get; set; }
        public string EventId { get; set; }
        public string MatchId { get; set; }
        public int CourtId { get; set; }
        public string MatchState { get; set; }
        public string ITFUmpireId { get; set; }
        public string PacketId { get; set; }
        public string Packet { get; set; }
        public string PacketState { get; set; }
        public string PacketType { get; set; }
        public int PacketSequenceNumber { get; set; }
        public string PacketReceivedFrom { get; set; }
        public DateTime PacketReceivedAt { get; set; }
        public DateTime ScorerOutTimestamp { get; set; }
        public DateTime SmartDirectorOutTimestamp { get; set; }
    }
}