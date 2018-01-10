using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLQueen
{
    public class ChampionMastery
    {
        public long totalMasteryScore;
    }

    public class ProgressionContents
    {
        public int playerId;
        public int championId;
        public int championLevel;
        public int championPoints;
        public long lastPlayTime;
        public int championPointsSinceLastLevel;
        public int championPointsUntilNextLevel;
        public bool chestGranted;
        public int tokensEarned;
    }
}