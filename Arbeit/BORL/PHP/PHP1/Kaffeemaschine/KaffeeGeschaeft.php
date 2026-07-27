<?php

class KaffeeGeschaeft {

    private float $preisProKg;

    public function __construct(float $preisProKg = 5) {
        $this->setPreisProKg($preisProKg);
    }

    public function setPreisProKg(float $amount): string {
        if ($amount >= 5 && $amount <= 30) {
            $this->preisProKg = $amount;
            return "Neuer Preis pro Kilogramm: {$this->preisProKg} €";
        }

        return "Ungültiger Wert! Bitte zwischen 5 und 30 eingeben.";
    }

    public function getPreisProKg(): float {
        return $this->preisProKg;
    }

    public function kaufeKaffee(Kaffeemaschine $maschine, float $menge): float {
        $maschine->erhoeheKaffeeMenge($menge);
        return "Der Totalepreis für die Eingekaufte Menge beträgt: {($menge * $this->preisProKg)}";
    }
}
?>
