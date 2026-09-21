import sqlite3

# Verbindung zur SQLite-Datenbank herstellen
conn = sqlite3.connect('reisen_kofler.db')
cursor = conn.cursor()

# Tabellen erstellen (falls sie noch nicht existieren)
cursor.execute('''
    CREATE TABLE IF NOT EXISTS Personal (
        Personalnummer INTEGER PRIMARY KEY AUTOINCREMENT,
        Nachname varchar(100) NOT NULL,
        Vorname varchar(100) NOT NULL,
        Straße varchar(255) NOT NULL,
        PLZ varchar(12) NOT NULL,
        Ort varchar(100) NOT NULL
    );
''')

cursor.execute('''
    CREATE TABLE IF NOT EXISTS Reise (
        Rechnungsnummer INTEGER PRIMARY KEY AUTOINCREMENT,
        Datum date NOT NULL,
        Personalnummer int,
        FOREIGN KEY (Personalnummer) REFERENCES Personal(Personalnummer)
    );
''')

# Funktion zum Einfügen eines Datensatzes in die Personal-Tabelle
def insert_personal(nachname, vorname, strasse, plz, ort):
    try:
        cursor.execute('''
            INSERT INTO Personal (Nachname, Vorname, Straße, PLZ, Ort)
            VALUES (?, ?, ?, ?, ?);
        ''', (nachname, vorname, strasse, plz, ort))
        conn.commit()
        print("Datensatz erfolgreich eingefügt.")
    except sqlite3.Error as e:
        print(f"Error: {e}")

# Funktion zum Einfügen eines Datensatzes in die Reise-Tabelle
def insert_reise(datum, personalnummer):
    try:
        cursor.execute('''
            INSERT INTO Reise (Datum, Personalnummer)
            VALUES (?, ?);
        ''', (datum, personalnummer))
        conn.commit()
        print("Reisedatensatz erfolgreich eingefügt.")
    except sqlite3.Error as e:
        print(f"Error: {e}")

# Funktion zum Auslesen der Personal-Daten
def read_personal():
    try:
        cursor.execute('SELECT * FROM Personal')
        rows = cursor.fetchall()
        for row in rows:
            print(row)
    except sqlite3.Error as e:
        print(f"Error: {e}")

# Funktion zum Auslesen der Reise-Daten
def read_reise():
    try:
        cursor.execute('SELECT * FROM Reise')
        rows = cursor.fetchall()
        for row in rows:
            print(row)
    except sqlite3.Error as e:
        print(f"Error: {e}")

# Funktion zum Löschen eines Datensatzes aus der Personal-Tabelle
def delete_personal(personalnummer):
    try:
        cursor.execute('''
            DELETE FROM Personal WHERE Personalnummer = ?;
        ''', (personalnummer,))
        conn.commit()
        print("Datensatz erfolgreich gelöscht.")
    except sqlite3.Error as e:
        print(f"Error: {e}")

# Funktion zum Bearbeiten eines Datensatzes in der Personal-Tabelle
def update_personal(personalnummer, nachname, vorname, strasse, plz, ort):
    try:
        cursor.execute('''
            UPDATE Personal 
            SET Nachname = ?, Vorname = ?, Straße = ?, PLZ = ?, Ort = ?
            WHERE Personalnummer = ?;
        ''', (nachname, vorname, strasse, plz, ort, personalnummer))
        conn.commit()
        print("Datensatz erfolgreich bearbeitet.")
    except sqlite3.Error as e:
        print(f"Error: {e}")

# Interaktives Menü für den Benutzer
def menu():
    while True:
        print("\nWählen Sie eine Option:")
        print("1. Neuen Personal-Datensatz hinzufügen")
        print("2. Neuen Reise-Datensatz hinzufügen")
        print("3. Personal-Daten anzeigen")
        print("4. Reise-Daten anzeigen")
        print("5. Personal-Datensatz löschen")
        print("6. Personal-Datensatz bearbeiten")
        print("7. Beenden")
        
        option = input("Ihre Wahl: ")
        
        if option == '1':
            nachname = input("Nachname: ")
            vorname = input("Vorname: ")
            strasse = input("Straße: ")
            plz = input("PLZ: ")
            ort = input("Ort: ")
            insert_personal(nachname, vorname, strasse, plz, ort)
        
        elif option == '2':
            datum = input("Reisedatum (YYYY-MM-DD): ")
            personalnummer = int(input("Personalnummer: "))
            insert_reise(datum, personalnummer)
        
        elif option == '3':
            print("\nPersonal-Daten:")
            read_personal()
        
        elif option == '4':
            print("\nReise-Daten:")
            read_reise()
        
        elif option == '5':
            personalnummer = int(input("Personalnummer des zu löschenden Datensatzes: "))
            delete_personal(personalnummer)
        
        elif option == '6':
            personalnummer = int(input("Personalnummer des zu bearbeitenden Datensatzes: "))
            nachname = input("Neuer Nachname: ")
            vorname = input("Neuer Vorname: ")
            strasse = input("Neue Straße: ")
            plz = input("Neue PLZ: ")
            ort = input("Neuer Ort: ")
            update_personal(personalnummer, nachname, vorname, strasse, plz, ort)
        
        elif option == '7':
            print("Programm beendet.")
            break
        
        else:
            print("Ungültige Eingabe, bitte versuchen Sie es erneut.")

# Menü starten
menu()

# Verbindung schließen
conn.close()
