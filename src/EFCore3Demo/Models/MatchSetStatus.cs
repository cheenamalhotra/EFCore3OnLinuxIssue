using System;

namespace DemoProject.Models
{
    public class MatchSetStatus
    {
        public int SetNum { get; set; }
        public bool? IsMatchTieBreak { get; set; }
        public bool? HasTieBreak { get; set; }
        public double? ScoreA { get; set; }
        public double? ScoreB { get; set; }
        public double? ScoreTb { get; set; }
        public TimeSpan? SetTime { get; set; }
        public double AcesA { get; set; }
        public double AcesB { get; set; }
        public double DblFltA { get; set; }
        public double DblFltB { get; set; }
        public double PtsWon1StServA { get; set; }
        public double PtsWon1StServB { get; set; }
        public double PtsPlayed1StServA { get; set; }
        public double PtsPlayed1StServB { get; set; }
        public double PtsTotWonServA { get; set; }
        public double PtsTotWonServB { get; set; }
        public double TotServPlayedA { get; set; }
        public double TotServPlayedB { get; set; }
        public double BreakPtsConvA { get; set; }
        public double BreakPtsConvB { get; set; }
        public double BreakPtsPlayedA { get; set; }
        public double BreakPtsPlayedB { get; set; }
        public double ServGamesPlayedA { get; set; }
        public double ServGamesPlayedB { get; set; }
        public double Pts1StServLostA { get; set; }
        public double Pts1StServLostB { get; set; }
        public double TotPtsWonA { get; set; }
        public double TotPtsWonB { get; set; }
        public double AcesSSA { get; set; } = 0;
        public double AcesSSB { get; set; } = 0;
    }
}