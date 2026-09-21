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

namespace WPF_Wuerfelspiel
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

        Player player_one = new(); //creates player one
        Player player_two = new(); // creates player two

        bool game_on = false; //game hasn't started yet
        int clear = 0; //resets the scores and stuff

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            game_on = true;
            MessageBox.Show("Welcome to the Dice Game!");
            Player1_Name.Text = player_one.Get_name(); //gets a random playername
            Player2_Name.Text = player_two.Get_name();
        }

        private void Reset_Click(object sender, RoutedEventArgs e) //button to reset the scores and everything
        {
            Dice1.Text = clear.ToString();
            Dice2.Text = clear.ToString();
            Player1_Points.Text = clear.ToString();
            Player2_Points.Text = clear.ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e) //closes the program when clicked
        {
            Application.Current.Shutdown();
        }

        private void Player1_Diceroll_Click(object sender, RoutedEventArgs e) // for the Diceroll of the first player
        {
            player_one.Get_player1_points();
            Dice1.Text = player_one.player1_dice1_value.ToString();
            Dice2.Text = player_one.player1_dice2_value.ToString();
            Player1_Points.Text = player_one.player1_points.ToString();

            if (player_one.player1_points >= 100 && player_one.player1_points > player_two.player2_points)
            {
                MessageBox.Show("Player 1 won!");
            }

        }

        private void Player2_Diceroll_Click(object sender, RoutedEventArgs e) // for the Diceroll of the second player
        {
            player_two.Get_player2_points();
            Dice1.Text = player_two.player2_dice1_value.ToString();
            Dice2.Text = player_two.player2_dice2_value.ToString();
            Player2_Points.Text = player_two.player2_points.ToString();

            if (player_two.player2_points >= 100 && player_two.player2_points > player_one.player1_points)
            {
                MessageBox.Show("Player 2 won!");
            }
        }
    }
}
