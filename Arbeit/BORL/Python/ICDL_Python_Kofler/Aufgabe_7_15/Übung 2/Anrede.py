name = input("Geben Sie den Namen Ihres Empfängers an:")
sex = input("Geben Sie bitte das Geschlecht des Empfängers an (m/w/d):").lower()


while True:
    try:
        currentHour = int(input("Geben Sie bitte die jetztige Uhrzeit ein:(Bei z.B. 10:50 auf 11 aufrunden und bei z.B. 10:30 auf 10 abrunden)"))
    except:
        print("Keine korrekte Eingabe, bitte versuchen Sie es erneut.")
        continue

    if 0<=currentHour and currentHour<=9:
        if sex == 'm':
            print(f"Guten Morgen Herr {name}")
            break
        elif sex=='w':
            print(f"Guten Morgen Frau {name}")
            break
        else:
            print(f"Guten Morgen {name}")
            break
    elif 10<= currentHour and currentHour <= 17:
        if sex == 'm':
            print(f"Guten Tag Herr {name}")
            break
        elif sex=='w':
            print(f"Guten Tag Frau {name}")
            break
        else:
            print(f"Guten Tag {name}")
            break
    elif 18<= currentHour and currentHour<= 23:
        if sex == 'm':
            print(f"Guten Abend Herr {name}")
            break
        elif sex=='w':
            print(f"Guten Abend Frau {name}")
            break
        else:
            print(f"Guten Abend {name}")
            break
    else:
        print("Falsche Eingabe")
