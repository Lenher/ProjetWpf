using GameEngine;
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

namespace WindowsWpf
{
    /// <summary>
    /// Logique d'interaction pour EndGamePage.xaml
    /// </summary>
    public partial class EndGamePage : Page
    {
        private Player player { get; set; }
        public EndGamePage(Player player, int score)
        {
            InitializeComponent();
            this.player = player;
            message.Text = "Félicitation "+player.ToString()+", tu as marqué "+Convert.ToString(score)+ "points !";
        }

        public void Menu(object sender, RoutedEventArgs e)
        {
            Menu menu = new WindowsWpf.Menu(player);
            Content = menu;
        }
        public void Scoring(object sender, RoutedEventArgs e)
        {
            Menu menu = new WindowsWpf.Menu(player);
            Content = menu;
        }
    }
}
