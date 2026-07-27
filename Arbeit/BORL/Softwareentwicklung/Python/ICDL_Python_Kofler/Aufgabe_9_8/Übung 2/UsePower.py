# Funktion Minimum3(a, b, c)
#     min ← a
#     Wenn b < min dann
#         min ← b
#     EndeWenn
#     Wenn c < min dann
#         min ← c
#     EndeWenn
#     Rückgabe min
# EndeFunktion


# FindMin.py
def minimum3(a, b, c):
    m = a
    if b < m:
        m = b
    if c < m:
        m = c
    return m

if __name__ == "__main__":
    print("Minimum von drei verschiedenen Werten")
    a = float(input("a: "))
    b = float(input("b: "))
    c = float(input("c: "))
    print("Minimum:", minimum3(a, b, c))

# -----------------------------------------------------------------------------------

# Funktion Potenz(x, n)
#     # konvention: x^0 = 1
#     ergebnis ← 1
#     Für i von 1 bis n
#         ergebnis ← ergebnis * x
#     EndeFür
#     Rückgabe ergebnis
# EndeFunktion

# Hauptprogramm
#     x ← Eingabe()
#     n ← Eingabe()
#     y ← Potenz(x, n)
#     Ausgabe "x^n =", y
# Ende

# UsePower.py
def power(x: int, n: int) -> int:
    """Berechnet x^n für natürliche n (inkl. 0) iterativ."""
    if n < 0:
        raise ValueError("n muss eine natürliche Zahl (>= 0) sein.")
    result = 1
    for _ in range(n):
        result *= x
    return result

if __name__ == "__main__":
    print("Teste die Potenzfunktion: y = x^n (x, n ∈ ℕ, n darf 0 sein)")
    try:
        x = int(input("Basis x (0,1,2,...): "))
        n = int(input("Exponent n (0,1,2,...): "))
        if x < 0 or n < 0:
            raise ValueError
        print(f"{x}^{n} = {power(x, n)}")
    except ValueError:
        print("Ungültige Eingabe: Bitte natürliche Zahlen (>= 0) verwenden.")
