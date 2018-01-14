using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoLQueen
{
    public class OwDeserialize
    {

        public const string Username = "Quadzilla";
        public const string Usernum = "21122";

        public static async Task<OWInfo> ConnectToBlizzard()
        {
            var http = new HttpClient();

            string blizzardUrl = String.Format("https://" + "ow-api.herokuapp.com/stats/pc/us/" + Username + "-" + Usernum);

            var response = await http.GetAsync(blizzardUrl);

            var result = await response.Content.ReadAsStringAsync();

            Debug.WriteLine("The result is: ",result);

            return JsonConvert.DeserializeObject<OWInfo>(result);


        }
    }
}