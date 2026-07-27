# Importieren der Klassen aus den einzelnen Dateien

import bahnhof_class
import perron_class
import zug_class

# Hauptfunktion zum Ausführen der Beispiele
def main():
    bahnhof = bahnhof_class.Bahnhof()   # Instanzierung des Objekts Bahnhof
    bahnhof.add_zug("Zug 1")            # Hinzufügen eines Zuges
    bahnhof.add_waggon("8 Waggons")     # Hinzufügen von Waggons
    bahnhof.add_destination("Bern")     # Hinzufügen eines Ziels
    
    bahnhof.add_zug("Zug 2")            # Hinzufügen eines weiteren Zuges
    bahnhof.add_waggon("6 Waggons")     # Hinzufügen weiterer Waggons
    bahnhof.add_destination("Paris")    # Hinzufügen eines weiteren Ziels

    bahnhof.add_zug("Zug 3")            # Hinzufügen eines dritten Zuges
    bahnhof.add_waggon("10 Waggons")    # Hinzufügen von noch mehr Waggons
    bahnhof.add_destination("Rom")      # Hinzufügen eines dritten Ziels

    bahnhof.add_zug("Zug 4")            # Hinzufügen eines vierten Zuges
    bahnhof.add_waggon("12 Waggons")    # Hinzufügen von noch mehr Waggons
    bahnhof.add_destination("Wien")     # Hinzufügen eines vierten Ziels

    print("Anzahl Zuege im Bahnhof:", bahnhof.get_anzahl_zuege())           # Ausgabe der Anzahl der Züge im Bahnhof
    print("Anzahl Waggons im Bahnhof:", bahnhof.get_anzahl_waggons())       # Ausgabe der Anzahl der Waggons im Bahnhof
    print("Destinationsliste im Bahnhof:", bahnhof.get_destinations())      # Ausgabe der Destinationsliste im Bahnhof

    # Perron-Beispiel
    perron = perron_class.Perron()  # Instanzierung des Objekts Perron
    perron.add_perron("Perron 1")   # Hinzufügen eines Perrons
    perron.add_zug("Zug 4")         # Hinzufügen eines Zuges

    perron.add_perron("Perron 2")   # Hinzufügen eines weiteren Perrons
    perron.add_zug("Zug 3")         # Hinzufügen eines weiteren Zuges

    perron.add_perron("Perron 3")   # Hinzufügen eines dritten Perrons
    perron.add_zug("Zug 2")         # Hinzufügen eines dritten Zuges
    perron.add_zug("Zug 1")         # Hinzufügen eines vierten Zuges

    print("Anzahl Zuege auf dem Perron:", perron.get_anzahl_Zuege())                # Ausgabe der Anzahl der Züge auf dem Perron
    print("Anzahl Waggons auf dem Perron:", perron.get_anzahl_Waggons())            # Ausgabe der Anzahl der Waggons auf dem Perron
    print("Destinationsliste auf dem Perron:", perron.get_destinations_Liste())     # Ausgabe der Destinationsliste auf dem Perron

    # Zug-Beispiel
    zug = zug_class.Zug(destination="Destination Z", anzahlWaggons=5)   # Instanzierung des Objekts Zug
    print("Zug Destination:", zug.destination)                          # Ausgabe der Destination des Zuges
    print("Zug Anzahl Waggons:", zug.get_anzahl_Waggons())              # Ausgabe der Anzahl der Waggons des Zuges

if __name__ == "__main__":              # Ausführung der Hauptfunktion
    main()
