using System;

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
        static string apiKey = "RGAPI-e0d0a0ab-1309-4c4d-bfbf-de3f3d680242";

        public static string GetSummonerUrl(string username, string region)
        {
            string url =
                $"https://{region}.api.riotgames.com/lol/summoner/v3/summoners/by-name/{username}?api_key={apiKey}";

            return url;
        }

        public static string GetMatchHistUrl(string region, string accid)
        {

            string url =
                $"https://{region}.api.riotgames.com/lol/match/v3/matchlists/by-account/{accid}/recent?api_key={apiKey}";

            return url;
        }

        public static string GetMatchUrls(string region, string matchid)
        {
            string url = String.Format("https://{0}.api.riotgames.com/"); //working progress
            return null;
        }


    }
}