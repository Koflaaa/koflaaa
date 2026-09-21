using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Wuerfelspiel
{
    class Player:Dice
    {
        public string player_name;
        public int player1_dice1_value;
        public int player1_dice2_value;
        public int player2_dice1_value;
        public int player2_dice2_value;
        public int player1_points;
        public int player1_pointsum;
        public int player2_points;
        public int player2_pointsum;
        public string Get_name()
        {
            string[] names = new string[20]
            {
                "Jay",
                "Memory",
                "Kevin",
                "Barbara",
                "David",
                "Ina",
                "Denise",
                "Dominik",
                "Daniel",
                "Pinocchio",
                "Bella",
                "Emma",
                "Finya",
                "Gloria",
                "Hildegard",
                "Marley",
                "Mila",
                "Randy",
                "Rusty",
                "Sam",
            };

            Random ran = new Random(); //gets a random name for the players
            int name_value = ran.Next(0, 20);
            player_name = names[name_value];

            return player_name;
        }

        public int Get_player1_points() //function for player one creating dice for player1 and getting their points
        {
            Dice player1_dice1 = new Dice();
            Dice player1_dice2 = new Dice();

            player1_dice1.Dice_roll();
            player1_dice2.Dice_roll();

            player1_dice1_value = player1_dice1.dice_value;
            player1_dice2_value = player1_dice2.dice_value;

            if (player1_dice1.dice_value + player1_dice2.dice_value >= 6 && player1_dice1.dice_value != player1_dice2.dice_value)
            {
                player1_pointsum = player1_dice1.dice_value + player1_dice2.dice_value;
                player1_points += player1_pointsum;
            }
            else if(player1_dice1.dice_value + player1_dice2.dice_value < 6 && player1_points != 0)
            {
                player1_pointsum = player1_dice1.dice_value + player1_dice2.dice_value;
                player1_points -= player1_pointsum;
                
            }
            return player1_points;
        }

        public int Get_player2_points() // function for player two creating dice for player2 and getting their points
        {
            Dice player2_dice1 = new Dice();
            Dice player2_dice2 = new Dice();

            player2_dice1.Dice_roll();
            player2_dice2.Dice_roll();

            player2_dice1_value = player2_dice1.dice_value;
            player2_dice2_value = player2_dice2.dice_value;

            if (player2_dice1.dice_value + player2_dice2.dice_value >= 6 && player2_dice1.dice_value != player2_dice2.dice_value)
            {
                player2_pointsum = player2_dice1.dice_value + player2_dice2.dice_value;
                player2_points += player2_pointsum;
            }
            else if(player2_dice1.dice_value + player2_dice2.dice_value < 6 && player2_points != 0)
            {
                player2_pointsum = player2_dice1.dice_value + player2_dice2.dice_value;
                player2_points -= player2_pointsum;
            }
            return player2_points;
        }
    }
}
