# -*- coding: utf-8 -*-

# Mapping: 1=Mo, 2=Di, 3=Mi, 4=Do, 5=Fr, 6=Sa, 7=So
def add_days(weekday_1_to_7: int, delta_days: int) -> int:
    """Addiert delta_days auf einen Wochentag (1..7) und gibt wieder einen Wert 1..7 zurück."""
    return ((weekday_1_to_7 - 1 + (delta_days % 7)) % 7) + 1

def main():
    # --- Eingaben ---
    try:
        last_day_prev_year = int(input("Letzter Tag des Vorjahres (1=Mo ... 7=So): ").strip())
        if not 1 <= last_day_prev_year <= 7:
            raise ValueError
    except ValueError:
        print("Ungültige Eingabe für den letzten Wochentag. Erwartet ist eine Zahl 1..7.")
        return

    try:
        leap_flag = int(input("Schaltjahr? (0=nein, 1=ja): ").strip())
        if leap_flag not in (0, 1):
            raise ValueError
    except ValueError:
        print("Ungültige Eingabe für Schaltjahr. Erwartet ist 0 oder 1.")
        return

    # --- Monatslängen (Jahr allgemein, Schaltjahr wird berücksichtigt) ---
    # Index 0 wird ignoriert, damit die Monate 1..12 sind
    month_lengths_common = [0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
    month_lengths_leap   = [0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
    month_lengths = month_lengths_leap if leap_flag == 1 else month_lengths_common

    month_names = [
        "", "Januar", "Februar", "März", "April", "Mai", "Juni",
        "Juli", "August", "September", "Oktober", "November", "Dezember"
    ]

    # Der 1. Januar ist der Tag nach dem letzten Tag des Vorjahres
    weekday_first_of_month = add_days(last_day_prev_year, 1)

    sundays_on_first = []

    for m in range(1, 13):
        # Prüfen: ist der 1. dieses Monats ein Sonntag (7)?
        if weekday_first_of_month == 7:
            sundays_on_first.append((m, month_names[m]))

        # Wochentag des 1. des nächsten Monats vorbereiten:
        days_in_this_month = month_lengths[m]
        weekday_first_of_month = add_days(weekday_first_of_month, days_in_this_month)

    # --- Ausgabe ---
    if not sundays_on_first:
        print("In diesem Jahr fällt kein 1. eines Monats auf einen Sonntag.")
    else:
        print("Monate, bei denen der 1. ein Sonntag ist:")
        for m, name in sundays_on_first:
            print(f"{m:02d} - {name}")

if __name__ == "__main__":
    main()
