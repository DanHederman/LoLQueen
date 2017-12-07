using System;
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

            Label1.Content = root.Name;
            Label2.Content = root.SummonerLevel;
        }
    }
}
