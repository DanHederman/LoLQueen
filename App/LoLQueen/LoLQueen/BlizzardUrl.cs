using static System.String;

namespace LoLQueen
{
    public class BlizzardUrl
    {
        public static string ConnectToBlizzard(string username, string usernum)
        {
            string blizzardUrl = Format("https://" + "ow-api.herokuapp.com/stats/pc/us/" + username + "-" + usernum);

            return blizzardUrl;
        }
        public static string ConnectToBlizzard2(string username, string usernum)
        {
            string blizzardUrl = Format("https://" + "ow-api.herokuapp.com/profile/pc/us/" + username + "-" + usernum);

            return blizzardUrl;
        }
    }
}