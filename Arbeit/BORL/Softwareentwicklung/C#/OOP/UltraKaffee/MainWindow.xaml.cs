using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UltraKaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int index = 0;
        public readonly int[,] verbrauch = new int[2, 4];
        public int[,] aktinhalt = new int[2, 4];
        public string[] maschine = { "Maschine A", "Maschine B" };
        public string[] status = { "Ok", "X" };
        public int[] leer = { 0, 1 };
        public MainWindow()
        {
            InitializeComponent();
            Parameters();
            leer[index] = 1;
            Aktualisierung();
        }

        private void Button_A_Click(object sender, RoutedEventArgs e)
        {
            index = 0;
            Aktualisierung();
        }
        private void Button_B_Click(object sender, RoutedEventArgs e)
        {
            index = 1;
            Aktualisierung();
        }
        private void Button_Fuellen_Click(object sender, RoutedEventArgs e)
        {
            Nachfüllen();
        }
        private void Button_Machen_Click(object sender, RoutedEventArgs e)
        {
            Machen();
        }

        public void Parameters()
        {
           for (int i = 0; i < 2; i++)
           {
                verbrauch[i, 0] = 12;       // Kaffee
                verbrauch[i, 1] = 200;      // Wasser
                verbrauch[i, 2] = 5;        // Zucker
                verbrauch[i, 3] = 15;       // Milch
           }
        }
        public void Nachfüllen()
        {
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
        {
            for (int i = 0; i < 2; i++)
            {
                aktinhalt[index, i] -= verbrauch[index, i];    // Kaffee, Wasser
            }
            if (this.Box_Zucker.IsChecked == true)
            {
                aktinhalt[index,2] -= verbrauch[index,2];
            }
            if (this.Box_Milch.IsChecked == true)
            {
                aktinhalt[index,3] -= verbrauch[index,3];
            }
            if (aktinhalt[index, 0] < verbrauch[index, 0])
            {
                leer[index] = 1;
            }
            Aktualisierung();
        }

        public void Aktualisierung()
        {
            this.Wahl.Content = maschine[index];
            this.Kaffee.Content = aktinhalt[index, 0];
            this.Wasser.Content = aktinhalt[index, 1];
            this.Zucker.Content = aktinhalt[index, 2];
            this.Milch.Content = aktinhalt[index, 3];
            this.MaschineStatus.Content = status[leer[index]];
            if (status[leer[index]] == "X")
            { 
                this.KMachen.IsEnabled = false;
            }
            else
            {
                this.KMachen.IsEnabled = true;
            }
        }
    }
}