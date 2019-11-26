using System;
using System.Collections.Generic;
using System.Linq;
using DemoProject.Database.Tables;
using DemoProject.Models;

namespace DemoProject.Infrastructure
{
    internal static class Mappers
    {
        public static LogPacketInWrapper ToLog(this MatchStatus status)
        {
            return new LogPacketInWrapper
            {
                MatchId = status.MatchId,
                EventYear = (short)status.EventYear,
                EventId = status.EventId,
                CourtId = status.CourtId.ToString(),
                MatchState = status.MatchState,
                ITFUmpireId = status.MatchPacket.ITFUmpireId,
                PacketId = status.MatchPacket.PacketId,
                PacketDataBase64 = status.MatchPacket.Packet,
                PacketState = status.MatchPacket.PacketState,
                PacketType = status.MatchPacket.PacketType,
                PacketSequenceNumber = status.MatchPacket.PacketSequenceNumber,
                ReceivedFrom = status.MatchPacket.PacketReceivedFrom,
                ReceivedAt = status.MatchPacket.PacketReceivedAt,
                PSOutTimestamp = status.MatchPacket.ScorerOutTimestamp,
                SDOutTimestamp = status.MatchPacket.SmartDirectorOutTimestamp,
                CreatedAt = DateTime.UtcNow,
            };
        }

        public static IList<MatchKeystroke> ToKeystrokes(this MatchStatus status)
        {
            return status.NewActions.Select(x => new MatchKeystroke
            {
                EventYear = status.EventYear,
                EventId = status.EventId,
                MatchId = status.MatchId,
                KeystrokeIndex = x.KeystrokeIndex,
                SetIndex = x.SetIndex,
                GameIndex = x.GameIndex,
                PacketIdentifier = x.PacketIdentifier,
                KeystrokeName = x.KeystrokeName,
                TimePoint = x.TimePoint,
                InvolvedPlayerId = x.InvolvedPlayerId,
                DayNumber = (byte?)x.DayNumber,
                MatchState = x.MatchState,
                CourtId = (byte?)x.CourtId,
                Json = x.Json,
                LastUpdated = DateTime.UtcNow
            }).ToList();
        }

        public static IList<MatchSetData> ToSets(this MatchStatus status)
        {
            return status.SetStatuses.Select(x => new MatchSetData
            {
                EventYear = (short)status.EventYear,
                EventId = status.EventId,
                MatchId = status.MatchId,
                SetNum = (short)x.SetNum,
                SetTime = x.SetNum == 0 || x.SetTime == null ? "" : x.SetTime.Value.ToString().Substring(0, 8),
                ScoreA = x.ScoreA == null ? "" : x.ScoreA.ToString(),
                ScoreB = x.ScoreA == null ? "" : x.ScoreB.ToString(),
                ScoreTB = x.ScoreA == null ? "" : x.ScoreTb.ToString(),
                AcesSSA = 0,
                AcesSSB = 0,
                AcesA = (short?)x.AcesA,
                AcesB = (short?)x.AcesB,
                BreakPtsConvA = (short?)x.BreakPtsConvA,
                BreakPtsConvB = (short?)x.BreakPtsConvB,
                BreakPtsPlayedA = (short?)x.BreakPtsPlayedA,
                BreakPtsPlayedB = (short?)x.BreakPtsPlayedB,
                DblFltA = (short?)x.DblFltA,
                DblFltB = (short?)x.DblFltB,
                PtsPlayed1stServA = (short?)x.PtsPlayed1StServA,
                PtsPlayed1stServB = (short?)x.PtsPlayed1StServB,
                Pts1stServLostA = (short?)x.Pts1StServLostA,
                Pts1stServLostB = (short?)x.Pts1StServLostB,
                PtsTotWonServA = (short?)x.PtsTotWonServA,
                PtsTotWonServB = (short?)x.PtsTotWonServB,
                TotServPlayedA = (short?)x.TotServPlayedA,
                TotServPlayedB = (short?)x.TotServPlayedB,
                ServGamesPlayedA = (short?)x.ServGamesPlayedA,
                ServGamesPlayedB = (short?)x.ServGamesPlayedB,
                TotPtsWonA = (short?)x.TotPtsWonA,
                TotPtsWonB = (short?)x.TotPtsWonB,
                PtsWon1stServA = (short?)x.PtsWon1StServA,
                PtsWon1stServB = (short?)x.PtsWon1StServB
            }).ToList();
        }

