import time
import tkinter as tk

def aktuelle_uhrzeit():
    #Ermittelt die aktuelle Uhrzeit und aktualisiert das Label.
    jetzt = time.strftime('%H:%M:%S')  # %H=Stunden (24h), %M=Minuten, %S=Sekunden
    label.config(text=jetzt)
    # Alle 200 ms erneut aktualisieren
    label.after(200, aktuelle_uhrzeit)

# GUI-Fenster erstellen
root = tk.Tk()
root.title('Meine grafische Uhr')

# Label für die Uhrzeit (große, gut lesbare Schrift)
label = tk.Label(
    root,
    font=('Courier New', 48, 'bold'),
    bg='#222222',
    fg='#f0f0f0',
    padx=20,
    pady=10
)

# pack-Geometry-Manager: Fenstergröße passt sich dem Label an
label.pack()

# Startaktualisierung
aktuelle_uhrzeit()

# Event-Loop starten
root.mainloop()
