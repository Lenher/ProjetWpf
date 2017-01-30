using BDDWpf;
using GameEngine;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
        private char operateur;

        private int posFirst = -1;
        private int posSecond = -1;

        private int nbrOperation = 0;


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
            gameNumber.Text = Convert.ToString(session.GamePlayed);
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
                        op1 = Convert.ToInt32(txtB_un.Text);
                        // Write in operation to calculate
                        Operande_une.Text = txtB_un.Text;
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
                            op2 = Convert.ToInt32(txtB_un.Text);
                            // Write in operation to calculate
                            Operande_deux.Text = txtB_un.Text;
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1  && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            op1 = Convert.ToInt32(txtB_un.Text);
                            // Write in operation to calculate
                            Operande_une.Text = txtB_un.Text;
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
                        op1 = Convert.ToInt32(txtB_deux.Text);
                        // Write in operation to calculate
                        Operande_une.Text = txtB_deux.Text;
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
                            op2 = Convert.ToInt32(txtB_deux.Text);
                            // Write in operation to calculate
                            Operande_deux.Text = txtB_deux.Text;
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1 && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            op1 = Convert.ToInt32(txtB_deux.Text);
                            // Write in operation to calculate
                            Operande_une.Text = txtB_deux.Text;
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
                        op1 = Convert.ToInt32(txtB_trois.Text);
                        // Write in operation to calculate
                        Operande_une.Text = txtB_trois.Text;
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
                            // Stock for calculation
                            op2 = Convert.ToInt32(txtB_trois.Text);
                            // Write in operation to calculate
                            Operande_deux.Text = txtB_trois.Text;
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1 && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            // Stock for calculation
                            op1 = Convert.ToInt32(txtB_trois.Text);
                            // Write in operation to calculate
                            Operande_une.Text = txtB_trois.Text;
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
                        op1 = Convert.ToInt32(txtB_quatre.Text);
                        // Write in operation to calculate
                        Operande_une.Text = txtB_quatre.Text;
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
                            // Stock for calculation
                            op2 = Convert.ToInt32(txtB_quatre.Text);
                            // Write in operation to calculate
                            Operande_deux.Text = txtB_quatre.Text;
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1 && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            // Stock for calculation
                            op1 = Convert.ToInt32(txtB_quatre.Text);
                            // Write in operation to calculate
                            Operande_une.Text = txtB_quatre.Text;
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
                        op1 = Convert.ToInt32(txtB_cinq.Text);
                        // Write in operation to calculate
                        Operande_une.Text = txtB_cinq.Text;
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
                            // Stock for calculation
                            op2 = Convert.ToInt32(txtB_cinq.Text);
                            // Write in operation to calculate
                            Operande_deux.Text = txtB_cinq.Text;
                        }
                        // Case with second selected but not the first
                        else if (posFirst == -1 && posSecond >= 0)
                        {
                            // Get position of click
                            posFirst = thisCase;
                            // Stock for calculation
                            op1 = Convert.ToInt32(txtB_cinq.Text);
                            // Write in operation to calculate
                            Operande_une.Text = txtB_cinq.Text;
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
                    operateur = '+';
                    break;
                case "-":
                    Operateur.Text = txtB_moins.Text;
                    Bplus.Background = Brushes.Gainsboro;
                    Bmoins.Background = Brushes.LightSlateGray;
                    Bfoix.Background = Brushes.Gainsboro;
                    Bdivise.Background = Brushes.Gainsboro;
                    operateur = '-';
                    break;
                case "*":
                    Operateur.Text = txtB_multiplier.Text;
                    Bplus.Background = Brushes.Gainsboro;
                    Bmoins.Background = Brushes.Gainsboro;
                    Bfoix.Background = Brushes.LightSlateGray;
                    Bdivise.Background = Brushes.Gainsboro;
                    operateur = '*';
                    break;
                case "/":
                    Operateur.Text = txtB_diviser.Text;
                    Bplus.Background = Brushes.Gainsboro;
                    Bmoins.Background = Brushes.Gainsboro;
                    Bfoix.Background = Brushes.Gainsboro;
                    Bdivise.Background = Brushes.LightSlateGray;
                    operateur = '/';
                    break;
            }
        }

        private void solution_click(object sender, RoutedEventArgs e)
        {
            Solution.Text = "(((("
                +Convert.ToString(game.Numbers[0])
                +"*"
                +Convert.ToString(game.Numbers[1])
                +")-"
                +Convert.ToString(game.Numbers[2])
                +")+"
                +Convert.ToString(game.Numbers[3])
                +")/"
                +Convert.ToString(game.Numbers[4])
                +")";
        }

        private void calculer_click(object sender, RoutedEventArgs e)
        {
            int result = game.Operation(op1, op2, operateur);

            if (result == -1)
            {
                switch (posFirst)
                {
                    case 0:
                        un.Background = Brushes.Gainsboro;
                        break;
                    case 1:
                        deux.Background = Brushes.Gainsboro;
                        break;
                    case 2:
                        trois.Background = Brushes.Gainsboro;
                        break;
                    case 3:
                        quatre.Background = Brushes.Gainsboro;
                        break;
                    case 4:
                        cinq.Background = Brushes.Gainsboro;
                        break;
                }
                switch (posSecond)
                {
                    case 0:
                        un.Background = Brushes.Gainsboro;
                        break;
                    case 1:
                        deux.Background = Brushes.Gainsboro;
                        break;
                    case 2:
                        trois.Background = Brushes.Gainsboro;
                        break;
                    case 3:
                        quatre.Background = Brushes.Gainsboro;
                        break;
                    case 4:
                        cinq.Background = Brushes.Gainsboro;
                        break;
                }
            }
            else
            {
                switch (posFirst)
                {
                    case 0:
                        txtB_un.Text = Convert.ToString(result);
                        un.Background = Brushes.Gainsboro;
                        break;
                    case 1:
                        txtB_deux.Text = Convert.ToString(result);
                        deux.Background = Brushes.Gainsboro;
                        break;
                    case 2:
                        txtB_trois.Text = Convert.ToString(result);
                        trois.Background = Brushes.Gainsboro;
                        break;
                    case 3:
                        txtB_quatre.Text = Convert.ToString(result);
                        quatre.Background = Brushes.Gainsboro;
                        break;
                    case 4:
                        txtB_cinq.Text = Convert.ToString(result);
                        cinq.Background = Brushes.Gainsboro;
                        break;
                }
                switch (posSecond)
                {
                    case 0:
                        un.IsEnabled = false;
                        break;
                    case 1:
                        deux.IsEnabled = false;
                        break;
                    case 2:
                        trois.IsEnabled = false;
                        break;
                    case 3:
                        quatre.IsEnabled = false;
                        break;
                    case 4:
                        cinq.IsEnabled = false;
                        break;
                }
                nbrOperation++;
            }
            // Clean calculation text
            Operande_une.Text = "";
            Operande_deux.Text = "";
            Operateur.Text = "";

            Bplus.Background = Brushes.Gainsboro;
            Bmoins.Background = Brushes.Gainsboro;
            Bfoix.Background = Brushes.Gainsboro;
            Bdivise.Background = Brushes.Gainsboro;

            // Reinitialization of position
            posFirst = -1;
            posSecond = -1;
            operateur = ' ';

            // If all operations are done
            if (nbrOperation == 4)
            {
                game.updateScore(result);
                session.updateGame(game.Score);
                // If has not finish the session
                if (!session.isTerminated())
                {
                    Game game = new Game(session.Numbers[session.GamePlayed]);
                    GamePage gamePage = new GamePage(session, game, player);
                    Content = gamePage;
                }
                // If has finish the session
                else
                {
                    EndGamePage endGP = new EndGamePage(player, result);
                   // UserManager.Open();
                    //UserManager.Add(player.ToString(), result);
                    Content = endGP;
                }
            }
        }
    }
}
