using System;
using System.Collections.Generic;

namespace DemoProject.Models
{
    public class MatchStatus
    {
        public MatchStatus()
        {
            NewActions = new List<MatchAction>();
            SetStatuses = new List<MatchSetStatus>();
        }

        public int EventYear { get; set; }
        public string EventId { get; set; }
        public string MatchId { get; set; }
        public bool IsLive { get; set; }
        public string EventGender { get; set; }
        public string DrawMatchType { get; set; }
        public string DrawLevelType { get; set; }
        public string RoundId { get; set; }
        public short? DateSeq { get; set; }
        public short? CourtId { get; set; }
        public DateTime MatchStartTime { get; set; }
        public MatchPacketData MatchPacket { get; set; }
        public short? NumSets { get; set; }
        public string ScoreSys { get; set; }
        public string MatchState { get; set; }
        public int? Winner { get; set; }
        public int? SeedA { get; set; }
        public int? SeedB { get; set; }
        public string EntryTypeA { get; set; }
        public string EntryTypeB { get; set; }
        public string PlayerNameFirstA { get; set; }
        public string PlayerNameLastA { get; set; }
        public string PlayerNameFirstA2 { get; set; } = "";
        public string PlayerNameLastA2 { get; set; } = "";
        public string PlayerNameFirstB { get; set; }
        public string PlayerNameLastB { get; set; }
        public string PlayerNameFirstB2 { get; set; } = "";
        public string PlayerNameLastB2 { get; set; } = "";
        public string PlayerIdA { get; set; }
        public string PlayerIdA2 { get; set; } = "";
        public string PlayerIdB { get; set; }
        public string PlayerIdB2 { get; set; } = "";
        public string PlayerCountryA { get; set; }
        public string PlayerCountryA2 { get; set; } = "";
        public string PlayerCountryB { get; set; }
        public string PlayerCountryB2 { get; set; } = "";
        public string Serve { get; set; } = "";
        public TimeSpan MatchDuration { get; set; }
        public string Message { get; set; }
        public string PointA { get; set; } = "";
        public string PointB { get; set; } = "";
        public int? ScoreSet1A { get; set; }
        public int? ScoreSet1B { get; set; }
        public int? ScoreSet2A { get; set; }
        public int? ScoreSet2B { get; set; }
        public int? ScoreSet3A { get; set; }
        public int? ScoreSet3B { get; set; }
        public int? ScoreSet4A { get; set; }
        public int? ScoreSet4B { get; set; }
        public int? ScoreSet5A { get; set; }
        public int? ScoreSet5B { get; set; }
        public int? ScoreTBSet1 { get; set; }
        public int? ScoreTBSet2 { get; set; }
        public int? ScoreTBSet3 { get; set; }
        public int? ScoreTBSet4 { get; set; }
        public int? ScoreTBSet5 { get; set; }
        public string StateAsBinaryBase64 { get; set; }
        public string PacketKeystrokes { get; set; }
        public string ResultString { get; set; }
        public string ScoreString { get; set; }
        public IList<MatchAction> NewActions { get; }
        public IList<MatchSetStatus> SetStatuses { get; }
    }
}