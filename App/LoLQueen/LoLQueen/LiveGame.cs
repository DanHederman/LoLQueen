using System.Collections.Generic;

namespace LoLQueen
{
    public class LiveGame
    {
        public class LiveGameData
        {
            public long GameId;
            public long GameStartTime;
            public string PlatformId;
            public string GameMode;
            public long MapId;
            public string GameType;
            public List<BannedChampion> BannedChampions;
            public Observer Observers;
            public List<Participant> Participants;
            public long GameLength;
            public long GameQueueConfigId;
        }

        public class BannedChampion
        {
            public int PickTurn;
            public long ChampionId;
            public long TeamId;
        }

        public class Observer
        {
            public string EncryptionKey;
        }

        public class Participant
        {
            public long ProfileIconId;
            public long ChampionId;
            public string SummonerName;
            public List<GameCustomizationObject> GameCustomizationObjects;
            public bool Bot;
            public Perks Perks;
            public long Spell2Id;
            public long TeamId;
            public long Spell1Id;
            public long SummonerId;
        }

        public class GameCustomizationObject
        {
            public string Category;
            public string Content;
        }

        public class Perks
        {
            public long PerkStyle;
            public List<long> PerkIds;
            public long PerkSubStyle;
        }

        public static LiveGameData GetLiveGame(string region, string summonerId)
        {
            var liveGameUrl = RiotUrl.GetLiveGameUrl("euw1", summonerId);
            var liveGame = JsonSettings.GetStats<LiveGameData>(liveGameUrl);
            return liveGame;
        }
    }


    



}