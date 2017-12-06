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
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        public async Task Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            Summoner root = new Summoner { summoner = new Summoner() };
            root = await Deserialize.ConnectToRiot("Notorious Nutz", "EUW");
            string name = root.summoner.name;
            int level = root.summoner.summonerLevel;

            Label1.Content = name + " is level " + level;
        }
    }
}
