using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfelspiel
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int SpielerNummer = -1;      // -1 = Spieler1 u. 1 = Spieler2
        Spieler spieler1 = new Spieler("Spieler 1", 0);             // }  Setzt die Standartwerte für die jeweiligen Spieler
        Spieler spieler2 = new Spieler("Spieler 2", 0);             // }

        private void BoxSpieler1_Name_TextChanged(object sender, EventArgs e)
        {
            spieler1.Name = BoxSpieler1_Name.Text;          // Speichert den Namen der eingegeben wurde
        }

        private void Button_Würfel_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 7);             // Random Zahlen für die Würfel 1-6
            int b = rnd.Next(1, 7);

            switch (SpielerNummer)
            {
                case -1:                    // Spielernummer bzw. SpielerID um den aktuell spielenden Spieler abzufragen
                    label4.Text = "Würfelt: Spieler 1";
                    if (a == b)             // Überprüft ob beide zahlen gleich sind
                    {
                        spieler1.Punkte = 0;        // wenn ja dann werden alle Punkte des Spielers zurück gesetzt. Wegen der Paschregel
                    }
                    else if (a + b >= 6)            // Überprüft ob die a+b größer oder gleich 6 sind wenn ja werden dem Spieler die Punkte (die Summe von a+b) zu geschrieben
                    {
                        spieler1.Punkte += (a + b);
                    }
                    if (spieler1.Punkte >= 100)     //Sollte die Punkte Zahl eines Spielers 100 oder über 100 sein wird es auf 100 gesetzt. Im Anschluss wird eine Nachricht ausgegeben mit dem Gewinner
                    {
                        spieler1.Punkte = 100;
                        Gewinner(1);
                    }
                    BoxPunkte_1.Text = spieler1.Punkte.ToString();
                    BoxWürfel_1.Text = a.ToString();
                    BoxWürfel_2.Text = b.ToString();
                    SpielerNummer *= -1;
                    label4.Text = "Würfelt: Spieler 2";
                    break;
                case 1:
                    if (a == b)
                    {
                        spieler2.Punkte = 0;
                    }
                    else if (a + b >= 6)
                    {
                        spieler2.Punkte += (a + b);
                    }
                    if (spieler2.Punkte >= 100)
                    {
                        spieler2.Punkte = 100;
                        Gewinner(2);
                    }
                    BoxPunkte_2.Text = spieler2.Punkte.ToString();
                    BoxWürfel_1.Text = a.ToString();
                    BoxWürfel_2.Text = b.ToString();
                    SpielerNummer *= -1;
                    label4.Text = "Würfelt: Spieler 1";
                    break;

            }

        }

        public void Gewinner(int x)
        {
            MessageBox.Show($"Spieler Nr. {x.ToString()} hat gewonnen.");
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            spieler1.Punkte = 0;
            spieler2.Punkte = 0;
            SpielerNummer = -1;
            label4.Text = "Spieler 1";
            BoxPunkte_1.Text = "0";
            BoxPunkte_2.Text = "0";
            BoxWürfel_1.Text = "0";
            BoxWürfel_2.Text = "0";
        }
    }
    public class Spieler
    {
        public string Name { get; set; }
        public int Punkte { get; set; }

        public Spieler(string name, int punkte)
        {
            this.Name = name;
            this.Punkte = punkte;
        }

        public string getName()
        {
            return Name;
        }

        public int getPunkte()
        {
            return Punkte;
        }
    }
}
