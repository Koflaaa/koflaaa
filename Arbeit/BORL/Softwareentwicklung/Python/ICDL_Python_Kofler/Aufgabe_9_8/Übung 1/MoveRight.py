# PROZEDUR MoveRight(A)
#     n ← LÄNGE(A)
#     WENN n = 0 DANN
#         GIB ZURÜCK
#     ENDE WENN

#     temp ← A[n-1]              // letztes Element merken
#     FÜR i VON n-1 ABWÄRTS BIS 1
#         A[i] ← A[i-1]          // nach rechts schieben
#     ENDE FÜR
#     A[0] ← temp                // gemerktes Element nach vorne    
# ENDE PROZEDUR


# MoveRight.py

def move_right(a):
    """Schiebt die Elemente der Liste a zyklisch um 1 nach rechts.
    Kein return – die Liste wird in place verändert.
    """
    n = len(a)
    if n == 0:
        return
    last = a[-1]
    for i in range(n - 1, 0, -1):
        a[i] = a[i - 1]
    a[0] = last



if __name__ == "__main__":
    arr = [1, 2, 3, 4]
    print("vorher:", arr)
    move_right(arr)
    print("nachher:", arr)  # -> [4, 1, 2, 3]


def kugel_werte(r, out_dict):
    """Füllt out_dict mit 'umfang', 'mantelflaeche', 'volumen'."""
    pi = 3.14
    out_dict["umfang"] = 2 * pi * r
    out_dict["mantelflaeche"] = 4 * pi * r * r
    out_dict["volumen"] = (4 / 3) * pi * r ** 3


# Beispiel
if __name__ == "__main__":
    ergebnis = {}
    kugel_werte(2.0, ergebnis)
    print(ergebnis)
    # {'umfang': 12.56, 'mantelflaeche': 50.24, 'volumen': 33.49333333333333}
