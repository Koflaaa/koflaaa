<?php

# Erstellen der Spieler Klasse mit zugehoerigen Attrtibuten und dem Konstruktor
class Spieler {
    public $name;
    public $alter;
    public $spielstaerke;
    public $torschussqualitaet;
    public $motivation;
    public $tore = 0;

    # Initalisieren der Variablen im Konstruktor
    public function __construct($name, $alter, $spielstaerke, $torschussqualitaet, $motivation) {
        $this->name = $name;
        $this->alter = $alter;
        $this->spielstaerke = $spielstaerke;
        $this->torschussqualitaet = $torschussqualitaet;
        $this->motivation = $motivation;
    }
}

# Erstellen der Sub-Class Torwart mit Vererbung der Variablen aus Main-Class Spieler
class Torwart extends Spieler {
    # Deklarierung der Variable 'Reaktionsvermoegen'
    public $reaktionsvermoegen;

    # Initialierung der Variablen aus der Vererbung der Main-Class Spieler und der Reaktionsvermoegen
    public function __construct($name, $alter, $spielstaerke, $torschussqualitaet, $motivation, $reaktionsvermoegen) {
        # Initialierung der Vererbten Variablen aus Parent-Class
        parent::__construct($name, $alter, $spielstaerke, $torschussqualitaet, $motivation);
        $this->reaktionsvermoegen = $reaktionsvermoegen;
    }
}

# Erstellung der Klasse Trainer und Initialierung der Variablen
class Trainer {
    public $name;
    public $alter;
    public $erfahrung;

    # Erstellung des Konstruktors und Deklarierung der Variablen
    public function __construct($name, $alter, $erfahrung) {
        $this->name = $name;
        $this->alter = $alter;
        $this->erfahrung = $erfahrung;
    }
}

# Erstellung der Klasse Mannschaft und Initialierung der Variablen
class Mannschaft {
    public $name;
    public $spieler = [];
    public $trainer;
    
    # Erstellung des Konstruktors und Deklaration der Variablen
    public function __construct($name, $trainer) {
        $this->name = $name;
        $this->trainer = $trainer;
    }

    # Erstellung der Methode um neuen Spieler in das Array 'spieler[]' hinzuzufuegen
    public function addSpieler($spieler) {
        $this->spieler[] = $spieler;
    }

    # Erstellung der Methode um die Staerke der Spieler zu berechnen
    public function berechneStaerke() {
        $sumStaerke = 0;
        $sumMotivation = 0;
        $anzahl = count($this->spieler);

        # Geht jeden Spieler im Array spieler[] durch und berechnet/weisst zu die Staerke inklusive der Motivation des Spieler
        foreach ($this->spieler as $spieler) {
            $sumStaerke += $spieler->spielstaerke;
            $sumMotivation += $spieler->motivation;
        }

        # Berechnet die Durschnittsstaerke der Mannschaft
        $durchschnittStaerke = $sumStaerke / $anzahl;
        # Berechnet die Durschnittsmotivation der Mannschaft
        $durchschnittMotivation = $sumMotivation / $anzahl;

        # Gibt die Durchschnittssterke sowie die Durchschnittsmotivation der Mannschaft sowie die Erfahrung des Trainer zurueck  
        return ($durchschnittStaerke * 0.8) + ($durchschnittMotivation * 0.15) + ($this->trainer->erfahrung * 0.05);
    }

    # Waehlt einen zufaelligen Spieler aus dem spieler[] Array und gibt diesen zurueck
    public function zufaelligerSpieler() {
        return $this->spieler[array_rand($this->spieler)];
    }
}

# Erstellung der Spiel-Klasse
class Spiel {
    # Initialierung der Mannschaften und der Spielminuten
    public $mannschaft1;
    public $mannschaft2;
    public $spielminuten = 90;

    # Erstellung des Konstuktors der Spiel-Klasse mit den Parametern der Mannschaften und Zuweisung der Mannschaften
    public function __construct($mannschaft1, $mannschaft2) {
        $this->mannschaft1 = $mannschaft1;
        $this->mannschaft2 = $mannschaft2;
    }

