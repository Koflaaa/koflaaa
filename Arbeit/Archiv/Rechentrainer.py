import random

# Wiederhole die Eingabe, bis eine gültige ganze Zahl eingegeben wird
while True:
    eingabe = input("Wie oft möchten Sie das Programm 'Rechentrainer 1x1' ausführen lassen? ")
    if eingabe.isdigit():
        wiederholungszahl = int(eingabe)
        break
    else:
        print("Ungültige Eingabe! Bitte geben Sie eine ganze Zahl ein.")

# Initialisierung der Zählvariablen
index = 0
richtige_antworten = 0

# Hauptschleife für den Rechentrainer
while index < wiederholungszahl:
    # Zufällige Zahlen zwischen 1 und 11 generieren
    x = random.randint(1, 10)
    y = random.randint(1, 10)

    # Ausgabe der Rechenaufgabe
    print(f"{y} * {x} = ?")

    # Eingabe des Benutzers mit Fehlerbehandlung
    try:
        antwort = int(input("Geben Sie das Ergebnis der oben stehenden Rechnung ein: "))
    except ValueError:
        print("Ungültige Eingabe! Bitte geben Sie eine Zahl ein.")
        continue  # Aufgabe nicht zählen, sondern wiederholen

    # Überprüfung der Antwort
    if antwort == (x * y):
        print("Das ist korrekt!")
        richtige_antworten += 1
    else:
        print(f"Das ist leider falsch! Die richtige Antwort wäre: {x * y}")
    index += 1  # Nächste Aufgabe

# Zusammenfassung der Ergebnisse
print(f"\nGlückwunsch! Du hast von {wiederholungszahl} Fragen, {richtige_antworten}-mal richtig geantwortet!")


# Pseudocode:
# Starte das Programm
# Frage den Benutzer, wie oft das Programm wiederholt werden soll
#     → Wiederhole die Eingabe, bis eine gültige ganze Zahl eingegeben wurde

# Setze richtige_antworten = 0
# Für jede Wiederholung:
#     Generiere zwei Zufallszahlen zwischen 1 und 10
#     Stelle dem Benutzer eine Multiplikationsfrage
#     Lies die Antwort des Benutzers ein
#     Vergleiche Antwort mit dem korrekten Ergebnis
#     Wenn richtig → Erhöhe richtige_antworten
#     Sonst → Ausgabe der richtigen Lösung
# Am Ende:
#     Zeige dem Benutzer, wie viele Aufgaben er richtig gelöst hat

