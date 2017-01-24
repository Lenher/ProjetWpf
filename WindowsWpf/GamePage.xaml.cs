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
    /// Logique d'interaction pour GamePage.xaml
    /// </summary>
    public partial class GamePage : UserControl
    {
        private Game game;
        private Player player;
        private Session session;

        private int op1;
        private int op2;
        private char op_;

        private bool isFirst;

        private int posFirst = -1;
        private int posSecond = -1;


        public GamePage(Session session, Game game, Player player)
        {
            this.session = session;
            this.game = game;
            this.player = player;
            InitializeComponent();
            result.Text = Convert.ToString(game.ExpectedResult);
            txtB_un.Text = Convert.ToString(game.Numbers[0]);
            txtB_deux.Text = Convert.ToString(game.Numbers[1]);
            txtB_trois.Text = Convert.ToString(game.Numbers[2]);
            txtB_quatre.Text = Convert.ToString(game.Numbers[3]);
            txtB_cinq.Text = Convert.ToString(game.Numbers[4]);
            playerName.Text = player.ToString();
            gameNumber.Text = Convert.ToString(session.CurrentGame);
            currentScore.Text = Convert.ToString(session.TotalScore);
        } 

        private void operande_click(object sender, RoutedEventArgs e)
        {
            int thisCase;
            switch (Convert.ToString(((Button)sender).Tag))
            {
                case "0":
                    thisCase = 0;
                    // Change background button
                    un.Background = Brushes.LightSlateGray;
                    
                    // Case with no numbers selected
                    if (posFirst == -1 && posSecond == -1)
                    {
                        // Get position of click
                        posFirst = thisCase;
                        // Stock for calculation
                        op1 = game.Numbers[thisCase];
                        // Write in operation to calculate
                        Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                    }
                    else
                    {
                        // Case with this one as First
                        if (thisCase == posFirst)
                        {
                            un.Background = Brushes.Gainsboro;
                            posFirst = -1;
                            op1 = 0;
                            Operande_une.Text = "";
                        }
                        // Case with this one as Second
                        else if (thisCase == posSecond)
                        {
                            un.Background = Brushes.Gainsboro;
                            posSecond = -1;
                            op2 = 0;
                            Operande_deux.Text = "";
                        }
                        // Case with first selected but not the second
                        else if (posFirst >= 0 && posSecond == -1)
                        {
                            // Get position of click
                            posSecond = thisCase;
                            Operande_deux.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op2 = game.Numbers[thisCase];
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1  && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op1 = game.Numbers[thisCase];
                        }
                        // Case with both numbers are already selected
                        else
                        {
                            un.Background = Brushes.Gainsboro;
                        }
                    }
                    break;

                case "1":
                    thisCase = 1;
                    // Change background button
                    deux.Background = Brushes.LightSlateGray;

                    // Case with no numbers selected
                    if (posFirst == -1 && posSecond == -1)
                    {
                        // Get position of click
                        posFirst = thisCase;
                        // Stock for calculation
                        op1 = game.Numbers[thisCase];
                        // Write in operation to calculate
                        Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                    }
                    else
                    {
                        // Case with this one as First
                        if (thisCase == posFirst)
                        {
                            deux.Background = Brushes.Gainsboro;
                            posFirst = -1;
                            op1 = 0;
                            Operande_une.Text = "";
                        }
                        // Case with this one as Second
                        else if (thisCase == posSecond)
                        {
                            deux.Background = Brushes.Gainsboro;
                            posSecond = -1;
                            op2 = 0;
                            Operande_deux.Text = "";
                        }
                        // Case with first selected but not the second
                        else if (posFirst >= 0 && posSecond == -1)
                        {
                            // Get position of click
                            posSecond = thisCase;
                            Operande_deux.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op2 = game.Numbers[thisCase];
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1 && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op1 = game.Numbers[thisCase];
                        }
                        // Case with both numbers are already selected
                        else
                        {
                            deux.Background = Brushes.Gainsboro;
                        }
                    }
                    break;

                case "2":
                    thisCase = 2;
                    // Change background button
                    trois.Background = Brushes.LightSlateGray;

                    // Case with no numbers selected
                    if (posFirst == -1 && posSecond == -1)
                    {
                        // Get position of click
                        posFirst = thisCase;
                        // Stock for calculation
                        op1 = game.Numbers[thisCase];
                        // Write in operation to calculate
                        Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                    }
                    else
                    {
                        // Case with this one as First
                        if (thisCase == posFirst)
                        {
                            trois.Background = Brushes.Gainsboro;
                            posFirst = -1;
                            op1 = 0;
                            Operande_une.Text = "";
                        }
                        // Case with this one as Second
                        else if (thisCase == posSecond)
                        {
                            trois.Background = Brushes.Gainsboro;
                            posSecond = -1;
                            op2 = 0;
                            Operande_deux.Text = "";
                        }
                        // Case with first selected but not the second
                        else if (posFirst >= 0 && posSecond == -1)
                        {
                            // Get position of click
                            posSecond = thisCase;
                            Operande_deux.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op2 = game.Numbers[thisCase];
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1 && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op1 = game.Numbers[thisCase];
                        }
                        // Case with both numbers are already selected
                        else
                        {
                            trois.Background = Brushes.Gainsboro;
                        }
                    }
                    break;

                case "3":
                    thisCase = 3;
                    // Change background button
                    quatre.Background = Brushes.LightSlateGray;

                    // Case with no numbers selected
                    if (posFirst == -1 && posSecond == -1)
                    {
                        // Get position of click
                        posFirst = thisCase;
                        // Stock for calculation
                        op1 = game.Numbers[thisCase];
                        // Write in operation to calculate
                        Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                    }
                    else
                    {
                        // Case with this one as First
                        if (thisCase == posFirst)
                        {
                            quatre.Background = Brushes.Gainsboro;
                            posFirst = -1;
                            op1 = 0;
                            Operande_une.Text = "";
                        }
                        // Case with this one as Second
                        else if (thisCase == posSecond)
                        {
                            quatre.Background = Brushes.Gainsboro;
                            posSecond = -1;
                            op2 = 0;
                            Operande_deux.Text = "";
                        }
                        // Case with first selected but not the second
                        else if (posFirst >= 0 && posSecond == -1)
                        {
                            // Get position of click
                            posSecond = thisCase;
                            Operande_deux.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op2 = game.Numbers[thisCase];
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1 && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op1 = game.Numbers[thisCase];
                        }
                        // Case with both numbers are already selected
                        else
                        {
                            quatre.Background = Brushes.Gainsboro;
                        }
                    }
                    break;

                case "4":
                    thisCase = 4;
                    // Change background button
                    cinq.Background = Brushes.LightSlateGray;

                    // Case with no numbers selected
                    if (posFirst == -1 && posSecond == -1)
                    {
                        // Get position of click
                        posFirst = thisCase;
                        // Stock for calculation
                        op1 = game.Numbers[thisCase];
                        // Write in operation to calculate
                        Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                    }
                    else
                    {
                        // Case with this one as First
                        if (thisCase == posFirst)
                        {
                            cinq.Background = Brushes.Gainsboro;
                            posFirst = -1;
                            op1 = 0;
                            Operande_une.Text = "";
                        }
                        // Case with this one as Second
                        else if (thisCase == posSecond)
                        {
                            cinq.Background = Brushes.Gainsboro;
                            posSecond = -1;
                            op2 = 0;
                            Operande_deux.Text = "";
                        }
                        // Case with first selected but not the second
                        else if (posFirst >= 0 && posSecond == -1)
                        {
                            // Get position of click
                            posSecond = thisCase;
                            Operande_deux.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op2 = game.Numbers[thisCase];
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1 && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            Operande_une.Text = Convert.ToString(game.Numbers[thisCase]);
                            // Stock for calculation
                            op1 = game.Numbers[thisCase];
                        }
                        // Case with both numbers are already selected
                        else
                        {
                            cinq.Background = Brushes.Gainsboro;
                        }
                    }
                    break;
            }
        }

        private void operateur_click(object sender, RoutedEventArgs e)
        {
            switch (Convert.ToString(((Button)sender).Tag))
            {
                case "+":
                    Operateur.Text = txtB_plus.Text;
                    Bplus.Background = Brushes.LightSlateGray;
                    Bmoins.Background = Brushes.Gainsboro;
                    Bfoix.Background = Brushes.Gainsboro;
                    Bdivise.Background = Brushes.Gainsboro;
                    op_ = '+';
                    break;
                case "-":
                    Operateur.Text = txtB_moins.Text;
                    Bplus.Background = Brushes.Gainsboro;
                    Bmoins.Background = Brushes.LightSlateGray;
                    Bfoix.Background = Brushes.Gainsboro;
                    Bdivise.Background = Brushes.Gainsboro;
                    op_ = '-';
                    break;
                case "*":
                    Operateur.Text = txtB_multiplier.Text;
                    Bplus.Background = Brushes.Gainsboro;
                    Bmoins.Background = Brushes.Gainsboro;
                    Bfoix.Background = Brushes.LightSlateGray;
                    Bdivise.Background = Brushes.Gainsboro;
                    op_ = '*';
                    break;
                case "/":
                    Operateur.Text = txtB_diviser.Text;
                    Bplus.Background = Brushes.Gainsboro;
                    Bmoins.Background = Brushes.Gainsboro;
                    Bfoix.Background = Brushes.Gainsboro;
                    Bdivise.Background = Brushes.LightSlateGray;
                    op_ = '/';
                    break;
            }
        }

        private void calculer_click(object sender, RoutedEventArgs e)
        {
            isFirst = true;

            int result = game.Operation(op1, op2, op_);

            if (result == -1)
            {
                // Numéro bouton à passer en couleur de base
                
            }
            else
            {
                // Get position, disable second et get result in first
                if (un.IsEnabled == false)
                {
                    un.IsEnabled = true;
                    txtB_un.Text = Convert.ToString(result);

                }
                else if (deux.IsEnabled == false)
                {
                    deux.IsEnabled = true;
                    txtB_deux.Text = Convert.ToString(result);
                }
                else if (trois.IsEnabled == false)
                {
                    trois.IsEnabled = true;
                    txtB_trois.Text = Convert.ToString(result);
                }
                else if (quatre.IsEnabled == false)
                {
                    quatre.IsEnabled = true;
                    txtB_quatre.Text = Convert.ToString(result);
                }
                else if (cinq.IsEnabled == false)
                {
                    cinq.IsEnabled = true;
                    txtB_cinq.Text = Convert.ToString(result);
                }

                Operande_une.Text = "";
                Operande_deux.Text = "";
                Operateur.Text = "";
            }
        }

        


    }
}
