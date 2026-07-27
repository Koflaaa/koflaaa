class Zug:  # Definition der Klasse Zug
    def __init__(self, destination="", anzahlWaggons=0): # Initialisierungsmethode mit Parametern
        self.destination = destination # Zuweisung der Destination
        self.anzahlWaggons = anzahlWaggons # Zuweisung der Anzahl der Waggons

    def get_anzahl_Waggons(self): # Methode zur Rückgabe der Anzahl der Waggons
        return self.anzahlWaggons
