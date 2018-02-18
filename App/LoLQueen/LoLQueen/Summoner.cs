    namespace LoLQueen
{
    public class Summoner
    {
        private int ProfileIconId { get; set; }
        public string Name { get; set; }
        public int SummonerLevel { get; set; }
        public long RevisionDate { get; set; }
        public long Id { get; set; }
        public long AccountId { get; set; }


        public static Summoner GetSummonerInfo(string region, string summonerName)
        {
            string summonerUrl = RiotUrl.GetSummonerUrl("euw1", summonerName);
            Summoner currentSummoner = JsonSettings.GetStats<Summoner>(summonerUrl);
            return currentSummoner;
        }

    }

}