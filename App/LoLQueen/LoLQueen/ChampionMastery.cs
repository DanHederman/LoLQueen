namespace LoLQueen
{
    public class ChampionMastery
    {
        public long TotalMasteryScore;
    }

    public class ProgressionContents
    {
        public int PlayerId;
        public int ChampionId;
        public int ChampionLevel;
        public int ChampionPoints;
        public long LastPlayTime;
        public int ChampionPointsSinceLastLevel;
        public int ChampionPointsUntilNextLevel;
        public bool ChestGranted;
        public int TokensEarned;
    }
}