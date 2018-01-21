using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLQueen
{
    public class BlizzardUrl
    {
        public static string ConnectToBlizzard(string Username, string Usernum)
        {
            string blizzardUrl = String.Format("https://" + "ow-api.herokuapp.com/stats/pc/us/" + Username + "-" + Usernum);

            return blizzardUrl;
        }
        public static string ConnectToBlizzard2(string Username, string Usernum)
        {
            string blizzardUrl = String.Format("https://" + "ow-api.herokuapp.com/profile/pc/us/" + Username + "-" + Usernum);

            return blizzardUrl;
        }
    }
}