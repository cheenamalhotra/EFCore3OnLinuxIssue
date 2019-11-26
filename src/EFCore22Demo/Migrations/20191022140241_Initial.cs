using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log_PacketIn_Wrapper",
                columns: table => new
                {
                    EventYear = table.Column<short>(type: "smallint", nullable: false),
                    EventId = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    MatchId = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DateTimeIn = table.Column<DateTime>(type: "datetime", nullable: false),
                    courtId = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    mState = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    ITFUmpireID = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PacketIdentifier = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PacketDataBase64 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    pState = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    pType = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    kSeq = table.Column<int>(type: "int", nullable: true),
                    fromIpPort = table.Column<string>(type: "varchar(22)", unicode: false, maxLength: 22, nullable: true),
                    tsSDOUTCStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    tsSSOUTCStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log_PacketIn_Wrapper", x => new { x.EventYear, x.EventId, x.MatchId, x.DateTimeIn });
                });

            migrationBuilder.CreateTable(
                name: "Match_Info",
                columns: table => new
                {
                    EventYear = table.Column<short>(nullable: false),
                    EventID = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    MatchID = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    EventGender = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    DrawMatchType = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    DrawLevelType = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    RoundID = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    DateSeq = table.Column<short>(type: "smallint", nullable: true),
                    CourtID = table.Column<short>(nullable: true),
                    MatchTimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    NumSets = table.Column<short>(type: "smallint", nullable: true),
                    ScoreSys = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    MatchState = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Winner = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    SeedA = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    SeedB = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    EntryTypeA = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    EntryTypeB = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    PlayerNameFirstA = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    PlayerNameLastA = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PlayerNameFirstA2 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    PlayerNameLastA2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PlayerNameFirstB = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    PlayerNameLastB = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PlayerNameFirstB2 = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    PlayerNameLastB2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PlayerIDA = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    PlayerIDA2 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    PlayerIDB = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    PlayerIDB2 = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    PlayerCountryA = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    PlayerCountryA2 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    PlayerCountryB = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    PlayerCountryB2 = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    Serve = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    MatchTimeTotal = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Message = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PointA = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    PointB = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet1A = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet1B = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet2A = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet2B = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet3A = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet3B = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet4A = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet4B = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet5A = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreSet5B = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreTBSet1 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreTBSet2 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreTBSet3 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreTBSet4 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreTBSet5 = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreString = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ResultString = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    ExcludeFlag = table.Column<bool>(nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: false),
                    xmlstring = table.Column<string>(type: "xml", nullable: true),
                    PacketKeystrokes = table.Column<string>(unicode: false, maxLength: 3000, nullable: true),
                    BinPacketBase64 = table.Column<string>(unicode: false, maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match_Info", x => new { x.EventYear, x.EventID, x.MatchID });
                });

            migrationBuilder.CreateTable(
                name: "Match_Keystrokes",
                columns: table => new
                {
                    EventYear = table.Column<int>(type: "int", nullable: false),
                    EventID = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    MatchID = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    KeystrokeIndex = table.Column<int>(type: "int", nullable: false),
                    SetIndex = table.Column<int>(type: "int", nullable: false),
                    GameIndex = table.Column<int>(type: "int", nullable: false),
                    PacketIdentifier = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    KeystrokeName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    InvolvedPlayerID = table.Column<int>(type: "int", nullable: false),
                    TimePoint = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    MatchState = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    CourtIdentifier = table.Column<byte>(type: "tinyint", nullable: true),
                    DayNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    Json = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match_Keystrokes", x => new { x.EventYear, x.EventID, x.MatchID, x.KeystrokeIndex });
                });

            migrationBuilder.CreateTable(
                name: "Match_SetData",
                columns: table => new
                {
                    EventYear = table.Column<short>(nullable: false),
                    EventID = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    MatchID = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SetNum = table.Column<short>(nullable: false),
                    SetTime = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    ScoreA = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreB = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ScoreTB = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    AcesA = table.Column<short>(nullable: true),
                    AcesB = table.Column<short>(nullable: true),
                    DblFltA = table.Column<short>(nullable: true),
                    DblFltB = table.Column<short>(nullable: true),
                    PtsWon1stServA = table.Column<short>(nullable: true),
                    PtsWon1stServB = table.Column<short>(nullable: true),
                    PtsPlayed1stServA = table.Column<short>(nullable: true),
                    PtsPlayed1stServB = table.Column<short>(nullable: true),
                    PtsTotWonServA = table.Column<short>(nullable: true),
                    PtsTotWonServB = table.Column<short>(nullable: true),
                    TotServPlayedA = table.Column<short>(nullable: true),
                    TotServPlayedB = table.Column<short>(nullable: true),
                    BreakPtsConvA = table.Column<short>(nullable: true),
                    BreakPtsConvB = table.Column<short>(nullable: true),
                    BreakPtsPlayedA = table.Column<short>(nullable: true),
                    BreakPtsPlayedB = table.Column<short>(nullable: true),
                    ServGamesPlayedA = table.Column<short>(nullable: true),
                    ServGamesPlayedB = table.Column<short>(nullable: true),
                    Pts1stServLostA = table.Column<short>(nullable: true),
                    Pts1stServLostB = table.Column<short>(nullable: true),
                    TotPtsWonA = table.Column<short>(nullable: true),
                    TotPtsWonB = table.Column<short>(nullable: true),
                    AcesSSA = table.Column<short>(nullable: true),
                    AcesSSB = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match_SetData", x => new { x.EventYear, x.EventID, x.MatchID, x.SetNum });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log_PacketIn_Wrapper");

            migrationBuilder.DropTable(
                name: "Match_Info");

            migrationBuilder.DropTable(
                name: "Match_Keystrokes");

            migrationBuilder.DropTable(
                name: "Match_SetData");
        }
    }
}
