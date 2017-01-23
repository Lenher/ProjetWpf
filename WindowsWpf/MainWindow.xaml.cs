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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Pseudo.Text = "";
        }

        private void Connection_Click (object sender, RoutedEventArgs e)
        {
            if (Pseudo.Text != "")
            {

                Menu winMenu = new Menu();
                Content = winMenu;
            }
            else
            {
                error.Text = "Entrez un pseudo";
            }
            
        }


    }
}
