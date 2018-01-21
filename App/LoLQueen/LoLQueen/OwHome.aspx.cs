using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoLQueen
{
    public partial class OwHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RedirectToLoL(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void RedirectHome(object sender, EventArgs e)
        {
            
        }

        protected void DataGen(object sender, EventArgs e)
        {
            var username = HeroNameBox.Text;
            var usernum = HeroTag.Text;
            Debug.WriteLine("Deserialize");

            string obj = BlizzardUrl.ConnectToBlizzard(username, usernum);
            string obj2 = BlizzardUrl.ConnectToBlizzard2(username, usernum);
            Debug.WriteLine(obj);
            RootObject currentHero = Home.getJsonObject<RootObject>(obj);
            Root currentHero2 = Home.getJsonObject<Root>(obj2);
            Debug.WriteLine(currentHero);

            UpdatePageData(currentHero, currentHero2);
        }

        public void UpdatePageData(RootObject currentHero, Root currentHero2)
        {
            HeroName.Text = currentHero.username;
            HeroLevel.Text = currentHero.level.ToString();
            PlayerImg.ImageUrl = currentHero.portrait;
            Label3.Text = currentHero2.games.quickplay.won.ToString();          
            RankImg.ImageUrl = currentHero2.competitive.rank_img;
            CompWin.Text = currentHero2.games.competitive.won.ToString();
        }
    }
}