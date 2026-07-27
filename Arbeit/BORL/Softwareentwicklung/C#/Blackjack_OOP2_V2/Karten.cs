using System;

namespace Blackjack
{
    class Karten
    {
        //Die Klasse "Karten" besitzt nur die Variable card_num
        public int card_num;
        //Konstruktor
        public Karten()
        {
            int card_num;
        }
        //Methode, welche eine Zufallsgenerierte Nummer wiedergibt und zur Wertzuweisung der Variable card_num benutzt wird
        public int Draw()
        {
            int num;
            Random rnd = new Random();
            num = rnd.Next(1, 11);
            return num;
        }
    }
}

