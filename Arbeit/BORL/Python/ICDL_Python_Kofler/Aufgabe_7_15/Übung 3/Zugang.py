eingabe_Username = input("Geben Sie Ihren Username ein: ")
eingabe_Passwort = input("Geben Sie bitte Ihr Passwort ein: ")
gesetztes_Passwort = "geheim"
gesetzer_Username = "gast"

if eingabe_Passwort == gesetzer_Username and eingabe_Passwort == gesetztes_Passwort:
    print("Zugang erlaubt.")
else:
    print("Zugang verweigert.")
