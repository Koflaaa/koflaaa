class Buch:         # Erstellen der Klasse Buch sammt Attributen
    def __init__(self, titel, autor, genre, seiten):
        self.titel = titel
        self.autor = autor
        self.genre = genre
        self.seiten = seiten

    def __str__(self):
        return f"{self.titel} von {self.autor.name} ({self.genre.name})"
