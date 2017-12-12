using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace LoLQueen
{
    public class Deserialize
    {
        /* Variable used to make the program more universal
         * Changing the variables allows the program to show
         * Different users without altering the URL manually
         */

        private const string ApiKey = "";

        private const string Region = "euw1";


        public static async Task<Summoner> ConnectToRiot(string user, string regionName)
        {
            var http = new HttpClient();

            string riotUrl = String.Format(
                "https://" + Region + ".api.riotgames.com/lol/summoner/v3/summoners/by-name/" + user + "?api_key=" + ApiKey,
                regionName, user, ApiKey);

            var response = await http.GetAsync(riotUrl);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Summoner>(result);

        }

        /*
         * Connects to the API to retrive the match history
         * useds account id and region to create the correct
         * link & then deserialize the response
         */

        public static async Task<MatchList> ObtainMatchList(string accID, string regionName)
        {

            var http = new HttpClient();

            string riotUrl = String.Format("https://{0}.api.riotgames.com/lol/match/v3/matchlists/by-account/{1}/recent?api_key={2}", regionName, accID, ApiKey);


            var response = await http.GetAsync(riotUrl);


            var result = await response.Content.ReadAsStringAsync();

            MatchList matchList = JsonConvert.DeserializeObject<MatchList>(result); 

            return matchList;

        }
    }
}
 