<?php

class Spieler {
    public string $name;
    public int $alter;
    public int $spielstaerke;
    public int $torschussqualitaet;
    public int $motivation;
    public int $tore = 0;

    public function __construct(string $name, int $alter, int $spielstaerke, int $torschussqualitaet, int $motivation) {
        $this->name = $name;
        $this->alter = $alter;
        $this->spielstaerke = $spielstaerke;
        $this->torschussqualitaet = $torschussqualitaet;	
        $this->motivation = $motivation;
    }

    public function berechneSchussstaerke(): int {
        $varianz = rand(-2, 1);
        return max(0, $this->torschussqualitaet + $varianz);
    }
}

class Torwart extends Spieler {
    public int $reaktionsvermoegen;

    public function __construct(string $name, int $alter, int $spielstaerke, int $torschussqualitaet, int $motivation, int $reaktionsvermoegen) {
        parent::__construct($name, $alter, $spielstaerke, $torschussqualitaet, $motivation);
        $this->reaktionsvermoegen = $reaktionsvermoegen;
    }

    public function berechneParade(): int {
        $varianz = rand(-1, 1);
        return max(0, $this->reaktionsvermoegen + $varianz);
    }
}

class Trainer {
    public string $name;
    public int $alter;
    public int $erfahrung;

    public function __construct(string $name, int $alter, int $erfahrung) {
        $this->name = $name;
        $this->alter = $alter;
        $this->erfahrung = $erfahrung;
    }
}

class Mannschaft {
    public string $name;
    public array $spieler = [];
    public Trainer $trainer;

    public function __construct(string $name, Trainer $trainer) {
        $this->name = $name;
        $this->trainer = $trainer;
    }

    public function addSpieler(Spieler $spieler): void {
        $this->spieler[] = $spieler;
    }
}

class Spiel {
    private Mannschaft $mannschaft1;
    private Mannschaft $mannschaft2;

    public function __construct(Mannschaft $mannschaft1, Mannschaft $mannschaft2) {
        $this->mannschaft1 = $mannschaft1;
        $this->mannschaft2 = $mannschaft2;
    }

    public function ausgabeMannschaften(): void {
        echo "Spiel: {$this->mannschaft1->name} vs. {$this->mannschaft2->name}<br>";
    }

    public function ausgabeSpielerliste(Mannschaft $mannschaft): void {
        echo "Spieler von {$mannschaft->name}:<br>";
        foreach ($mannschaft->spieler as $nummer => $spieler) {
            echo "Nummer: " . ($nummer + 1) . " - Name: {$spieler->name}<br>";
        }
    }

    public function schiessen(Mannschaft $mannschaftSchuetzen, Mannschaft $mannschaftTorwart): void {
        echo "Eingabe – Nummer des Spielers, der schießen soll:<br>";
        $this->ausgabeSpielerliste($mannschaftSchuetzen);

        // Simulierte Eingabe (in einer realen App würden Sie Benutzereingaben abfragen)
        $nummerSpieler = rand(1, count($mannschaftSchuetzen->spieler));
        $spieler = $mannschaftSchuetzen->spieler[$nummerSpieler - 1];

        $torwart = $this->findeTorwart($mannschaftTorwart);
        $schuss = $spieler->berechneSchussstaerke();
        $parade = $torwart->berechneParade();

        echo "Schuss von {$spieler->name} (Schussstärke: $schuss)<br>";
        echo "Parade von {$torwart->name} (Reaktionsvermögen: $parade)<br>";

        if ($schuss > $parade) {
            echo "Tor für {$mannschaftSchuetzen->name}!<br>";
            $spieler->tore++;
        } else {
            echo "Parade von {$torwart->name}! Kein Tor!<br>";
        }
    }

    private function findeTorwart(Mannschaft $mannschaft): Spieler {
        foreach ($mannschaft->spieler as $spieler) {
            if ($spieler instanceof Torwart) {
                return $spieler;
            }
        }

        throw new Exception("Kein Torwart in der Mannschaft gefunden!");
    }
}

// Erstellung von Trainern
$trainer1 = new Trainer("Trainer 1", 45, 9);
$trainer2 = new Trainer("Trainer 2", 50, 8);

// Erstellung der Mannschaften und Spieler
$mannschaft1 = new Mannschaft("Team A", $trainer1);
$mannschaft1->addSpieler(new Spieler("Spieler 1", 25, 8, 7, 9));
$mannschaft1->addSpieler(new Spieler("Spieler 2", 27, 9, 8, 8));
$mannschaft1->addSpieler(new Torwart("Torwart A", 30, 7, 0, 8, 9));

$mannschaft2 = new Mannschaft("Team B", $trainer2);
$mannschaft2->addSpieler(new Spieler("Spieler 3", 26, 7, 8, 7));
$mannschaft2->addSpieler(new Spieler("Spieler 4", 24, 6, 7, 8));
$mannschaft2->addSpieler(new Torwart("Torwart B", 28, 8, 0, 7, 8));

// Spiel simulieren
$spiel = new Spiel($mannschaft1, $mannschaft2);
$spiel->ausgabeMannschaften();
$spiel->schiessen($mannschaft1, $mannschaft2);
$spiel->schiessen($mannschaft2, $mannschaft1);
?>
