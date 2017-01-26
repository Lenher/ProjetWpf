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
using BDDWpf;

namespace WindowsWpf
{
    /// <summary>
    /// Logique d'interaction pour ScoringPage.xaml
    /// </summary>
    public partial class ScoringPage : UserControl
    {
        public ScoringPage()
        {
            InitializeComponent();
            List<User> scoring = UserManager.GetByScore();
            UserManager.Open();
            win_1.Text = Convert.ToString(scoring[0]);
            win_2.Text = Convert.ToString(scoring[1]);
            win_3.Text = Convert.ToString(scoring[2]);
            win_4.Text = Convert.ToString(scoring[3]);
        }

        public void Quit_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new WindowsWpf.Menu();
            Content = menu;
        }


    }


}
