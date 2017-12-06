using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;


namespace LoLQueen
{
    public class Deserialize
    {
        private const string APIKey = "RGAPI-78d81007-1c3c-4586-8d6c-52c94163f3eb";

        public async static Task<wrapper> ConnectToRiot(string user, string regionName)
        {
            var http = new HttpClient();
            string riotURL = String.Format("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Notorious%20Nutz?api_key=RGAPI-78d81007-1c3c-4586-8d6c-52c94163f3eb",
                regionName, user, APIKey);
            var response = await http.GetAsync(riotURL);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<wrapper>(result);

        }
    }
}