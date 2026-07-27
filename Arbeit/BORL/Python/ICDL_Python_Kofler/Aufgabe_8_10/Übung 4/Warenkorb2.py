import time

waren = {}

while True:
    choice = input("Wählen Sie eine Aktion aus (1,2 oder 3):\n 1: Einkaufen\n 2: Waren im Warenkorb bestellen\n 3: Bestellung abbrechen\nZum beenden des Programmes, geben Sie bitte 'exit' ein\nEingabe: ")
    if choice == "1":
         while True:
            item = input("Geben Sie eine Ware ein (oder 'exit' zum Beenden): ")
            if item.lower() == "exit":
                continue
            waren.append(item)
            print("Ware wurde hinzugefügt. Insgesamte Waren im Warenkorb")
            choice2 = input("Möchte Sie weitere Waren zu Ihrem Warenkorb hinzufügen? (Y/N)")
            if choice2.lower() == 'y':
                continue
            elif choice2.lower() == 'n':
                break;
            else:
                print("Ungültige Eingabe, bitte geben Sie eine valide Antwort ein.")
                continue
    elif choice == "2":
        print("Waren im Warenkorb:")
        for i in range(len(waren)):
            print(f"\n{i+1}. {waren[i]}")
        print("Waren im Waren wurden zur Bestellung aufgegeben.\n")
        time.sleep(3)
        continue
    elif choice == "3":
        print("Bestellung wurde storniert.\n")
        time.sleep(3)
        continue
    elif choice == 'exit':
        print("Programm wird beendet . . .\n")
        time.sleep(3)
        break
    else:
        print("Eingabe nicht korrekt. Bitte geben Sie einer der drei Optionen (1,2 oder 3) ein.\n")
        continue
