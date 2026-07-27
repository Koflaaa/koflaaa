class Autor():      # Erstellen der Klasse Autor sammt Name
    def __init__(self, name:str):
        self.name = name

    def __str__(self):
        return f"{self.name}"