    # Erstellen der Methode 'Starten' um das Spiel starten zu koennen
    public function starten() {
        # Solange die minuten kleiner oder gleich der spielminuten sind laeuft das Spiel
        for ($minute = 1; $minute <= $this->spielminuten; $minute++) {
            # Die staerke der Mannschaften werden bei jedem Durchgang neu berechnet
            $staerke1 = $this->mannschaft1->berechneStaerke();
            $staerke2 = $this->mannschaft2->berechneStaerke();
            # Die Insgesamte Staerke beider Mannschaften wird als eine Summe gespeichert
            $summe = $staerke1 + $staerke2;

            # Waehlt eine Zufallszahl zischen 1 und 100 aus
            $zufall = rand(1, 100);

            # Wenn die Zufallszahl kleiner oder gleich der Quotient aus der Staerke der 1. Mannschaft und der Summe aller Mannschaften
            if ($zufall <= ($staerke1 / $summe) * 100) {
                # Waehlt einen zufaelligen Spieler der 1. Mannschaft aus
                $spieler = $this->mannschaft1->zufaelligerSpieler();
                # ueberprueft die Torschussqualitaet des Spieler, sprich: Trifft der Ball ins Tor, oder geht er daneben
                if (rand(0, 100) < $spieler->torschussqualitaet) {
                    # Wenn der Spieler trifft, bekommt die Mannschaft einen Punkt
                    $spieler->tore++;
                    # Gibt die Minute aus in der das Tor geschossen wurde
                    echo "Minute $minute: Tor fuer {$this->mannschaft1->name} durch {$spieler->name}!\n";
                }
                # Wenn die 1. Bedingung nicht stimmt dann . . .
            } else {
                # Zufaelliger Spieler der 2. Mannschaft wird gewaehlt
                $spieler = $this->mannschaft2->zufaelligerSpieler();
                # ueberprueft die Torschussqualitaet von gewaehlten Spieler
                if (rand(0, 100) < $spieler->torschussqualitaet) {
                    # Wenn der Spieler trifft, bekommt die Mannschaft einen Punkt
                    $spieler->tore++;
                    # Gibt die Minute aus in der das Tor geschossen wurde
                    echo "Minute $minute: Tor fuer {$this->mannschaft2->name} durch {$spieler->name}!\n";
                }
            }
        }

        # Zeigt das Spielergegnis an nachdem die 90 Spielminuten abgelaufen sind
        $this->ergebnisAnzeigen();
    }

    # Erstellung der Funktion zur Anzeige des Spiel Ergebnisses
    private function ergebnisAnzeigen() {
        # Tore1 ist gleich die insgesamte Summe der gesammten Tore fuer den Mannschaften
        $tore1 = array_sum(array_map(fn($s) => $s->tore, $this->mannschaft1->spieler));
        $tore2 = array_sum(array_map(fn($s) => $s->tore, $this->mannschaft2->spieler));

        # Gibt den Endstand des Spieles und die gewinnende Mannschaft aus
        echo "\nEndstand: {$this->mannschaft1->name} $tore1 : $tore2 {$this->mannschaft2->name}\n";
    }
}

# Beispielsimulation:
$trainer1 = new Trainer("Herr Schmidt", 50, 80);
$trainer2 = new Trainer("Frau Maier", 45, 70);

$team1 = new Mannschaft("Blitz FC", $trainer1);
$team2 = new Mannschaft("Tornado United", $trainer2);

# Spieler hinzufuegen
for ($i = 1; $i <= 10; $i++) {
    $team1->addSpieler(new Spieler("SpielerA$i", 20 + $i, rand(60, 100), rand(40, 90), rand(50, 100)));
    $team2->addSpieler(new Spieler("SpielerB$i", 20 + $i, rand(60, 100), rand(40, 90), rand(50, 100)));
}

# Torhueter hinzufuegen
$team1->addSpieler(new Torwart("TorwartA", 30, 80, 30, 70, 90));
$team2->addSpieler(new Torwart("TorwartB", 28, 78, 35, 65, 85));

$spiel = new Spiel($team1, $team2);
$spiel->starten();

?>
