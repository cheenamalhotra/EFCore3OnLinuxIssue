using System;

namespace DemoProject.Database.Tables
{
    public class MatchKeystroke
    {
        public int EventYear { get; set; }
        public string EventId { get; set; }
        public string MatchId { get; set; }
        public int SetIndex { get; set; }
        public int GameIndex { get; set; }
        public int KeystrokeIndex { get; set; }
        public string PacketIdentifier { get; set; }
        public string KeystrokeName { get; set; }
        public int InvolvedPlayerId { get; set; }
        public DateTime TimePoint { get; set; }
        public DateTime LastUpdated { get; set; }
        public string MatchState { get; set; }
        public byte? CourtId { get; set; }
        public byte? DayNumber { get; set; }
        public string Json { get; set; }
    }
}