using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace LoLQueen
{
    public class Deserialize
    {
        /*Variable used to make the program more universal
         * Changing the variables allows the program to show
         * Different users without altering the URL manually
         */

        private const string ApiKey = "RGAPI-70e6c8fd-701d-43de-8fa4-3d3ac4efd6df";

        private const string SummonerName = "kgbbí";

        private const string Region = "euw1";

        //replace deserialize.cs asyn method with this

        public async static Task<Summoner> ConnectToRiot(string user, string regionName)
        {
            var http = new HttpClient();
            string riotUrl = String.Format(
                "https://" + Region + ".api.riotgames.com/lol/summoner/v3/summoners/by-name/" + SummonerName + "?api_key=" + ApiKey,
                regionName, user, ApiKey);

            /* Wait for the url to respond
             * Wait for the url to return something
             * Convert and deserialize the json to 
             * display the information
             */

        var response = await http.GetAsync(riotUrl);

            //Wait for the url to return something

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(result);

        }

        public async static Task<List<MatchHistory>> ConnectToRito(string user, string regionName)
        {
            var http = new HttpClient();
            string riotUrl = String.Format(
                "https://" + Region + ".api.riotgames.com/lol/summoner/v3/summoners/by-name/" + SummonerName + "?api_key=" + ApiKey,
                regionName, user, ApiKey);

            /* Wait for the url to respond
             * Wait for the url to return something
             * Convert and deserialize the json to 
             * display the information
             */

            var response = await http.GetAsync(riotUrl);

            //Wait for the url to return something

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<MatchHistory>>(result);

        }
    }
}
 