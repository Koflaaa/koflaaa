using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Blackjack_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Card> deck;         // Das Kartendeck
        private List<Card> playerHand;   // Hand des Spielers
        private List<Card> dealerHand;   // Hand des Dealers
        public Random random;            // Für Zufallszahlen (zum Mischen)

        // Konstruktor – wird beim Start des Fensters ausgeführt
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            StartNewGame();  // Startet ein neues Spiel
        }

        // Setzt das Spiel zurück und startet ein neues
        private void StartNewGame()
        {
            deck = GenerateDeck();               // Neues Kartendeck erstellen
            playerHand = new List<Card>();       // Leere Spielerhand
            dealerHand = new List<Card>();       // Leere Dealerhand
            gameResult.Text = "";                // Ergebnisanzeige zurücksetzen
            DealInitialCards();                  // Anfangskarten austeilen
            UpdateUI();                          // Benutzeroberfläche aktualisieren
        }

        // Erstellt und mischt ein Kartendeck
        private List<Card> GenerateDeck()
        {
            var suits = new[] { "Herz", "Caro", "Pik", "Kreuz" };                                                           // Farben
            var values = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Bube", "Dame", "König", "Ass" };            // Kartenwerte
            var deck = new List<Card>();

            // Jede Kartenkombination wird erstellt
            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    deck.Add(new Card { Suit = suit, Value = value });
                }
            }

            // Mischen mit Zufallszahlen
            return deck.OrderBy(c => random.Next()).ToList();
        }

        // Teilt Spieler und Dealer je 2 Karten aus
        private void DealInitialCards()
        {
            playerHand.Add(DrawCard());
            playerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());
        }

        // Zieht die oberste Karte aus dem Deck
        private Card DrawCard()
        {
            var card = deck.First();
            deck.RemoveAt(0);  // Entfernt die gezogene Karte aus dem Deck
            return card;
        }

        // Klick auf "Hit" (Spieler will noch eine Karte)
        private void btnHit_Click(object sender, RoutedEventArgs e)
        {
            playerHand.Add(DrawCard());  // Spieler zieht eine Karte
            UpdateUI();                  // UI aktualisieren

            // Überprüfen ob jemand über 21 Punkte ist (verloren)
            if (CalculatePoints(playerHand) > 21)
            {
                gameResult.Text = "Dealer gewinnt!";
                DisableButtons();
            }
            else if (CalculatePoints(dealerHand) > 21)
            {
                gameResult.Text = "Spieler gewinnt!";
                DisableButtons();
            }
        }

        // Klick auf "Stand" (Spieler will keine Karte mehr)
        private void btnStand_Click(object sender, RoutedEventArgs e)
        {
            // Dealer zieht Karten bis er mindestens 18 Punkte hat
            while (CalculatePoints(dealerHand) < 18)
            {
                dealerHand.Add(DrawCard());
            }

            UpdateUI();          // UI aktualisieren
            DetermineWinner();   // Gewinner bestimmen
        }

        // Klick auf "Restart" – Spiel neu starten
        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            StartNewGame();   // Neues Spiel beginnen
            EnableButtons(); // Buttons aktivieren
        }

        // Aktualisiert Anzeige von Karten und Punktestand
        private void UpdateUI()
        {
            playerCards.ItemsSource = playerHand.Select(c => c.ToString());
            playerPoints.Text = CalculatePoints(playerHand).ToString();
            dealerCards.ItemsSource = dealerHand.Select(c => c.ToString());
            dealerPoints.Text = CalculatePoints(dealerHand).ToString();
        }

        // Berechnet Punkte einer Hand
        private int CalculatePoints(List<Card> hand)
        {
            int points = 0;   // Zählt normale Punkte
            int aceCount = 0; // Zählt Asse

            foreach (var card in hand)
            {
                if (int.TryParse(card.Value, out int value)) // Zahlenkarte
                {
                    points += value;
                }
                else if (card.Value == "Ass") // Ass zählt als 11
                {
                    points += 11;
                    aceCount++;
                }
                else // Bildkarten zählen als 10
                {
                    points += 10;
                }
            }

            // Wenn über 21 und es gibt Asse → zähle Ass als 1 statt 11
            while (points > 21 && aceCount > 0)
            {
                points -= 10;
                aceCount--;
            }

            return points;
        }

        // Vergleicht Punkte und zeigt den Gewinner an
        private void DetermineWinner()
        {
            int playerPoints = CalculatePoints(playerHand);
            int dealerPoints = CalculatePoints(dealerHand);

            if (dealerPoints > 21 || playerPoints > dealerPoints)
            {
                gameResult.Text = "Spieler gewinnt!";
            }
            else if (playerPoints < dealerPoints || dealerPoints == 21)
            {
                gameResult.Text = "Dealer gewinnt!";
            }
            else
            {
                gameResult.Text = "Unentschieden!";
            }

            DisableButtons(); // Keine weiteren Aktionen möglich
        }

        // Aktiviert die Buttons "Hit" und "Stand"
        private void EnableButtons()
        {
            btnHit.IsEnabled = true;
            btnStand.IsEnabled = true;
        }

        // Deaktiviert die Buttons "Hit" und "Stand"
        private void DisableButtons()
        {
            btnHit.IsEnabled = false;
            btnStand.IsEnabled = false;
        }

        // Repräsentiert eine einzelne Spielkarte
        public class Card
        {
            public string Suit { get; set; }  // Kartenfarbe (Herz, Pik usw.)
            public string Value { get; set; } // Kartenwert (2–10, Bildkarten, Ass)

            // Gibt den Kartennamen als lesbaren Text zurück
            public override string ToString()
            {
                return $"{Value} von {Suit}";
            }
        }
    }
}
