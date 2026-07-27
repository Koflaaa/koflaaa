using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace UltraKaffee_V2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int index = 0;                                           //  Index zur Auswahl der Kaffeemaschinen
        public readonly int[,] verbrauch = new int[2, 4];               //  2d-Array zum Speichern der absoluten Verbrauchswerte
        public int[,] aktinhalt = new int[2, 4];                        //  2d-Array zum Speichern aktueller Maschinen Inhalte
        public string[] maschine = { "Maschine A", "Maschine B" };      //  Speichern der Namen zum Anzegien bei Maschinenauswahl
        public string[] status = { "Ok", "X" };                         //  Speichern Text für Status
        public int[] leer = { 0, 1 };                                   //  Array für Status abfrage
        public MainWindow()
        {
            InitializeComponent();
            // Aufrufen und setzten der ersten Methoden
            Parameters();
            leer[index] = 1;
            Aktualisierung();
        }

        private void Button_Fuellen_Click(object sender, RoutedEventArgs e)
        {   // Aufruf Methode zum Ressourcen Nachfüllen
            Nachfüllen();
        }

        private void Button_Machen_Click(object sender, RoutedEventArgs e)
        {   //  Aufruf Methode zum Machen von Kaffee
            Machen();
        }

        private void Kaufen_Click(object sender, RoutedEventArgs e)
        {   
            // Auffüllen des Kaffees
            int refillAmount = (index == 0) ? verbrauch[index, 0] * 20 : verbrauch[index, 0] * 30;
            aktinhalt[index, 0] = refillAmount;
            Aktualisierung();
        }

        private void Ausgleichen_Click(object sender, RoutedEventArgs e)
        {   // Methode zum Ausgleichen der Maschinen Ressourcen
            for (int i = 0; i < 4; i++)
            {
                int totalSources = aktinhalt[0, i] + aktinhalt[1, i];
                int equalSource = totalSources / 2;

                aktinhalt[0, i] = equalSource;
                aktinhalt[1, i] = equalSource;
            }
            Aktualisierung();
        }

        private void Button_A_Click(object sender, RoutedEventArgs e)
        {   //  Auswahl Maschine A, setzten des Indexes
            index = 0;
            Aktualisierung();
        }

        private void Button_B_Click(object sender, RoutedEventArgs e)
        {   //  Auswahl Maschine B, setzten des Indexes
            index = 1;
            Aktualisierung();
        }
        public void Parameters()
        {   //  Setzten der Verbrauchswerte
            for (int i = 0; i < 2; i++)
            {
                verbrauch[i, 0] = 12;       // Kaffee
                verbrauch[i, 1] = 200;      // Wasser
                verbrauch[i, 2] = 5;        // Zucker
                verbrauch[i, 3] = 15;       // Milch
            }
        }
        public void Nachfüllen()
        {   // Methode zum Nachfüllen der Ressourcen
            if (index == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    aktinhalt[index, i] = verbrauch[index, i] * 20;   // Kaffee, Wasser
                }
            }
            else if (index == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    aktinhalt[index, i] = verbrauch[index, i] * 30;
                }
            }
            this.MaschineStatus.Content = status[index];
            leer[index] = 0;
            Aktualisierung();
        }

        public void Machen()
        {   //  Methode zum Kaffee  machen
            for (int i = 0; i < 2; i++)
            {
                aktinhalt[index, i] -= verbrauch[index, i];    // Kaffee, Wasser
            }
            if (this.Box_Zucker.IsChecked == true)
            {
                aktinhalt[index, 2] -= verbrauch[index, 2];
            }
            if (this.Box_Milch.IsChecked == true)
            {
                aktinhalt[index, 3] -= verbrauch[index, 3];
            }
            if (aktinhalt[index, 0] < verbrauch[index, 0])
            {
                leer[index] = 1;
            }
            Aktualisierung();
        }

        public void Aktualisierung()
        {   // Aktualisierung von Inhalten
            this.Wahl.Content = maschine[index];
            this.Kaffee.Content = aktinhalt[index, 0];
            this.Wasser.Content = aktinhalt[index, 1];
            this.Zucker.Content = aktinhalt[index, 2];
            this.Milch.Content = aktinhalt[index, 3];
            this.MaschineStatus.Content = status[leer[index]];
            if (status[leer[index]] == "X")
            {   //  Abfrage ob eine der Ressourcen leer ist. Wenn ja, wird der Knopf zum Kaffee machen deaktiviert
                this.KMachen.IsEnabled = false;
            }
            else
            {   //  Wenn nicht, bleibt der Knopf aktiv
                this.KMachen.IsEnabled = true;
            }
        }
    }
}