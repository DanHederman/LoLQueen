using System;

namespace LoLQueen
{
    public partial class OwHome : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Redirect to LoLQueen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            
            var currentHero = JsonSettings.GetStats<RootObject>(obj);
            var currentHero2 = JsonSettings.GetStats<Root>(obj2);
            

            UpdatePageData(currentHero, currentHero2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentHero"></param>
        /// <param name="currentHero2"></param>
        public void UpdatePageData(RootObject currentHero, Root currentHero2)
        {
            if (currentHero == null)
            {
                throw new ArgumentNullException(nameof(currentHero));
            }
            else if (currentHero2 == null)
            {
                throw new ArgumentNullException(nameof(currentHero2));
            }

            else
            {
                try
                {
                    HeroName.Text = currentHero.Stats.TopHeroes.Competitive.Capacity.ToString();
                    HeroLevel.Text = currentHero.Level.ToString();
                    PlayerImg.ImageUrl = currentHero.Portrait;
                    QuickWin.Text = currentHero2.Games.Quickplay.Won.ToString();
                    RankImg.ImageUrl = currentHero2.Competitive.Rank_img;
                    CompWin.Text = currentHero2.Games.Competitive.Won.ToString();
                    MatchHistoryGrid.EmptyDataText = currentHero.Stats.TopHeroes.ToString();
                    MatchHistoryGrid.EmptyDataText = currentHero.Stats.Assists.ToString();
                    MatchHistoryGrid.EmptyDataText = currentHero.Stats.Average.ToString();
                    TopHeroesLabel.Text = currentHero.Stats.TopHeroes.ToString();
                    AssistsLabel.Text = currentHero.Stats.Assists.ToString();
                    AverageLabel.Text = currentHero.Stats.Average.ToString();
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine(message: "Error occured: Could not assign data from structures in Hero and Hero2 to GUI");
                }
            }
        }
    }
}