using System;
using System.Diagnostics;

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DataGen(object sender, EventArgs e)
        {
            var username = HeroNameBox.Text;
            var usernum = HeroTag.Text;
            

            var obj = BlizzardUrl.ConnectToBlizzard(username, usernum);
            var obj2 = BlizzardUrl.ConnectToBlizzard2(username, usernum);
            
            var currentHero = Home.GetStats<RootObject>(obj);
            var currentHero2 = Home.GetStats<Root>(obj2);
            

            UpdatePageData(currentHero, currentHero2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentHero"></param>
        /// <param name="currentHero2"></param>
        public void UpdatePageData(RootObject currentHero, Root currentHero2)
        {
            HeroName.Text = currentHero.Username;
            HeroLevel.Text = currentHero.Level.ToString();
            PlayerImg.ImageUrl = currentHero.Portrait;
            QuickWin.Text = currentHero2.Games.Quickplay.Won.ToString();
            RankImg.ImageUrl = currentHero2.Competitive.Rank_img;
            CompWin.Text = currentHero2.Games.Competitive.Won.ToString();
        }
    }
}