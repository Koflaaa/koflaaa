n = int(input("Bis zu welcher Zahl sollen die Primzahlen ermittelt werden? "))

# Schritt 1: Liste mit Zahlen von 1 bis n aufbauen
zahlen = []
for i in range(1, n + 1):
    zahlen.append(i)

# Schritt 2: Sieb des Eratosthenes anwenden
p = 2  # Start mit der ersten Primzahl
while p * p <= n:  # solange Quadrat kleiner gleich n
    # Vielfache von p streichen (außer p selbst)
    for i in range(2 * p, n + 1, p):
        zahlen[i - 1] = 0  # -1 weil unsere Liste bei 1 beginnt
    # nächste Zahl > p finden, die nicht gestrichen ist
    for j in range(p + 1, n + 1):
        if zahlen[j - 1] != 0:
            p = j
            break
    else:
        break

# Schritt 3: Alle Zahlen > 1, die nicht 0 sind, sind Primzahlen
primzahlen = []
for zahl in zahlen:
    if zahl > 1:
        primzahlen.append(zahl)

# Ausgabe
print("Die Primzahlen bis", n, "sind:")
print(primzahlen)
