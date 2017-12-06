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
        private const string APIKey = "key";

        public async static Task<wrapper> ConnectToRiot(string user, string regionName)
        {
            var http = new HttpClient();
            string riotURL = String.Format("link",
                regionName, user, APIKey);

            var response = await http.GetAsync(riotURL);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<wrapper>(result);

        }
    }
}