numbers = (0, 10, 12, 4, 7, 20, 21, 13)
zahl = int(input("Geben Sie eine Zahl ein: "))

if zahl in numbers:
    position = numbers.index(zahl)
    print(f"Zahl ist an der {position}. Stelle des Tupels.")
else:
    print("Eingegebene Zahl ist nicht im Tupel vorhanden.")
