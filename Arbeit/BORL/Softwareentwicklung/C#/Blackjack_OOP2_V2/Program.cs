using System;
using System.Threading;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            //  Instanzierung beider Spieler-Objekte
            Spieler player1 = new();
            Spieler player2 = new();
            //Eingabe die entscheidet ob das Spiel beginnt 
            Console.WriteLine("Would you like to play a game of Blackjack? (| y | n |)");
            string play = Console.ReadLine();
            //Switch case damit nur der Code ausgeführt wird, der ausgeführt werden soll
            switch (play)
            {
                //Wenn "y" eingegeben wird, wird folgender Code ausgeführt und es findet ein Spiel statt
                case "y":
                    //Das Unterprogramm BlackJack mit Spieler als Parameter damit beide Spieler spielen können
                    static int BlackJack(Spieler player)
                    {
                        //Der Bool des Spielers werden auf true gestell damit das Spiel starten kann
                        player.want_draw_card = true;
                        Console.WriteLine("\nYour Turn! Shot first!");
                        //während der bool want_draw_card des Spieler true ist wird folgender Code ausgeführt
                        while (player.want_draw_card == true)
                        {
                            Console.WriteLine("Drawing a card . . . ");
                            Thread.Sleep(1000);
                            //Eine Karte wird aus der Klasse geformt
                            Karten card = new();
                            //Der Karte wird ein Wert zugewiesem
                            card.card_num = card.Draw();
                            //Die Karte wird dem Deck des Spielers hinzugefügt
                            player.Draw(card);
                            //Die Hand des Spielers wird angezeigt
                            player.Show_hand();
                            //for-Schleife mit der Länge der Hand des Spielers
                            for (int i = 0; i < player.player_cards.Count; i++)
                            {
                                if (player.player_cards[i].card_num == 11 && player.player_cards[i].card_num + player.total_points > 21) //Wenn der Spieler ein Ass gezogen hat, dessen Wert von 11 aber die Punktzahl von 21 überschreiten würde, wird der Wert vom Ass auf 1 gestellt 
                                {
                                    player.player_cards[i].card_num = 1;
                                }
                            }
                            //Der Wert der gezogenen Karte wird der Gesamtpunktzahl des Spielers hinzugefügt
                            player.total_points += card.card_num;
                            //Wenn der Spieler eine Punktzahl von 21 oder darüber besitzt wird dessen Zug beendet und die Schleife wird geschlossen
                            if (player.total_points >= 21)
                            {
                                //Wenn die Punktzahl genau auf 21 liegt, wird dem Spieler mitgeteilt, dass dieser ein BlackJack hat
                                if (player.total_points == 21)
                                {
                                    Console.WriteLine("Blackjack! Player wins!");
                                    player.want_draw_card = false;
                                }
                                //Bool want_draw_card wird auf false gesetzt womit der Spieler nicht mehr spielen kann
                                player.want_draw_card = false;
                                //Der Schleifendurchlauf wird mit einer break Anweisung beendet
                                break;
                            }

                            Console.WriteLine("\nDo you want to draw another card?('y' or 'n').");
                            //Der Spieler kann am Ende seines Zuges sich durch eine Eingabe entscheiden, ob dieser noch eine Karte Ziehen will
                            string draw_again = Convert.ToString(Console.ReadLine());
                            //Wenn "n" eingegeben wird, wird der bool want_draw_card auf false gestellt, womit der Spieler keinen weiteren Zug tätigen kann
                            if (draw_again == "n")
                            {
                                player.want_draw_card = false;
                            }
                        }
                        //Die Gesamtpunktzahl wird zurückgegeben
                        return player.total_points;
                    }
                    player1.total_points = BlackJack(player1);
                    //Die beiden Spieler werden dem Unterprogramm als aktueler Parameter übergeben
                    player2.total_points = BlackJack(player2);
                    //Die Gesamtpunktzahl von Spieler 1 wird angezeigt.
                    Console.WriteLine("\nPlayer's total points: " + player1.total_points);
                    //Die Gesamtpunktzahl von Spieler 2 wird angezeigt
                    Console.WriteLine("\nDealer's total points: " + player2.total_points);


                    if (player1.total_points > player2.total_points && player1.total_points <= 21 && player2.total_points < 21 || player2.total_points > 21 && player1.total_points <= 21)
                    {
                        //Wenn die Gesamtpunktzahl von Spieler 1 größer als die von Spieler 2 ist und beide Punktzahlen unter 21 liegen, gewinnt Spieler 1, oder wenn die Punkte des Spieler 2 über und die des Spieler 1 unter 21 sind 
                        Console.WriteLine("\nPlayer wins with a total of " + player1.total_points + " points!");
                    }
                    else if (player1.total_points < player2.total_points && player2.total_points <= 21 && player1.total_points < 21 || player1.total_points > 21 && player2.total_points <= 21)
                    {
                        //Wenn die Gesamtpunktzahl von Spieler 2 größer als die von Spieler 1 ist und beide Punktzahlen unter 21 liegen, gewinnt Spieler 2, oder wenn die Punkte des Spieler 1 über und die des Spieler 2 unter 21 sind 
                        Console.WriteLine("\nDealer wins with a total of " + player2.total_points + " points !");
                    }
                    //Wenn keine der oben genannten Bedingungen zutrieft, gewinnt kein Spieler
                    else
                    {
                        Console.WriteLine("\n Draw! Nobody wins!");
                    }
                    //Ende des ersten Case
                    break;
                //Wenn im string play "n" geschrieben wird, wird folgender Code ausgeführt und es findet kein Spiel statt                    
                case "n":
                    Console.WriteLine("\nWird beendet . . . ");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}