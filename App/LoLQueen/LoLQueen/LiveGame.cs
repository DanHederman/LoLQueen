using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLQueen
{
    public class LiveGame
    {
        public class LiveGameData
        {
            public long gameId;
            public long gameStartTime;
            public string platformId;
            public string gameMode;
            public long mapId;
            public string gameType;
            public List<BannedChampion> bannedChampions;
            public Observer observers;
            public List<Participant> participants;
            public long gameLength;
            public long gameQueueConfigId;
        }

        public class BannedChampion
        {
            public int pickTurn;
            public long championId;
            public long teamId;
        }

        public class Observer
        {
            public string encryptionKey;
        }

        public class Participant
        {
            public long profileIconId;
            public long championId;
            public string summonerName;
            public List<GameCustomizationObject> gameCustomizationObjects;
            public bool bot;
            public Perks perks;
            public long spell2Id;
            public long teamId;
            public long spell1Id;
            public long summonerId;
        }

        public class GameCustomizationObject
        {
            public string category;
            public string content;
        }

        public class Perks
        {
            public long perkStyle;
            public List<long> perkIds;
            public long perkSubStyle;
        }
    }




}