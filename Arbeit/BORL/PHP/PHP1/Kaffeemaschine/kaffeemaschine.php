<?php

class Kaffeemaschine
{


    private float $wasser;   // kg
    private float $bohnen;   // kg
    private float $gesamtMengeProduziert; // kg

    private static float $maxBohnen = 2.5; // kg
    private static float $maxWasser = 2.5; // kg

    public function __construct(float $wasser = 0, float $bohnen = 0,float $gesamtMengeProduziert = 0) 
    {
        $this->wasser = $wasser;
        $this->bohnen = $bohnen;
        $this->gesamtMengeProduziert = $gesamtMengeProduziert;
    }

    public function getBohnen() {
        return $this->bohnen;
    }

    public function getBohnenText()
    {
        return "Es sind noch {$this->bohnen} kg Bohnen vorhanden.";
    }

    public function getWasser()
    {
        return "Es sind noch {$this->wasser} l Wasser vorhanden.";
    }

    public function wasserAuffuellen(float $menge): void
    {
        if ($this->wasser + $menge > self::$maxWasser) {
            echo "Wassertank voll! Maximal: " . self::$maxWasser . " kg\n";
            return;
        }

        $this->wasser += $menge;
        echo "Wasser aufgefüllt. Neuer Wasserstand: {$this->wasser} kg\n";
    }

    public function bohnenAuffuellen(float $menge): void
    {
        if ($this->bohnen + $menge > self::$maxBohnen) {
            echo "Bohnenbehälter voll! Maximal: " . self::$maxBohnen . " kg\n";
            return;
        }

        $this->bohnen += $menge;
        echo "Bohnen aufgefüllt. Neuer Bohnenstand: {$this->bohnen} kg\n";
    }

    public function macheKaffee(float $menge, float $verhaeltnisWasserBohnen): bool
    {
        // Ungültige Werte abfangen
        if ($menge <= 0 || $verhaeltnisWasserBohnen <= 0) {
            return false;
        }

        // Benötigte Mengen berechnen
        $bohnen = $menge / (1 + $verhaeltnisWasserBohnen);
        $wasser = $menge - $bohnen;

        // Prüfen ob genug vorhanden ist
        if ($this->bohnen < $bohnen || $this->wasser < $wasser) {
            echo "Nicht genügend Wasser oder Bohnen vorhanden.\n";
            return false;
        }

        // Ressourcen verbrauchen
        $this->bohnen -= $bohnen;
        echo "Neuer Bohnenstand: {$this->bohnen}";
        $this->wasser -= $wasser;
        echo "Neuer Wasserstand: {$this->wasser}";

        // Gesamtproduktion erhöhen
        $this->gesamtMengeProduziert += $menge;

        echo "Kaffee erfolgreich zubereitet ({$menge} kg)\n";
        return true;
    }
}
