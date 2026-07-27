using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Bibliothek_WPF
{
    public partial class MainWindow : Window
    {
        private Bibliothek bibliothek;

        public MainWindow()
        {
            InitializeComponent();
            bibliothek = new Bibliothek();
            LoadData(); // Daten beim Laden der Anwendung laden
        }

        // Laden der gespeicherten Daten in die Bibliothek
        private void LoadData()
        {
            // Bestehende Daten in der Bibliothek löschen
            bibliothek.Buecher.Clear();
            bibliothek.Verlage.Clear();
            bibliothek.Autoren.Clear();
            bibliothek.Orte.Clear();

            // Daten aus der Datei laden
            FileHelper.LoadFromFile(bibliothek);

            // UI aktualisieren
            RefreshUI();
        }

        // Aktualisierung der Benutzeroberfläche mit den aktuellen Daten
        private void RefreshUI()
        {
            // Bücher Liste aktualisieren
            BuecherListBox.ItemsSource = null; // Existierende Elemente löschen
            BuecherListBox.ItemsSource = bibliothek.Buecher;

            // Verlage Liste aktualisieren
            VerlageListBox.ItemsSource = null; // Existierende Elemente löschen
            VerlageListBox.ItemsSource = bibliothek.Verlage;

            // Autoren Liste aktualisieren
            AutorenListBox.ItemsSource = null; // Existierende Elemente löschen
            AutorenListBox.ItemsSource = bibliothek.Autoren;

            // Orte Liste aktualisieren
            OrteListBox.ItemsSource = null; // Existierende Elemente löschen
            OrteListBox.ItemsSource = bibliothek.Orte;
        }

        // Event Handler für das Hinzufügen eines Buchs
        private void AddBuch_Click(object sender, RoutedEventArgs e)
        {
            string titel = BuchTitelTextBox.Text;
            if (int.TryParse(BuchSeitenTextBox.Text, out int seiten))
            {
                Buch buch = new Buch { Titel = titel, Seiten = seiten };
                bibliothek.AddBuch(buch); // Buch zur Bibliothek hinzufügen
                FileHelper.SaveToFile(bibliothek); // Daten in Datei speichern
                RefreshUI(); // Benutzeroberfläche aktualisieren
                MessageBox.Show("Buch hinzugefügt!");
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Seitenanzahl ein.");
            }
        }

        // Event Handler für das Löschen eines Buchs
        private void DeleteBuch_Click(object sender, RoutedEventArgs e)
        {
            if (BuecherListBox.SelectedItem is Buch selectedBuch)
            {
                bibliothek.Buecher.Remove(selectedBuch); // Buch aus der Bibliothek entfernen
                FileHelper.SaveToFile(bibliothek); // Daten in Datei speichern
                RefreshUI(); // Benutzeroberfläche aktualisieren
                MessageBox.Show("Buch gelöscht!");
            }
        }

        // Event Handler für das Hinzufügen eines Verlags
        private void AddVerlag_Click(object sender, RoutedEventArgs e)
        {
            string name = VerlagNameTextBox.Text;
            Verlag verlag = new Verlag { Name = name };
            bibliothek.AddVerlag(verlag); // Verlag zur Bibliothek hinzufügen
            FileHelper.SaveToFile(bibliothek); // Daten in Datei speichern
            RefreshUI(); // Benutzeroberfläche aktualisieren
            MessageBox.Show("Verlag hinzugefügt!");
        }

        // Event Handler für das Löschen eines Verlags
        private void DeleteVerlag_Click(object sender, RoutedEventArgs e)
        {
            if (VerlageListBox.SelectedItem is Verlag selectedVerlag)
            {
                bibliothek.Verlage.Remove(selectedVerlag); // Verlag aus der Bibliothek entfernen
                FileHelper.SaveToFile(bibliothek); // Daten in Datei speichern
                RefreshUI(); // Benutzeroberfläche aktualisieren
                MessageBox.Show("Verlag gelöscht!");
            }
        }

        // Event Handler für das Hinzufügen eines Autors
        private void AddAutor_Click(object sender, RoutedEventArgs e)
        {
            string name = AutorNameTextBox.Text;
            Autor autor = new Autor { Name = name };
            bibliothek.AddAutor(autor); // Autor zur Bibliothek hinzufügen
            FileHelper.SaveToFile(bibliothek); // Daten in Datei speichern
            RefreshUI(); // Benutzeroberfläche aktualisieren
            MessageBox.Show("Autor hinzugefügt!");
        }

        // Event Handler für das Löschen eines Autors
        private void DeleteAutor_Click(object sender, RoutedEventArgs e)
        {
            if (AutorenListBox.SelectedItem is Autor selectedAutor)
            {
                bibliothek.Autoren.Remove(selectedAutor); // Autor aus der Bibliothek entfernen
                FileHelper.SaveToFile(bibliothek); // Daten in Datei speichern
                RefreshUI(); // Benutzeroberfläche aktualisieren
                MessageBox.Show("Autor gelöscht!");
            }
        }

        // Event Handler für das Hinzufügen eines Orts
        private void AddOrt_Click(object sender, RoutedEventArgs e)
        {
            string name = OrtNameTextBox.Text;
            Ort ort = new Ort { Name = name };
            bibliothek.AddOrt(ort); // Ort zur Bibliothek hinzufügen
            FileHelper.SaveToFile(bibliothek); // Daten in Datei speichern
            RefreshUI(); // Benutzeroberfläche aktualisieren
            MessageBox.Show("Ort hinzugefügt!");
        }

        // Event Handler für das Löschen eines Orts
        private void DeleteOrt_Click(object sender, RoutedEventArgs e)
        {
            if (OrteListBox.SelectedItem is Ort selectedOrt)
            {
                bibliothek.Orte.Remove(selectedOrt); // Ort aus der Bibliothek entfernen
                FileHelper.SaveToFile(bibliothek); // Daten in Datei speichern
                RefreshUI(); // Benutzeroberfläche aktualisieren
                MessageBox.Show("Ort gelöscht!");
            }
        }

        // Event Handler zur Berechnung der Gesamtseitenzahl aller Bücher
        private void CalculateTotalPages_Click(object sender, RoutedEventArgs e)
        {
            int totalPages = bibliothek.Buecher.Sum(b => b.Seiten); // Summe der Seiten aller Bücher berechnen
            MessageBox.Show($"Gesamtseitenzahl aller Bücher: {totalPages}");
        }

        // Event Handler zum Löschen des Standardtextes in Textboxen beim Fokus
        private void ClearTextOnFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = string.Empty;
                textBox.GotFocus -= ClearTextOnFocus; // Event Handler entfernen, damit Text nur einmal gelöscht wird
            }
        }
    }
}
