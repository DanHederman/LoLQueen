using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using static iTextSharp.text.Color;

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

        /* This button, when called, will use the summoner name
         * & API key to connect to the API and gather the info
         * deserialize it, and change the label contents to 
         * display the data
         */

        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {

            string userInput = SummName.Text.Replace(" ", "%20");
            var obj = await Deserialize.ConnectToRiot(userInput, "EUW1");
            string output = JsonConvert.SerializeObject(obj);
            var root = JsonConvert.DeserializeObject<Summoner>(output);

            Label1.Content = root.Name;
            Label2.Content = root.SummonerLevel;

            
        }
        /*
         * This button prints the lane of the summoner
         * in question. It appends the lane type to 
         * the strign lane
         */

        private async void ButtonMatchHist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Hardcoded the summoner ID for now
                MatchList matchList = await Deserialize.ObtainMatchList("25414674", "euw1");
               
                MatchHist1.Content = matchList.Matches[0].Lane;
                MatchHist2.Content = matchList.Matches[0].PlatformId;
                MatchHist3.Content = matchList.Matches[0].Role;
                MatchHist4.Content = matchList.Matches[0].Queue.ToString();

            }
            catch(Exception b)
            {
                Console.WriteLine(b.Message);
                throw;
            }
        }
    }
}
