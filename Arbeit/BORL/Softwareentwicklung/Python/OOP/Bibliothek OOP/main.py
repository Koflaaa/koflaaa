from bibliothek_class import Bibliothek
from autor_class import Autor
from genre_class import Genre
from buch_class import Buch


def main():
    bib = Bibliothek("bibliothek.db")
    bib.create_tables()

    # Eingaben
    titel = input("Buchtitel: ").strip()
    autor = Autor(input("Autor-Name: ").strip())
    genre = Genre(input("Genre-Name: ").strip())

    while True:
      eingabe = input("Anzahl Seiten: ")
      if eingabe.isdigit():
          seiten = int(eingabe)
          break
      else:
          print("Bitte eine gültige Zahl eingeben.")


    # Objekt erstellen (optional, aber sauber)
    buch = Buch(titel=titel, autor=autor, genre=genre, seiten=seiten)

    # In DB speichern
    buch_id = bib.add_buch(
        buch.titel,
        buch.autor.name,
        buch.genre.name,
        buch.seiten
    )
    print("Neues Buch angelegt mit ID:", buch_id)

    # Beispiel: genau dieses Buch wieder löschen (Test)
    # geloescht = bib.delete_buch(buch_id)
    # bib.delete_autor(2)
    # bib.delete_genre(2)
    # print(f"Buch mit ID {buch_id} gelöscht {geloescht}")

    print("\nAutoren:", bib.get_autoren())
    print("Genres:", bib.get_genres())
    print("Bücher:", bib.get_buecher())


if __name__ == "__main__":
    main()
