﻿using System;

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
        static string apiKey = "RGAPI-535d3898-5f2f-4b4b-b8c9-f033e6739405";

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

        public static string GetMatchUrl(string gameId, string region)
        {
            string url = $"https://{region}.api.riotgames.com/lol/match/v3/matches/{gameId}?api_key={apiKey}";

            return url;
        }

    }
}