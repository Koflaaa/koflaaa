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
    print("Ungültiger Rechenoperator!")
