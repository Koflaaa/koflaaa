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