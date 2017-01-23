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
    /// Logique d'interaction pour GamePage.xaml
    /// </summary>
    public partial class GamePage : UserControl
    {
        public GamePage()
        {
            InitializeComponent();
        }

        private int operande = 0;

        private int op1;
        private int op2;
        private int op_;

        private void un_click(object sender, RoutedEventArgs e)
        {           
            if (operande == 0)
            {
                Operande_une.Text = txtB_un.Text;
                operande += 1;
                un.Background = Brushes.Black;
                op1 = Convert.ToInt32(txtB_deux.Text);

            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_un.Text;
                un.Background = Brushes.Black;
                operande += 1;


            }
        }

        private void deux_click(object sender, RoutedEventArgs e)
        {
            if (operande == 0)
            {
                Operande_une.Text = txtB_deux.Text;
                operande += 1;
                deux.Background = Brushes.Black;
            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_deux.Text;
                operande += 1;
                deux.Background = Brushes.Black;
            }
        }

        private void trois_click(object sender, RoutedEventArgs e)
        {
            if (operande == 0)
            {
                Operande_une.Text = txtB_trois.Text;
                operande += 1;
                trois.Background = Brushes.Black;
            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_trois.Text;
                operande += 1;
                trois.Background = Brushes.Black;
            }
        }

        private void quatre_click(object sender, RoutedEventArgs e)
        {
            if (operande == 0)
            {
                Operande_une.Text = txtB_quatre.Text;
                operande += 1;
                quatre.Background = Brushes.Black;
            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_quatre.Text;
                operande += 1;
                quatre.Background = Brushes.Black;

            }
        }

        private void cinq_click(object sender, RoutedEventArgs e)
        {
            if (operande == 0)
            {
                Operande_une.Text = txtB_cinq.Text;
                operande += 1;
                cinq.Background = Brushes.Black;
            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_cinq.Text;
                operande += 1;
                cinq.Background = Brushes.Black;
            }
        }

        private void  plus_click(object sender, RoutedEventArgs e)
        {
            Operateur.Text = txtB_plus.Text;
        }

        private void moins_click(object sender, RoutedEventArgs e)
        {
            Operateur.Text = txtB_moins.Text;
        }

        private void multiplier_click(object sender, RoutedEventArgs e)
        {
            Operateur.Text = txtB_multiplier.Text;
        }

        private void diviser_click(object sender, RoutedEventArgs e)
        {
            Operateur.Text = txtB_diviser.Text;
        }

        private void calculer_click (object sender, RoutedEventArgs e)
        {
            
        }

        


    }
}
