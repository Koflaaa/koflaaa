<?php
class Bahnhof {
    public $AnzahlZuege;
    public $AnzahlWagen;
    public $Ziele;
    public $WagAnzahl;

    public function __construct($AnzahlZuege = 0, $AnzahlWagen = 0, $Ziele = "") {
        $this->AnzahlZuege = $AnzahlZuege;
        $this->AnzahlWagen = $AnzahlWagen;
        $this->Ziele = $Ziele;
    }

    public function WagenZahl() {
        return $this->AnzahlWagen;
    }

    public function ZugZahl() {
        return $this->AnzahlZuege;
    }

    public function AddZug($zug) {
        $this->AnzahlZuege += 1;
        $this->AnzahlWagen += $zug->WagenAnzahl();
        $this->Ziele = $zug->Ziel;
    }

    public function AddSteig($bahnsteig) {
        $this->WagAnzahl += $bahnsteig->WZahl();
    }
}

class Bahnsteig {
    public $Zielname;
    public $WagAnzahl;
    public $ZAnzahl;

    public function __construct($Zielname = "", $WagAnzahl = 0, $ZAnzahl = 0) {
        $this->Zielname = $Zielname;
        $this->WagAnzahl = $WagAnzahl;
        $this->ZAnzahl = $ZAnzahl;
    }

    public function WZahl() {
        return $this->WagAnzahl;
    }
}

class Zug {
    public $Ziel;
    public $AnzahlWagen;

    public function WagenAnzahl() {
        return $this->AnzahlWagen;
    }
}

// Main Program
$zug1 = new Zug();
$zug2 = new Zug();
$zug3 = new Zug();
$zug4 = new Zug();

$steig1 = new Bahnsteig();
$steig2 = new Bahnsteig();
$steig3 = new Bahnsteig();
$bahnhof1 = new Bahnhof();

// Zügen Eigenschaften zuweisen
$zug1->AnzahlWagen = 8;
$zug2->AnzahlWagen = 6;
$zug3->AnzahlWagen = 10;
$zug4->AnzahlWagen = 12;

$zug1->Ziel = "Bern";
$zug2->Ziel = "Paris";
$zug3->Ziel = "Rom";
$zug4->Ziel = "Wien";

// Bahnsteige initialisieren
$steig1->WagAnzahl = $zug4->AnzahlWagen;
$steig2->WagAnzahl = $zug3->AnzahlWagen;
$steig3->WagAnzahl = $zug1->AnzahlWagen + $zug2->AnzahlWagen;

// Züge und Bahnsteige dem Bahnhof hinzufügen
$bahnhof1->AddZug($zug1);
$bahnhof1->AddZug($zug2);
$bahnhof1->AddZug($zug3);
$bahnhof1->AddZug($zug4);
$bahnhof1->AddSteig($steig1);
$bahnhof1->AddSteig($steig2);
$bahnhof1->AddSteig($steig3);

// Ausgaben
echo "Ziele für Bahnhof:\n";
echo "Ziel 1: {$zug1->Ziel}\nZiel 2: {$zug2->Ziel}\nZiel 3: {$zug3->Ziel}\nZiel 4: {$zug4->Ziel}\n\n";

echo "Anzahl der Züge die sich am Bahnhof befinden:\n" . $bahnhof1->ZugZahl() . "\n\n";

echo "Anzahl der Wagen an Bahnsteigen:\n";
echo "Bahnsteig 1: {$steig1->WZahl()}\n";
echo "Bahnsteig 2: {$steig2->WZahl()}\n";
echo "Bahnsteig 3: {$steig3->WZahl()}\n\n";

echo "Anzahl der Wagen die sich am Bahnhof befinden:\n" . $bahnhof1->WagenZahl() . "\n\n";

echo "Fahrplan:\n\n";
echo "Zug 1 mit {$zug1->WagenAnzahl()} Wagons fährt nach {$zug1->Ziel}.\n";
echo "Zug 2 mit {$zug2->WagenAnzahl()} Wagons fährt nach {$zug2->Ziel}.\n";
echo "Zug 3 mit {$zug3->WagenAnzahl()} Wagons fährt nach {$zug3->Ziel}.\n";
echo "Zug 4 mit {$zug4->WagenAnzahl()} Wagons fährt nach {$zug4->Ziel}.\n";
?>
