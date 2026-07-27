using System;
using System.Collections.Generic;

namespace BlackJack
{
	class Program
	{
		static void Main()
		{
			// Erstellung eines neuen Spiels und Starten des Spiels
			Game game = new();
			game.Start();
		}
	}

	// Klasse, die das Spiel BlackJack repräsentiert
	class Game
	{
		// Erstellung von Instanzen für das Deck und die Hände des Spielers und des Dealers
		public Deck deck;
		public Hand playerHand;
		public Hand dealerHand;

		public Game()
		{
			// Initialisieren der Instanzen
			deck = new Deck();
			playerHand = new Hand();
			dealerHand = new Hand();
		}

		// Starten des Spiels
		public void Start()
		{
			Console.WriteLine("Willkommen bei BlackJack!");
			// Mischen des Decks
			deck.Shuffle();

			// Spieler und Dealer ziehen jeweils zwei Karten
			playerHand.AddCard(deck.DrawCard());
			playerHand.AddCard(deck.DrawCard());
			dealerHand.AddCard(deck.DrawCard());
			dealerHand.AddCard(deck.DrawCard());

			// Durchführung der Züge des Spielers und des Dealers
			PlayerTurn();
			DealerTurn();

			// Ermittlung des Gewinners
			DetermineWinner();
		}

		// Durchführung des Spielzugs des Spielers
		private void PlayerTurn()
		{
			while (true)
			{
				// Anzeige der aktuellen Hand und Punktzahl des Spielers
				Console.WriteLine($"\nSpielerhand: {playerHand}");
				Console.WriteLine($"Punktzahl: {playerHand.GetScore()}");

				// Überprüfen, ob der Spieler sich überkauft hat
				if (playerHand.GetScore() > 21)
				{
					Console.WriteLine("Spieler hat sich überkauft!");
					return;
				}

				// Abfrage, ob der Spieler eine weitere Karte ziehen möchte
				Console.WriteLine("Möchten Sie eine Karte ziehen? (j/n)");
				string input = Console.ReadLine();

				// Spieler zieht eine weitere Karte oder beendet seinen Zug
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

		// Durchführung des Spielzugs des Dealers
		private void DealerTurn()
		{
			Console.WriteLine($"\nDealerhand: {dealerHand}");
			Console.WriteLine($"Punktzahl: {dealerHand.GetScore()}");

			// Dealer zieht Karten bis er mindestens 17 Punkte hat
			while (dealerHand.GetScore() < 17)
			{
				dealerHand.AddCard(deck.DrawCard());
				Console.WriteLine($"\nDealer zieht eine Karte: {dealerHand}");
				Console.WriteLine($"Punktzahl: {dealerHand.GetScore()}");

				// Überprüfen, ob der Dealer sich überkauft hat
				if (dealerHand.GetScore() > 21)
				{
					Console.WriteLine("Dealer hat sich überkauft!");
					return;
				}
			}
		}

		// Ermittlung des Gewinners
		private void DetermineWinner()
		{
			int playerScore = playerHand.GetScore();
			int dealerScore = dealerHand.GetScore();

			Console.WriteLine($"\nEndstand - Spieler: {playerScore}, Dealer: {dealerScore}");

			// Ausgabe des Ergebnisses
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

	// Klasse, die ein Kartendeck repräsentiert
	class Deck
	{
		public List<Card> cards;
		public Random random;

		public Deck()
		{
			// Initialisieren des Decks und der Zufallsgenerator-Instanz
			cards = new List<Card>();
			random = new Random();
			InitializeDeck();
		}

		// Initialisieren des Decks mit 52 Karten
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

		// Mischen des Decks
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

		// Ziehen einer Karte vom Deck
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

	// Klasse, die eine Karte repräsentiert
	class Card
	{
		public string Suit { get; }
		public string Value { get; }

		public Card(string suit, string value)
		{
			Suit = suit;
			Value = value;
		}

		// Ermittlung des Punktwerts einer Karte
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

		// Überschreiben der ToString-Methode zur besseren Ausgabe der Karte
		public override string ToString()
		{
			return $"{Value} von {Suit}";
		}
	}

	// Klasse, die die Hand eines Spielers oder Dealers repräsentiert
	class Hand
	{
		private List<Card> cards;

		public Hand()
		{
			cards = new List<Card>();
		}

		// Hinzufügen einer Karte zur Hand
		public void AddCard(Card card)
		{
			cards.Add(card);
		}

		// Berechnung der Punktzahl der Hand
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

			// Anpassen der Punktzahl, wenn ein Ass über 21 Punkte führen würde
			while (score > 21 && aceCount > 0)
			{
				score -= 10;
				aceCount--;
			}

			return score;
		}

		// Überschreiben der ToString-Methode zur besseren Ausgabe der Hand
		public override string ToString()
		{
			return string.Join(", ", cards);
		}
	}
}
