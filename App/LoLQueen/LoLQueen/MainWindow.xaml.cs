using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
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
            var obj = await Deserialize.ConnectToRiot("Notorious Nutz", "EUW1");
            string output = JsonConvert.SerializeObject(obj);
            var root = JsonConvert.DeserializeObject<Summoner>(output);

            Label1.Content = root.name + " is level " + root.summonerLevel;
        }
    }
}
