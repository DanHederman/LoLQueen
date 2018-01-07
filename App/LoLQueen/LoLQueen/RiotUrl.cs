using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLQueen
{
    public class RiotUrl
    {
        static string apiKey = "RGAPI-e0d0a0ab-1309-4c4d-bfbf-de3f3d680242";

        public static string GetSummonerUrl(string username, string region)
        {
            string url = String.Format("https://{0}.api.riotgames.com/lol/summoner/v3/summoners/by-name/{1}?api_key={2}",region, username, apiKey);

            return url;
        }

        public static string GetMatchHistUrl(string region, string accID)
        {

            string url =
                String.Format("https://{0}.api.riotgames.com/lol/match/v3/matchlists/by-account/{1}/recent?api_key={2}",
                    region, accID, apiKey);

            return url;
        }

        public static string GetMatchUrls(string region, string matchID)
        {
            string url = String.Format("https://{0}.api.riotgames.com/"); //working progress
        }


    }
}