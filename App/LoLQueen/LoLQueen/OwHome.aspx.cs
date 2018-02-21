using System;
using System.Diagnostics;

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
                    Debug.WriteLine("Attempt");
                    Debug.WriteLine("\n\n\n\n\n\n" + currentHero.stats.top_heroes.Competitive[1].Hero);
                    Debug.WriteLine("\n\n\n\n\n\n\n");
                    HeroName.Text = currentHero.username;
                    Debug.WriteLine("new hero"+HeroName);
                    HeroLevel.Text = currentHero.level.ToString();
                    Debug.WriteLine("Successful");
                    PlayerImg.ImageUrl = currentHero.portrait;
                    QuickWin.Text = currentHero2.Games.Quickplay.Won.ToString();
                    RankImg.ImageUrl = currentHero2.Competitive.RankImg;
                    CompWin.Text = currentHero2.Games.Competitive.Won.ToString();
                    
                    //Quickplay top herpoes
                    TopHeroesLabel1.Text = currentHero.stats.top_heroes.Quickplay[0].Hero;
                    TopHeroesLabel2.Text = currentHero.stats.top_heroes.Quickplay[1].Hero;
                    TopHeroesLabel3.Text = currentHero.stats.top_heroes.Quickplay[2].Hero;
                    TopHeroesLabel4.Text = currentHero.stats.top_heroes.Quickplay[3].Hero;
                    TopHeroesLabel5.Text = currentHero.stats.top_heroes.Quickplay[4].Hero;

                    //Competitive top heroes
                    TopHeroLabel1.Text = currentHero.stats.top_heroes.Competitive[0].Hero;
                    TopHeroLabel2.Text = currentHero.stats.top_heroes.Competitive[1].Hero;
                    TopHeroLabel3.Text = currentHero.stats.top_heroes.Competitive[2].Hero;
                    TopHeroLabel4.Text = currentHero.stats.top_heroes.Competitive[3].Hero;
                    TopHeroLabel5.Text = currentHero.stats.top_heroes.Competitive[4].Hero;

                    AssistsLabel.Text = currentHero.stats.assists.Quickplay[0].Value;
                    CompAssistsLabel.Text = currentHero.stats.assists.Competitive[0].Value;

                    CombatQuickLabel.Text = currentHero.stats.combat.Quickplay[0].Title;
                    CombatQuickLabel1.Text = currentHero.stats.combat.Quickplay[0].Value;

                    CombatCompLabel.Text = currentHero.stats.combat.Competitive[0].Title;
                    CombatCompLabel1.Text = currentHero.stats.combat.Competitive[0].Value;

                    GameQuickLabel.Text = currentHero.stats.game.Quickplay[0].Title;
                    GameQuickLabel1.Text = currentHero.stats.game.Quickplay[0].Value;

                    GameCompLabel.Text = currentHero.stats.game.Competitive[0].Title;
                    GameCompLabel1.Text = currentHero.stats.game.Competitive[0].Value;

                    Match_AwardsQuickLabel.Text = currentHero.stats.match_awards.Quickplay[0].Title;
                    Match_AwardsQuickLabel1.Text = currentHero.stats.match_awards.Quickplay[0].Value;

                    Match_AwardsCompLabel.Text = currentHero.stats.match_awards.Competitive[0].Title;
                    Match_AwardsCompLabel1.Text = currentHero.stats.match_awards.Competitive[0].Value;

                    MiscQuickLabel.Text = currentHero.stats.miscellaneous.Quickplay[0].Title;
                    MiscQuickLabel1.Text = currentHero.stats.miscellaneous.Quickplay[0].Value;

                    MiscCompLabel.Text = currentHero.stats.miscellaneous.Quickplay[2].Title;
                    MiscCompLabel1.Text = currentHero.stats.miscellaneous.Quickplay[2].Value;



                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine(message: "Error occured: Could not assign data from structures in Hero and Hero2 to GUI");
                }
            }
        }
    }
}