        public static MatchInfo ToMatch(this MatchStatus status)
        {
            return new MatchInfo
            {
                EventYear = (short)status.EventYear,
                EventId = status.EventId,
                MatchId = status.MatchId,
                EventGender = status.EventGender,
                DrawMatchType = status.DrawMatchType,
                DrawLevelType = status.DrawLevelType,
                RoundId = status.RoundId,
                DateSeq = status.DateSeq,
                CourtId = (short?)(status.CourtId - 1),
                MatchTimeStamp = status.MatchStartTime == DateTime.MinValue ? (DateTime?)null : status.MatchStartTime,
                NumSets = status.NumSets,
                ScoreSys = status.ScoreSys,
                MatchState = status.MatchState,
                Winner = status.Winner == null ? string.Empty : status.Winner.ToString(),
                SeedA = status.SeedA == null ? string.Empty : status.SeedA.ToString(),
                SeedB = status.SeedB == null ? string.Empty : status.SeedB.ToString(),
                EntryTypeA = status.EntryTypeA,
                EntryTypeB = status.EntryTypeB,
                PlayerNameFirstA = status.PlayerNameFirstA,
                PlayerNameLastA = status.PlayerNameLastA,
                PlayerNameFirstA2 = status.PlayerNameFirstA2,
                PlayerNameLastA2 = status.PlayerNameLastA2,
                PlayerNameFirstB = status.PlayerNameFirstB,
                PlayerNameLastB = status.PlayerNameLastB,
                PlayerNameFirstB2 = status.PlayerNameFirstB2,
                PlayerNameLastB2 = status.PlayerNameLastB2,
                PlayerIDA = status.PlayerIdA,
                PlayerIDA2 = status.PlayerIdA2,
                PlayerIDB = status.PlayerIdB,
                PlayerIDB2 = status.PlayerIdB2,
                PlayerCountryA = status.PlayerCountryA,
                PlayerCountryA2 = status.PlayerCountryA2,
                PlayerCountryB = status.PlayerCountryB,
                PlayerCountryB2 = status.PlayerCountryB2,
                Serve = status.Serve,
                MatchTimeTotal = status.MatchDuration.ToString(@"hh\:mm\:ss"),
                Message = status.Message,
                PointA = status.PointA,
                PointB = status.PointB,
                ScoreSet1A = status.ScoreSet1A == null ? string.Empty : status.ScoreSet1A.ToString(),
                ScoreSet1B = status.ScoreSet1B == null ? string.Empty : status.ScoreSet1B.ToString(),
                ScoreSet2A = status.ScoreSet2A == null ? string.Empty : status.ScoreSet2A.ToString(),
                ScoreSet2B = status.ScoreSet2B == null ? string.Empty : status.ScoreSet2B.ToString(),
                ScoreSet3A = status.ScoreSet3A == null ? string.Empty : status.ScoreSet3A.ToString(),
                ScoreSet3B = status.ScoreSet3B == null ? string.Empty : status.ScoreSet3B.ToString(),
                ScoreSet4A = status.ScoreSet4A == null ? string.Empty : status.ScoreSet4A.ToString(),
                ScoreSet4B = status.ScoreSet4B == null ? string.Empty : status.ScoreSet4B.ToString(),
                ScoreSet5A = status.ScoreSet5A == null ? string.Empty : status.ScoreSet5A.ToString(),
                ScoreSet5B = status.ScoreSet5B == null ? string.Empty : status.ScoreSet5B.ToString(),
                ScoreTBSet1 = status.ScoreTBSet1 == null ? string.Empty : status.ScoreTBSet1.ToString(),
                ScoreTBSet2 = status.ScoreTBSet2 == null ? string.Empty : status.ScoreTBSet2.ToString(),
                ScoreTBSet3 = status.ScoreTBSet3 == null ? string.Empty : status.ScoreTBSet3.ToString(),
                ScoreTBSet4 = status.ScoreTBSet4 == null ? string.Empty : status.ScoreTBSet4.ToString(),
                ScoreTBSet5 = status.ScoreTBSet5 == null ? string.Empty : status.ScoreTBSet5.ToString(),
                ScoreString = status.ScoreString,
                BinPacketBase64 = status.StateAsBinaryBase64,
                PacketKeystrokes = status.PacketKeystrokes,
                ResultString = status.ResultString,
                LastUpdated = DateTime.UtcNow
            };
        }
    }
}