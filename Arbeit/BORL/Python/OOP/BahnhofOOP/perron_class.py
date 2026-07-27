from bahnhof_class import Bahnhof

class Perron(Bahnhof):                              # Definition der Klasse Perron, die von Bahnhof erbt
    def __init__(self):                             # Initialisierungsmethode
        super().__init__()                          # Aufruf der Initialisierungsmethode der Basisklasse
        self.perronListe = []                       # Initialisierung der Perron-Liste

    def add_perron(self, perron_name):              # Methode zum Hinzufügen eines Perrons
        self.perronListe.append(perron_name)        # Hinzufügen des Perrons zur Liste

    def get_anzahl_Zuege(self):                     # Methode zur Rückgabe der Anzahl der Züge
        return self.get_anzahl_zuege()              # Aufruf der Methode der Basisklasse

    def get_anzahl_Waggons(self):                   # Methode zur Rückgabe der Anzahl der Waggons
        return self.get_anzahl_waggons()            # Aufruf der Methode der Basisklasse

    def get_destinations_Liste(self):               # Methode zur Rückgabe der Destinationsliste
        return self.get_destinations()              # Aufruf der Methode der Basisklasse
