using System;

namespace DemoProject.Database.Tables
{
    public class MatchInfo
    {
        public short EventYear { get; set; }
        public string EventId { get; set; }
        public string MatchId { get; set; }
        public string EventGender { get; set; }
        public string DrawMatchType { get; set; }
        public string DrawLevelType { get; set; }

        public string RoundId { get; set; }

        public short? DateSeq { get; set; }
        public short? CourtId { get; set; }

        public DateTime? MatchTimeStamp { get; set; }

        public short? NumSets { get; set; }

        public string ScoreSys { get; set; }

        public string MatchState { get; set; }

        public string Winner { get; set; }
        public string SeedA { get; set; }
        public string SeedB { get; set; }

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
        public string PlayerIDA { get; set; }
        public string PlayerIDA2 { get; set; } = "";
        public string PlayerIDB { get; set; }
        public string PlayerIDB2 { get; set; } = "";
        public string PlayerCountryA { get; set; } = "";
        public string PlayerCountryA2 { get; set; } = "";
        public string PlayerCountryB { get; set; } = "";
        public string PlayerCountryB2 { get; set; } = "";
        public string Serve { get; set; } = "";
        public string MatchTimeTotal { get; set; }

        public string Message { get; set; }

        public string PointA { get; set; } = "";

        public string PointB { get; set; } = "";
        public string ScoreSet1A { get; set; } = "";
        public string ScoreSet1B { get; set; } = "";
        public string ScoreSet2A { get; set; } = "";
        public string ScoreSet2B { get; set; } = "";
        public string ScoreSet3A { get; set; } = "";
        public string ScoreSet3B { get; set; } = "";
        public string ScoreSet4A { get; set; } = "";
        public string ScoreSet4B { get; set; } = "";
        public string ScoreSet5A { get; set; } = "";
        public string ScoreSet5B { get; set; } = "";
        public string ScoreTBSet1 { get; set; } = "";
        public string ScoreTBSet2 { get; set; } = "";
        public string ScoreTBSet3 { get; set; } = "";
        public string ScoreTBSet4 { get; set; } = "";
        public string ScoreTBSet5 { get; set; } = "";

        public string ScoreString { get; set; }

        public string ResultString { get; set; }

       
        public bool? ExcludeFlag { get; set; } = false;

        public DateTime LastUpdated { get; set; }

        public string XmlString { get; set; } = "";

        public string PacketKeystrokes { get; set; }

        public string BinPacketBase64 { get; set; }
    }
}