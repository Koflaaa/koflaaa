using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Spieler
    {
        //zur Zusammenzählung aller Kartenwerte
        public int total_points;
        //um das Spiel zu starten/beenden
        public bool want_draw_card;
        //Klassenliste, in denen die Karten/Objekte der Klasse Karten, gespeichert werden
        public List<Karten> player_cards = new List<Karten> { };
        //Konstruktor
        public Spieler()
        {
            int total_points;
            bool want_draw_card;
        }
        //Methode, welche Karten den Spielern hinzufügt
        public void Draw(Karten karte)
        {
            player_cards.Add(karte);
        }
        //Methode, welche die Karten des Spielers anzeigt
        public void Show_hand()
        {
            Console.WriteLine("Your Hand: ");
            for (int i = 0; i < player_cards.Count; i++)
            {
                Console.Write(player_cards[i].card_num + " ");
            }
        }
    }
}
