using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLQueen
{
    public class MatchInfo
    {
        public class Player
        {
            public string currentPlatformId;
            public string summonerName;
            public string matchHistoryUri;
            public string platformId;
            public int currentAccountId;
            public int profileIcon;
            public int summonerId;
            public int accountId;
        }

        public class ParticipantIdentities
        {
            public Player player;
            public int participantId;
        }

        public class Teams
        {
            public bool firstDragon;
            public IList bans;
            public bool firstInhibitor;
            public string win;
            public bool firstRiftHerald;
            public bool firstBaron;
            public int baronKills;
            public int riftHeraldKills;
            public bool firstBlood;
            public int teamId;
            public bool firstTower;
            public int vilemawKills;
            public int inhibitorKills;
            public int towerKills;
            public int dominionVictoryScore;
            public int dragonKills;
        }

        public class Stats
        {
            public bool firstBloodAssist;
            public int visionScore;
            public int magicDamageDealtToChampions;
            public int largestMultiKill;
            public int totalTimeCrowdControlDealt;
            public int longestTimeSpentLiving;
            public int perk1Var1;
            public int perk1Var3;
            public int perk1Var2;
            public int tripleKills;
            public int perk5;
            public int perk4;
            public int playerScore9;
            public int playerScore8;
            public int kills;
            public int playerScore1;
            public int playerScore0;
            public int playerScore3;
            public int playerScore2;
            public int playerScore5;
            public int playerScore4;
            public int playerScore7;
            public int playerScore6;
            public int perk5Var1;
            public int perk5Var3;
            public int perk5Var2;
            public int totalScoreRank;
            public int neutralMinionsKilled;
            public int damageDealtToTurrets;
            public int physicalDamageDealtToChampions;
            public int damageDealtToObjectives;
            public int perk2Var2;
            public int perk2Var3;
            public int totalUnitsHealed;
            public int perk2Var1;
            public int perk4Var1;
            public int totalDamageTaken;
            public int perk4Var3;
            public int largestCriticalStrike;
            public int largestKillingSpree;
            public int quadraKills;
            public int magicDamageDealt;
            public int item2;
            public int item3;
            public int item0;
            public int item1;
            public int item6;
            public int item4;
            public int item5;
            public int perk1;
            public int perk0;
            public int perk3;
            public int perk2;
            public int perk3Var3;
            public int perk3Var2;
            public int perk3Var1;
            public int damageSelfMitigated;
            public int magicalDamageTaken;
            public int perk0Var2;
            public bool firstInhibitorKill;
            public int trueDamageTaken;
            public int assists;
            public int perk4Var2;
            public int goldSpent;
            public int trueDamageDealt;
            public int participantId;
            public int physicalDamageDealt;
            public int sightWardsBoughtInGame;
            public int totalDamageDealtToChampions;
            public int physicalDamageTaken;
            public int totalPlayerScore;
            public bool win;
            public int objectivePlayerScore;
            public int totalDamageDealt;
            public int deaths;
            public int perkPrimaryStyle;
            public int perkSubStyle;
            public int turretKills;
            public bool firstBloodKill;
            public int trueDamageDealtToChampions;
            public int goldEarned;
            public int killingSprees;
            public int unrealKills;
            public bool firstTowerAssist;
            public bool firstTowerKill;
            public int champLevel;
            public int doubleKills;
            public int inhibitorKills;
            public bool firstInhibitorAssist;
            public int perk0Var1;
            public int combatPlayerScore;
            public int perk0Var3;
            public int visionWardsBoughtInGame;
            public int pentaKills;
            public int totalHeal;
            public int totalMinionsKilled;
            public int timeCCingOthers;
        }


        public class Participants
        {
            public Stats stats;
            public int spell1Id;
            public int participantId;
            public string highestAchievedSeasonTier;
            public int spell2Id;
            public int teamId;
            public int championId;
        }

        public class MyJsonObject
        {
            public int seasonId;
            public int queueId;
            public long gameId;
            public IList participantIdentities;
            public string gameVersion;
            public string platformId;
            public string gameMode;
            public int mapId;
            public string gameType;
            public IList teams;
            public IList participants;
            public int gameDuration;
            public long gameCreation;
        }

    }
}