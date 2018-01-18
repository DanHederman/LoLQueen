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
            var username = HeroName.Text;
            var usernum = HeroTag.Text;
            Debug.WriteLine("Deserialize");

            string obj = BlizzardUrl.ConnectToBlizzard(username, usernum);
            Debug.WriteLine(obj);
            Hero currentHero = Home.getJsonObject<Hero>(obj);
            Debug.WriteLine(currentHero);

            UpdatePageData(currentHero);
        }

        public void UpdatePageData(Hero currentHero)
        {
            Label1.Text = currentHero.UserName;
            Label2.Text = currentHero.Level.ToString();
            Image1.ImageUrl = currentHero.Portrait;
        }
    }
}