namespace LoLQueen
{
    /*
     * This class is used to connect to the API. It used the
     * information provided by the user(summoner name) to concatonate
     * the url and pull the correct information for the user in
     * question
     *
     *API key is essential to this
     */
    public class RiotUrl
    {
        
        static string apiKey = "RGAPI-f7ee5817-92bc-4100-90d5-9a64994f6a8b";
        /// <summary>
        /// Summoner information
        /// </summary>
        /// <param name="username"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        public static string GetSummonerUrl(string region, string username)
        {
            string url =
                $"https://{region}.api.riotgames.com/lol/summoner/v3/summoners/by-name/{username}?api_key={apiKey}";

            return url;
        }
        /// <summary>
        /// Match History information
        /// </summary>
        /// <param name="region"></param>
        /// <param name="accid"></param>
        /// <returns></returns>
        public static string GetMatchHistUrl(string region, string accid)
        {

            string url =
                $"https://{region}.api.riotgames.com/lol/match/v3/matchlists/by-account/{accid}/recent?api_key={apiKey}";

            return url;
        }
        /// <summary>
        /// Match information
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        public static string GetMatchUrl(string gameId, string region)
        {
            string url = $"https://{region}.api.riotgames.com/lol/match/v3/matches/{gameId}?api_key={apiKey}";

            return url;
        }
        /// <summary>
        /// Mastery information 
        /// </summary>
        /// <param name="summonerId"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        public static string GetTotalMasteryScoreUrl(string summonerId, string region)
        {
            string url = $"https://{region}.api.riotgames.com/lol/champion-mastery/v3/scores/by-summoner/{summonerId}?api_key={apiKey}";
            return url;
        }
        /// <summary>
        /// Mastery progress information
        /// </summary>
        /// <param name="summonerId"></param>
        /// <param name="region"></param>
        /// <returns></returns>
        public static string GetMasteryProgressUrl(string summonerId, string region)
        {
            string url =
                $"https://{region}.api.riotgames.com/lol/champion-mastery/v3/champion-masteries/by-summoner/{summonerId}?api_key={apiKey}";
            return url;
        }

    }
}