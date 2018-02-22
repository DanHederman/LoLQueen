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
        
        static string apiKey = "RGAPI-7a3f1744-3977-470d-883c-e222ccd8a622";
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
        public static string GetMatchUrl(string region, string gameId)
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
        public static string GetTotalMasteryScoreUrl(string region, string summonerId)
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
        public static string GetMasteryProgressUrl(string region, string summonerId)
        {
            string url =
                $"https://{region}.api.riotgames.com/lol/champion-mastery/v3/champion-masteries/by-summoner/{summonerId}?api_key={apiKey}";
            return url;
        }

        public static string GetLiveGameUrl(string region,  string summonerId)
        {
            string url = 
                $"https://{region}.api.riotgames.com/lol/spectator/v3/active-games/by-summoner/{summonerId}?api_key={apiKey}";
            return url;
        }

    }
}