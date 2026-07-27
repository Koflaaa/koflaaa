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

namespace WPF_Taschenrechner_Kofler
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{	// Das Rechenprogramm nimmt nur 2 Nunmmer pro Rechnung
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click_0(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text +=  "0";										// Textfeld_Ergebnis.Text += "xy" lässt die ausgewählten Nummern in das Textfeld schreiben
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += "1";										// Hier zBsp. wird 1 hinzugefügt als Zahl im oberen Beispiel wird 0 hinzugefügt usw.
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += "2";										// das gleiche Passiert auch mit den +,-,* und / Operanten.
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text = Textfeld_Ergebnis.Text + "3";				// für 3, 4, 5, 6, 7, 8 und 9 passiert das gleiche wie bei Kommentar Zeile 35.
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += "4";
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += "5";
		}

		private void Button_Click_6(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += "6";
		}

		private void Button_Click_7(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += "7";
		}

		private void Button_Click_8(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += "8";
		}

		private void Button_Click_9(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += "9";
		}

		private void Button_Click_Gleich(object sender, RoutedEventArgs e)
		{
			try
			{
				string[] Result = Textfeld_Ergebnis.Text.Split(" ");					// Hier wird ein Array deklariert mit einer Funktion die ein Leerzeichen einfügt.
				double number1 = Convert.ToInt32(Result[0]);							// Hier werden die Rechennummern erstellt und gleich einen Wert zugewiesen.
				double number2 = Convert.ToInt32(Result[2]);							// Siehe Kommentar Zeile 83!

				string rechenzeichen = Result[1];										// Hier werden die Rechenoperatoren dem Arrayindex 1 zugewiesen.

				if (rechenzeichen == "+")												// Hier wird überprüft welcher Rechenoperator gebraucht bzw. ausgewählt wurde
				{
					double addResult = number1 + number2;								// Hier wird das Ergebnis ausgerechnet
					Textfeld_Ergebnis.Text = addResult.ToString();						// Ausgabe des Ergebnises in die Textbox
				}
				else if (rechenzeichen == "-")											// Siehe Kommentar Zeile 88!
				{
					double subResult = number1 - number2;								// Siehe Kommentar Zeile 90!
					Textfeld_Ergebnis.Text = subResult.ToString();						// Siehe Kommentar Zeile 91!
				}
				else if (rechenzeichen == "*")											// Siehe Kommentar Zeile 88!
				{
					double timesResult = number1 * number2;								// Siehe Kommentar Zeile 90!
					Textfeld_Ergebnis.Text = timesResult.ToString();					// Siehe Kommentar Zeile 91!
				}
				else if (rechenzeichen == "/")											// Siehe Kommentar Zeile 88!
				{
					if (number1 == 0 || number2 == 0)									// Hier wird überprüft ob eine mögliche Null-Division vorhanden ist
					{
						Textfeld_Ergebnis.Text = "Devided by 0 Error";					// Falls ja, wird eine Error-Message ausgeschrieben
					}
					else
					{
						double devidedResult = number1 / number2;						// Falls nicht, wird das Ergebnis normal berechnet
						Textfeld_Ergebnis.Text = devidedResult.ToString();				// und ausgegeben
					}
				}
			}
			catch(Exception)
			{
				Textfeld_Ergebnis.Text = "Error, Wert zu groß";							// Sollte es über den normalen int-Wert schlagen wird eine Error-message ausgegeben
			}
		}
		// Hier werden die Rechenoperatoren in die Textbox ausgeschrieben
		private void Button_Click_Plus(object sender, RoutedEventArgs e)					
		{
			Textfeld_Ergebnis.Text += " + ";
		}

		private void Button_Click_Minus(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += " - ";
		}

		private void Button_Click_Mal(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += " * ";
		}

		private void Button_Click_Durch(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text += " / ";
		}
		// Hier wird die "Clear (C) Funktion erstellt.
		private void Button_Click_C(object sender, RoutedEventArgs e)
		{
			Textfeld_Ergebnis.Text = "";												// Hier wird sobald der Button "C" gedrückt wird ein Leerzeichen eingfefügt das alle vorhandenen Werte ersetzt
		}

		private void Button_Click_ESC(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);														// Hier wird sobald der Button "ESC" gedrückt wird das Eviroment also die Umgebung geschlossen.
		}
	}
}
