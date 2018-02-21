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
                    Debug.WriteLine("\n\n\n\n\n\n" + currentHero.stats.top_heroes.competitive[1].hero.ToString());
                    Debug.WriteLine("\n\n\n\n\n\n\n");
                    HeroName.Text = currentHero.username;
                    Debug.WriteLine("new hero"+HeroName);
                    HeroLevel.Text = currentHero.level.ToString();
                    Debug.WriteLine("Successful");
                    PlayerImg.ImageUrl = currentHero.portrait;
                    QuickWin.Text = currentHero2.Games.Quickplay.Won.ToString();
                    RankImg.ImageUrl = currentHero2.Competitive.Rank_img;
                    CompWin.Text = currentHero2.Games.Competitive.Won.ToString();
                    
                    //Quickplay top herpoes
                    TopHeroesLabel1.Text = currentHero.stats.top_heroes.quickplay[0].hero.ToString();
                    TopHeroesLabel2.Text = currentHero.stats.top_heroes.quickplay[1].hero.ToString();
                    TopHeroesLabel3.Text = currentHero.stats.top_heroes.quickplay[2].hero.ToString();
                    TopHeroesLabel4.Text = currentHero.stats.top_heroes.quickplay[3].hero.ToString();
                    TopHeroesLabel5.Text = currentHero.stats.top_heroes.quickplay[4].hero.ToString();

                    //Competitive top heroes
                    TopHeroLabel1.Text = currentHero.stats.top_heroes.competitive[0].hero.ToString();
                    TopHeroLabel2.Text = currentHero.stats.top_heroes.competitive[1].hero.ToString();
                    TopHeroLabel3.Text = currentHero.stats.top_heroes.competitive[2].hero.ToString();
                    TopHeroLabel4.Text = currentHero.stats.top_heroes.competitive[3].hero.ToString();
                    TopHeroLabel5.Text = currentHero.stats.top_heroes.competitive[4].hero.ToString();

                    AssistsLabel.Text = currentHero.stats.assists.quickplay[0].value.ToString();
                    CompAssistsLabel.Text = currentHero.stats.assists.competitive[0].value.ToString();

                    CombatQuickLabel.Text = currentHero.stats.combat.quickplay[0].title.ToString();
                    CombatQuickLabel1.Text = currentHero.stats.combat.quickplay[0].value.ToString();

                    CombatCompLabel.Text = currentHero.stats.combat.competitive[0].title.ToString();
                    CombatCompLabel1.Text = currentHero.stats.combat.competitive[0].value.ToString();

                    GameQuickLabel.Text = currentHero.stats.game.quickplay[0].title.ToString();
                    GameQuickLabel1.Text = currentHero.stats.game.quickplay[0].value.ToString();

                    GameCompLabel.Text = currentHero.stats.game.quickplay[0].title.ToString();
                    GameCompLabel1.Text = currentHero.stats.game.quickplay[0].value.ToString();

                    Match_AwardsQuickLabel.Text = currentHero.stats.match_awards.quickplay[0].title.ToString();
                    Match_AwardsQuickLabel1.Text = currentHero.stats.match_awards.quickplay[0].value.ToString();

                    Match_AwardsCompLabel.Text = currentHero.stats.match_awards.competitive[0].title.ToString();
                    Match_AwardsCompLabel1.Text = currentHero.stats.match_awards.competitive[0].value.ToString();

                    MiscQuickLabel.Text = currentHero.stats.miscellaneous.quickplay[0].title.ToString();
                    MiscQuickLabel1.Text = currentHero.stats.miscellaneous.quickplay[0].value.ToString();

                    MiscCompLabel.Text = currentHero.stats.miscellaneous.competitive[0].ToString();
                    MiscCompLabel1.Text = currentHero.stats.miscellaneous.competitive[0].ToString();



                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine(message: "Error occured: Could not assign data from structures in Hero and Hero2 to GUI");
                }
            }
        }
    }
}