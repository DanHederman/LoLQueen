using System.Collections;
using System.Collections.Generic;

namespace LoLQueen
{
    public class MatchInfo
    {

        /// <summary>
        /// PLayer stats 
        /// </summary>

        public class Player
        {
            public string CurrentPlatformId;
            public string SummonerName;
            public string MatchHistoryUri;
            public string PlatformId;
            public int CurrentAccountId;
            public int ProfileIcon;
            public int SummonerId;
            public int AccountId;
        }

        public class ParticipantIdentities
        {
            public Player player;
            public int ParticipantId;
        }

        /// <summary>
        /// Used to get the stats on the team
        /// </summary>

        public class Teams
        {
            public bool FirstDragon;
            public IList Bans;
            public bool FirstInhibitor;
            public string Win;
            public bool FirstRiftHerald;
            public bool FirstBaron;
            public int BaronKills;
            public int RiftHeraldKills;
            public bool FirstBlood;
            public int TeamId;
            public bool FirstTower;
            public int VilemawKills;
            public int InhibitorKills;
            public int TowerKills;
            public int DominionVictoryScore;
            public int DragonKills;
        }
        /// <summary>
        /// Large class used to get statistics on a wide variety of player
        /// actions and contributions to the match
        /// </summary>


        public class Stats
        {
            public bool FirstBloodAssist;
            public int VisionScore;
            public int MagicDamageDealtToChampions;
            public int LargestMultiKill;
            public int TotalTimeCrowdControlDealt;
            public int LongestTimeSpentLiving;
            public int Perk1Var1;
            public int Perk1Var3;
            public int Perk1Var2;
            public int TripleKills;
            public int Perk5;
            public int Perk4;
            public int PlayerScore9;
            public int PlayerScore8;
            public int Kills;
            public int PlayerScore1;
            public int PlayerScore0;
            public int PlayerScore3;
            public int PlayerScore2;
            public int PlayerScore5;
            public int PlayerScore4;
            public int PlayerScore7;
            public int PlayerScore6;
            public int Perk5Var1;
            public int Perk5Var3;
            public int Perk5Var2;
            public int TotalScoreRank;
            public int NeutralMinionsKilled;
            public int DamageDealtToTurrets;
            public int PhysicalDamageDealtToChampions;
            public int DamageDealtToObjectives;
            public int Perk2Var2;
            public int Perk2Var3;
            public int TotalUnitsHealed;
            public int Perk2Var1;
            public int Perk4Var1;
            public int TotalDamageTaken;
            public int Perk4Var3;
            public int LargestCriticalStrike;
            public int LargestKillingSpree;
            public int QuadraKills;
            public int MagicDamageDealt;
            public int Item2;
            public int Item3;
            public int Item0;
            public int Item1;
            public int Item6;
            public int Item4;
            public int Item5;
            public int Perk1;
            public int Perk0;
            public int Perk3;
            public int Perk2;
            public int Perk3Var3;
            public int Perk3Var2;
            public int Perk3Var1;
            public int DamageSelfMitigated;
            public int MagicalDamageTaken;
            public int Perk0Var2;
            public bool FirstInhibitorKill;
            public int TrueDamageTaken;
            public int Assists;
            public int Perk4Var2;
            public int GoldSpent;
            public int TrueDamageDealt;
            public int ParticipantId;
            public int PhysicalDamageDealt;
            public int SightWardsBoughtInGame;
            public int TotalDamageDealtToChampions;
            public int PhysicalDamageTaken;
            public int TotalPlayerScore;
            public bool Win;
            public int ObjectivePlayerScore;
            public int TotalDamageDealt;
            public int Deaths;
            public int PerkPrimaryStyle;
            public int PerkSubStyle;
            public int TurretKills;
            public bool FirstBloodKill;
            public int TrueDamageDealtToChampions;
            public int GoldEarned;
            public int KillingSprees;
            public int UnrealKills;
            public bool FirstTowerAssist;
            public bool FirstTowerKill;
            public int ChampLevel;
            public int DoubleKills;
            public int InhibitorKills;
            public bool FirstInhibitorAssist;
            public int Perk0Var1;
            public int CombatPlayerScore;
            public int Perk0Var3;
            public int VisionWardsBoughtInGame;
            public int PentaKills;
            public int TotalHeal;
            public int TotalMinionsKilled;
            public int TimeCCingOthers;
        }

        /// <summary>
        /// Structure to hold info based 
        /// on participation for a season
        /// </summary>
        public class Participants
        {
            public Stats Stats;
            public int Spell1Id;
            public int ParticipantId;
            public string HighestAchievedSeasonTier;
            public int Spell2Id;
            public int TeamId;
            public int ChampionId;
        }

        /// <summary>
        /// Structure to hold information based 
        /// on a single in game match
        /// </summary>
        public class singleMatch
        {
            public int SeasonId;
            public int QueueId;
            public long GameId;
            public List<ParticipantIdentities> ParticipantIdentities;
            public string GameVersion;
            public string PlatformId;
            public string GameMode;
            public int MapId;
            public string GameType;
            public List<Teams> Teams;
            public List<Participants> Participants;
            public int GameDuration;
            public long GameCreation;
        }


        public static List<singleMatch> GetMatchDetails(string region,MatchHist matchHist)
        {
            List<singleMatch> allMatchDetails = new List<singleMatch>();

            for (int i = 0; i < 20; ++i)
            {
                string matchUrl = RiotUrl.GetMatchUrl(matchHist.Matches[i].GameId.ToString(), "euw1");

                allMatchDetails.Add(JsonSettings.GetStats<singleMatch>(matchUrl));
            }
            return allMatchDetails;
        }

    }
}