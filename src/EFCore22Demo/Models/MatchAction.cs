using System;

namespace DemoProject.Models
{
    public class MatchAction
    {
        public MatchPacketData SourcePacket { get; set; }
        public int SetIndex { get; set; }
        public int GameIndex { get; set; }
        public int KeystrokeIndex { get; set; }
        public string PacketIdentifier { get; set; }
        public string KeystrokeName { get; set; }
        public int InvolvedPlayerId { get; set; }
        public DateTime TimePoint { get; set; }
        public string MatchState { get; set; }
        public int CourtId { get; set; }
        public int DayNumber { get; set; }
        public string Json { get; set; }
    }
}