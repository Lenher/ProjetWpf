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
using GameEngine;


namespace WindowsWpf
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        private Player player;
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWin = new MainWindow();
            Content = MainWin;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Session session = new Session(player);
            session.ChooseAFile();
            if (session.Numbers[0] != null)
            {
                List<int> bleh = session.Numbers[0];
                Game game = new Game(bleh);
                GamePage gamePage = new GamePage(session, game, player);
                Content = gamePage;
            }
        }

        private void Scoring_CLick(object sender, RoutedEventArgs e)
        {
        }
    }
}
