using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Wuerfelspiel
{
    class Dice
    {
        public int dice_value; //integer that has the value of the dice_roll in it

        public void Dice_roll()//generates a random value for the dice to have
        {
            Random rnd = new Random();//creates a new random object
            dice_value = rnd.Next(1, 7);//generates a random value between 1 and 6
        }
    }
}
