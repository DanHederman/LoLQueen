using static System.String;

namespace LoLQueen
{
    public class BlizzardUrl
    {
        /*
         * First large json, some information missing
         */

        public static string ConnectToBlizzard(string username, string usernum)
        {
            string blizzardUrl = Format("https://" + "ow-api.herokuapp.com/stats/pc/us/" + username + "-" + usernum);

            return blizzardUrl;
        }

        /*
         * Second smaller json, information the first was missing 
         */

        public static string ConnectToBlizzard2(string username, string usernum)
        {
            string blizzardUrl = Format("https://" + "ow-api.herokuapp.com/profile/pc/us/" + username + "-" + usernum);

            return blizzardUrl;
        }
    }
}