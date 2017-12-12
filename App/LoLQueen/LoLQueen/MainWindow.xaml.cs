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
            string userInput = SummName.Text.Replace(" ", "%20");
            var obj = await Deserialize.ConnectToRiot(userInput, "EUW1");
            string output = JsonConvert.SerializeObject(obj);
            var root = JsonConvert.DeserializeObject<Summoner>(output);

            Label1.Content = root.AccountId;
            Label2.Content = root.SummonerLevel;

            
        }

        private async void ButtonMatchHist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MatchList matchList = await Deserialize.ObtainMatchList("25414674", "euw1");
               
                MatchHist1.Content = matchList.Matches[0].Lane;
            }
            catch(Exception b)
            {
                Console.WriteLine(b.Message);
                throw;
            }
            


            

        }
    }
}
