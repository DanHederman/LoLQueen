using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace LoLQueen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Entered button click");
            var obj = await Deserialize.ConnectToRiot("MLPQuadzilla", "EUW1");
            string output = JsonConvert.SerializeObject(obj);
            var root = JsonConvert.DeserializeObject<Summoner>(output);

            Label1.Content = root.AccountId;
            Label2.Content = root.SummonerLevel;

            
        }

        private async void ButtonMatchHist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("Entered match hist select");
                MatchList matchList = await Deserialize.ObtainMatchList("25414674", "euw1");
                Console.WriteLine("Done");
                // string output = JsonConvert.SerializeObject(obj);
                //var matchHist = JsonConvert.DeserializeObject<MatchList>(output);
                /*
                MatchList matchList = JsonConvert.DeserializeObject<MatchList>(obj);
                */
                foreach (Match match in matchList.matches)
                {
                    Console.WriteLine(match.role);
                }

                MatchHist1.Content = matchList.matches[0].Lane;
            }
            catch(Exception b)
            {
                Console.WriteLine(b.Message);
                throw;
            }
            

            //Console.WriteLine(matchHist.testMatches[0].role);
            

        }
    }
}
