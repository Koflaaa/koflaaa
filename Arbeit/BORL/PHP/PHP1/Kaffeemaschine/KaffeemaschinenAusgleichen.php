<?php
require_once "Kaffeemaschine.php";

class KaffeemaschinenAusgleichen
{
    public function kaffeemaschinenAngleichen(Kaffeemaschine $maschine1, Kaffeemaschine $maschine2): void
    {
        // 1) Wasser angleichen
        $wasserMaschine1 = $maschine1->getWasser();
        $wasserMaschine2 = $maschine2->getWasser();

        if ($wasserMaschine1 < $wasserMaschine2) {
            $maschine1->wasserAuffuellen($wasserMaschine2 - $wasserMaschine1);
        } elseif ($wasserMaschine2 < $wasserMaschine1) {
            $maschine2->wasserAuffuellen($wasserMaschine1 - $wasserMaschine2);
        }

        // 2) Bohnen angleichen
        $bohnenMaschine1 = $maschine1->getBohnen();
        $bohnenMaschine2 = $maschine2->getBohnen();

        if ($bohnenMaschine1 < $bohnenMaschine2) {
            $maschine1->bohnenAuffuellen($bohnenMaschine2 - $bohnenMaschine1);
        } elseif ($bohnenMaschine2 < $bohnenMaschine1) {
            $maschine2->bohnenAuffuellen($bohnenMaschine1 - $bohnenMaschine2);
        }
    }

    public function fuellMilch(?Kaffeemaschine &$maschine, float $amount): void
    {
        // Falls null übergeben wurde → neue Maschine erzeugen
        if ($maschine === null) {
            $maschine = new Kaffeemaschine();
            $maschine->wasserAuffuellen($amount);
            return;
        }

        // Aktuellen Wasserstand holen
        $aktuellesWasser = $maschine->getWasser();

        // Nur auffüllen wenn zu wenig drin ist
        if ($aktuellesWasser < $amount) {
            $maschine->wasserAuffuellen($amount - $aktuellesWasser);
        }
    }

}
?>