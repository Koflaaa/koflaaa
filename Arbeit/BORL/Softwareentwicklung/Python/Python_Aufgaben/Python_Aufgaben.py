class Python_Aufgaben():
    
    def fehler1():
        name = input("Name eingeben\n")
        nachname = input("Nachname eingeben\n")
        fullname = name + ' ' + nachname
        age = input("Alter eingeben\n")
        print(fullname + ' ist ' + age + ' Jahre alt!')
        
    ############################################################################################################
    def Taschenrechner():
        zahl1 = 0
        zahl2 = 0
        op = ''
        summe = 0
        print("Geben Sie die erste Zahl ein:")
        zahl1 = float(input())
        print("Geben Sie die zweite Zahl ein:")
        zahl2 = float(input())
        print("Geben Sie den Rechenoperator ein:")
        op = input()

        if op == '+':
            summe = zahl1+zahl2
            print("Summe von Zahl 1 und Zahl 2 ist ", summe),
        elif op == '-':
            summe = zahl1 - zahl2
            print("Die Differenz von Zahl 1 und Zahl 2 ist ", summe),
        elif op == '*':
            summe = zahl1*zahl2
            print("Das Produkt von Zahl 1 und Zahl 2 ist ", summe),
        elif op == '/':
            if zahl1 == 0 or zahl2 == 0:
                print("Kann nicht durch 0 dividieren!"),
            else:
                summe = zahl1/zahl2
                print("Der Quotient von Zahl 1 und Zahl 2 ist ", summe),
        else:
            print("Ung�ltiger Rechenoperator!")
    ############################################################################################################
    def fehler2():
        def printit(toprint):
            print(toprint)

        def getint():
            a = int(input("Gib eine Ganzzahl ein:\n"))
            return a

        def main():
            printit("Hallo Welt!")
            printit(getint())

        if __name__ == "__main__":
            main()
    ############################################################################################################
    def steuerrechner():
        gehalt_brutto, gehalt_netto, steuersatz = 0, 0, 0

        print("Geben Sie Ihr Brutto Jahresgehalt ein:")
        gehalt_brutto = float(input())

        if gehalt_brutto <= 11000:
            steuersatz = 0
            gehalt_netto = gehalt_brutto
            print("Ihr neues Gehalt: ", gehalt_netto, ". Sie zahlen aktuell keine Lohnsteuer."),
        elif gehalt_brutto > 11000 and gehalt_brutto <= 18000:
            steuersatz = 0.25
            gehalt_netto = gehalt_brutto * (1 - steuersatz)
            print("Ihr neues Gehalt: ", gehalt_netto, ". Sie zahlen aktuell 25 Prozent Lohnsteuer."), 
        elif gehalt_brutto > 18000 and gehalt_brutto <= 25000:
            steuersatz = 0.35
            gehalt_netto = gehalt_brutto * (1 - steuersatz)
            print("Ihr neues Gehalt: ", gehalt_netto, ". Sie zahlen aktuell 35 Prozent Lohnsteuer."),
        elif gehalt_brutto > 25000 and gehalt_brutto <= 31000:
            steuersatz = 0.35
            gehalt_netto = gehalt_brutto * (1 - steuersatz)
            print("Ihr neues Gehalt: ", gehalt_netto, ". Sie zahlen aktuell 35 Prozent Lohnsteuer."),
        elif gehalt_brutto > 31000 and gehalt_brutto <= 60000:
            steuersatz = 0.42
            gehalt_netto = gehalt_brutto * (1 - steuersatz)
            print("Ihr neues Gehalt: ", gehalt_netto, ". Sie zahlen aktuell 42 Prozent Lohnsteuer."),
        elif gehalt_brutto > 60000 <= 90000:
            steuersatz = 0.48
            gehalt_netto = gehalt_brutto * (1 - steuersatz)
            print("Ihr neues Gehalt: ", gehalt_netto, ". Sie zahlen aktuell 48 Prozent Lohnsteuer."),
        elif gehalt_brutto > 90000 and gehalt_brutto <= 1000000:
            steuersatz = 0.50
            gehalt_netto = gehalt_brutto * (1 - steuersatz)
            print("Ihr neues Gehalt: ", gehalt_netto, ". Sie zahlen aktuell 50 Prozent Lohnsteuer."),
        elif gehalt_brutto > 1000000:
            steuersatz = 0.55
            gehalt_netto = gehalt_brutto * (1 - steuersatz)
            print("Ihr neues Gehalt: ", gehalt_netto, ". Sie zahlen aktuell 55 Prozent Lohnsteuer.")

    ############################################################################################################

    def string1():
        # Satzzeichen: '''!()-[]|{};:'"\,<>./?@#$%^&*_~'''
        # Satz: �Hallo!!?, sagte sie und � und? Ging < nach Hause >-allein| oder |nicht~?�

        #neuer Satz
        print("Hallo sagt sie und und Ging nach allein oder nicht")

    ############################################################################################################
        
    def string1_2():
        str1 = "Hello"
        str2 = "World"

        # Aufgabe: schreibe "Hello World" aus und verwende str1 und 2 daf�r

        print(str1 + str2)
    ############################################################################################################
        
    def string1_3():
        str1 = "Hello"
        str2 = "World"
        str3 = str1 + str2 * 3

        # Aufgabe: schreibe "Hello World" 3x aus und verwende str1, str2 und eine for-schleife

        for x in range(3):
            print(str3)

    ############################################################################################################

    def string1_4():
        print("Geben Sie eine Zahl ein.")
        zahl = input()
        print("Sammy has " + format(zahl) + " balons!")
        
    string1_4()