using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Game game = new();
            game.Start();
        }
    }

    class Game
    {
        public Deck deck;
        public Hand playerHand;
        public Hand dealerHand;

        public Game()
        {
            deck = new Deck();
            playerHand = new Hand();
            dealerHand = new Hand();
        }

        public void Start()
        {
            Console.WriteLine("Willkommen bei BlackJack!");
            deck.Shuffle();

            // Initial cards
            playerHand.AddCard(deck.DrawCard());
            playerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());

            PlayerTurn();
            DealerTurn();
            DetermineWinner();
        }

        private void PlayerTurn()
        {
            while (true)
            {
                Console.WriteLine($"\nSpielerhand: {playerHand}");
                Console.WriteLine($"Punktzahl: {playerHand.GetScore()}");

                if (playerHand.GetScore() > 21)
                {
                    Console.WriteLine("Spieler hat sich überkauft!");
                    return;
                }

                Console.WriteLine("Möchten Sie eine Karte ziehen? (j/n)");
                string input = Console.ReadLine();

                if (input.ToLower() == "j")
                {
                    playerHand.AddCard(deck.DrawCard());
                }
                else
                {
                    break;
                }
            }
        }

        private void DealerTurn()
        {
            Console.WriteLine($"\nDealerhand: {dealerHand}");
            Console.WriteLine($"Punktzahl: {dealerHand.GetScore()}");

            while (dealerHand.GetScore() < 17)
            {
                dealerHand.AddCard(deck.DrawCard());
                Console.WriteLine($"\nDealer zieht eine Karte: {dealerHand}");
                Console.WriteLine($"Punktzahl: {dealerHand.GetScore()}");

                if (dealerHand.GetScore() > 21)
                {
                    Console.WriteLine("Dealer hat sich überkauft!");
                    return;
                }
            }
        }

        private void DetermineWinner()
        {
            int playerScore = playerHand.GetScore();
            int dealerScore = dealerHand.GetScore();

            Console.WriteLine($"\nEndstand - Spieler: {playerScore}, Dealer: {dealerScore}");

            if (playerScore > 21)
            {
                Console.WriteLine("Dealer gewinnt!");
            }
            else if (dealerScore > 21 || playerScore > dealerScore)
            {
                Console.WriteLine("Spieler gewinnt!");
            }
            else if (playerScore < dealerScore)
            {
                Console.WriteLine("Dealer gewinnt!");
            }
            else
            {
                Console.WriteLine("Unentschieden!");
            }
        }
    }

    class Deck
    {
        public List<Card> cards;
        public Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            string[] suits = { "Herz", "Karo", "Pik", "Kreuz" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Bube", "Dame", "König", "Ass" };

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int randomIndex = random.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("Das Deck ist leer!");
            }

            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }
    }

    class Card
    {
        public string Suit { get; }
        public string Value { get; }

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public int GetCardValue()
        {
            if (int.TryParse(Value, out int numberValue))
            {
                return numberValue;
            }
            else if (Value == "Bube" || Value == "Dame" || Value == "König")
            {
                return 10;
            }
            else if (Value == "Ass")
            {
                return 11;
            }

            throw new InvalidOperationException("Ungültiger Kartenwert!");
        }

        public override string ToString()
        {
            return $"{Value} von {Suit}";
        }
    }

    class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int GetScore()
        {
            int score = 0;
            int aceCount = 0;

            foreach (Card card in cards)
            {
                score += card.GetCardValue();
                if (card.Value == "Ass")
                {
                    aceCount++;
                }
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        public override string ToString()
        {
            return string.Join(", ", cards);
        }
    }
}
