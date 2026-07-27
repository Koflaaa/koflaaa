def printit(toprint):
    print(toprint)

def getint():
    while True:
        try:
            a = int(input("Geben Sie eine Ganzzahl ein:\n"))
            return a
        except ValueError:
            print("Ungültige Eingabe. Bitte geben Sie eine Ganzzahl ein.")
            
def main():
    printit("Hallo Welt!")
    printit(getint())

if __name__ == "__main__":
    main()