def main():
    # Eingabe und Konvertierung zu Integer
    zahl = int(input("Bitte eine ganze Zahl eingeben: ").strip())

    count = 0
    # Solange teilbar durch 5, weiter teilen
    while zahl % 5 == 0 and zahl != 0:
        zahl = zahl // 5   # ganzzahlige Division
        count += 1

    print(f" Die Zahl kann {count} mal durch 5 geteilt werden.")

if __name__ == "__main__":
    main()
