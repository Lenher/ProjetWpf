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
                op1 = Convert.ToInt32(txtB_un.Text);
                un.IsEnabled = false;

            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_un.Text;
                op2 = Convert.ToInt32(txtB_un.Text);
                operande += 1;
                un.IsEnabled = false;


            }
        }

        private void deux_click(object sender, RoutedEventArgs e)
        {
            if (operande == 0)
            {
                Operande_une.Text = txtB_deux.Text;
                op1 = Convert.ToInt32(txtB_deux.Text);
                operande += 1;
                deux.IsEnabled = false;
            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_deux.Text;
                op2 = Convert.ToInt32(txtB_deux.Text);
                operande += 1;
                deux.IsEnabled = false;

            }
        }

        private void trois_click(object sender, RoutedEventArgs e)
        {
            if (operande == 0)
            {
                Operande_une.Text = txtB_trois.Text;
                op1 = Convert.ToInt32(txtB_trois.Text);
                operande += 1;
                trois.IsEnabled = false;

            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_trois.Text;
                op2 = Convert.ToInt32(txtB_trois.Text);
                operande += 1;
                trois.IsEnabled = false;
            }
        }

        private void quatre_click(object sender, RoutedEventArgs e)
        {
            if (operande == 0)
            {
                Operande_une.Text = txtB_quatre.Text;
                op1 = Convert.ToInt32(txtB_quatre.Text);
                operande += 1;
                quatre.IsEnabled = false;
            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_quatre.Text;
                op2 = Convert.ToInt32(txtB_quatre.Text);
                operande += 1;
                quatre.IsEnabled = false;
            }
        }

        private void cinq_click(object sender, RoutedEventArgs e)
        {
            if (operande == 0)
            {
                Operande_une.Text = txtB_cinq.Text;
                op1 = Convert.ToInt32(txtB_cinq.Text);
                operande += 1;
                cinq.IsEnabled = false;

            }
            else if (operande == 1)
            {
                Operande_deux.Text = txtB_cinq.Text;
                op2 = Convert.ToInt32(txtB_cinq.Text);
                operande += 1;
                cinq.IsEnabled = false;

            }
        }

        private void  plus_click(object sender, RoutedEventArgs e)
        {
            Operateur.Text = txtB_plus.Text;
            op_ = '+';
        }

        private void moins_click(object sender, RoutedEventArgs e)
        {
            Operateur.Text = txtB_moins.Text;
            op_ = '-';
        }

        private void multiplier_click(object sender, RoutedEventArgs e)
        {
            Operateur.Text = txtB_multiplier.Text;
            op_ = '*';
        }

        private void diviser_click(object sender, RoutedEventArgs e)
        {
            Operateur.Text = txtB_diviser.Text;
            op_ = '/';
        }

        private void calculer_click(object sender, RoutedEventArgs e)
        {
            operande = 0;


            int calcule = 0;
            if(op_ == '+')
            {
                calcule = op1 + op2;
            }
            else if (op_ == '-')
            {
                calcule = op1 - op2;
            }
            else if (op_ == '*')
            {
                calcule = op1 * op2;
            }
            else if (op_ == '/')
            {
                calcule = op1 / op2;
            }

            if (un.IsEnabled == false)
            {
                un.IsEnabled = true;
                txtB_un.Text = Convert.ToString(calcule);

            }
            else if (deux.IsEnabled == false)
            {
                deux.IsEnabled = true;
                txtB_deux.Text = Convert.ToString(calcule);
            }
            else if (trois.IsEnabled == false)
            {
                trois.IsEnabled = true;
                txtB_trois.Text = Convert.ToString(calcule);
            }
            else if (quatre.IsEnabled == false)
            {
                quatre.IsEnabled = true;
                txtB_quatre.Text = Convert.ToString(calcule);
            }
            else if (cinq.IsEnabled == false)
            {
                cinq.IsEnabled = true;
                txtB_cinq.Text = Convert.ToString(calcule);
            }

            Operande_une.Text = "";
            Operande_deux.Text = "";
            Operateur.Text = "";
        }

        


    }
}
