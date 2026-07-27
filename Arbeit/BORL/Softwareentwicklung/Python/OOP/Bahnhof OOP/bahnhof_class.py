class Bahnhof:
    def __init__(self):
        self.anzahlZuege = [] # Liste mit den Anzahlen der Zügen
        self.anzahlWaggons = [] # Liste mit den Anzahl der Waggons
        self.destinationsListe = [] # Liste mit Anzahl der Ziele

    def get_anzahl_zuege(self): # Methode zum auslesen Züge
        return len(self.anzahlZuege)

    def get_anzahl_waggons(self):   # Methode zum auslesen der Waggons
        return len(self.anzahlWaggons)

    def get_destinations(self):     # Methode zum hinzufügen neuer Ziele
        return self.destinationsListe

    def add_zug(self, zug): # Methode zum hinzufügen neuer Züge
        self.anzahlZuege.append(zug)

    def add_waggon(self, waggon):
        self.anzahlWaggons.append(waggon)

    def add_destination(self, destination):
        self.destinationsListe.append(destination)  
