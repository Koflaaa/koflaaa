<?php
declare(strict_types=1);



require_once 'Spieler.php';
require_once 'Würfel.php';

session_start();

/* -----------------------------
   Spielobjekte beim ersten Start
------------------------------ */
if (!isset($_SESSION['spieler1'])) {
    $_SESSION['spieler1'] = new Spieler();
}
if (!isset($_SESSION['spieler2'])) {
    $_SESSION['spieler2'] = new Spieler();
}
if (!isset($_SESSION['wuerfel1'])) {
    $_SESSION['wuerfel1'] = new Wuerfel();
}
if (!isset($_SESSION['wuerfel2'])) {
    $_SESSION['wuerfel2'] = new Wuerfel();
}
if (!isset($_SESSION['meldung'])) {
    $_SESSION['meldung'] = 'Spiel bereit.';
}
if (!isset($_SESSION['spielVorbei'])) {
    $_SESSION['spielVorbei'] = false;
}

$spieler1 = $_SESSION['spieler1'];
$spieler2 = $_SESSION['spieler2'];
$wuerfel1 = $_SESSION['wuerfel1'];
$wuerfel2 = $_SESSION['wuerfel2'];
$meldung = $_SESSION['meldung'];
$spielVorbei = $_SESSION['spielVorbei'];

/* -----------------------------
   Formulare verarbeiten
------------------------------ */
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $aktion = $_POST['aktion'] ?? '';

    if ($aktion === 'namen_setzen') {
        $name1 = $_POST['name1'] ?? '';
        $name2 = $_POST['name2'] ?? '';

        $spieler1->setName($name1 !== '' ? $name1 : 'Spieler 1');
        $spieler2->setName($name2 !== '' ? $name2 : 'Spieler 2');

        $meldung = 'Namen wurden festgelegt.';
    }

    if ($aktion === 'wurf_spieler1' && !$spielVorbei) {
        $wuerfel1->wuerfeln();
        $zahl = $wuerfel1->getZahl();
        $spieler1->addPunkte($zahl);

        $meldung = $spieler1->getName() . ' würfelt eine ' . $zahl . '.';

        if ($zahl === 6) {
            $spieler1->addPunkte(5);
            $meldung .= ' Bonus: +5 Punkte für eine 6!';
        }

        if ($spieler1->getPunkte() >= 30) {
            $meldung = $spieler1->getName() . ' hat gewonnen!';
            $spielVorbei = true;
        }
    }

    if ($aktion === 'wurf_spieler2' && !$spielVorbei) {
        $wuerfel2->wuerfeln();
        $zahl = $wuerfel2->getZahl();
        $spieler2->addPunkte($zahl);

        $meldung = $spieler2->getName() . ' würfelt eine ' . $zahl . '.';

        if ($zahl === 6) {
            $spieler2->addPunkte(5);
            $meldung .= ' Bonus: +5 Punkte für eine 6!';
        }

        if ($spieler2->getPunkte() >= 30) {
            $meldung = $spieler2->getName() . ' hat gewonnen!';
            $spielVorbei = true;
        }
    }

    if ($aktion === 'neues_spiel') {
        $spieler1 = new Spieler();
        $spieler2 = new Spieler();
        $wuerfel1 = new Wuerfel();
        $wuerfel2 = new Wuerfel();

        $spieler1->setName('Spieler 1');
        $spieler2->setName('Spieler 2');

        $meldung = 'Neues Spiel gestartet.';
        $spielVorbei = false;
    }

    $_SESSION['spieler1'] = $spieler1;
    $_SESSION['spieler2'] = $spieler2;
    $_SESSION['wuerfel1'] = $wuerfel1;
    $_SESSION['wuerfel2'] = $wuerfel2;
    $_SESSION['meldung'] = $meldung;
    $_SESSION['spielVorbei'] = $spielVorbei;

    header('Location: ' . $_SERVER['PHP_SELF']);
    exit;
}

/* -----------------------------
   Standardnamen anzeigen
------------------------------ */
$nameAnzeige1 = $spieler1->getName() !== '' ? $spieler1->getName() : 'Spieler 1';
$nameAnzeige2 = $spieler2->getName() !== '' ? $spieler2->getName() : 'Spieler 2';
?>
<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <title>Würfelspiel</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background: #e9eef2;
            margin: 0;
            padding: 30px;
        }

        .fenster {
            width: 700px;
            margin: 0 auto;
            background: #f8f8f8;
            border: 1px solid #999;
            padding: 25px;
            box-shadow: 0 0 8px rgba(0,0,0,0.15);
        }

        h1 {
            text-align: center;
            margin-top: 0;
        }

        .info {
            text-align: center;
            margin-bottom: 25px;
            font-size: 14px;
        }

        .namen-form {
            display: flex;
            justify-content: center;
            gap: 10px;
            margin-bottom: 30px;
        }

        input[type="text"] {
            padding: 8px;
            width: 180px;
        }

        button {
            padding: 8px 14px;
            cursor: pointer;
        }

        .spieler-bereich {
            display: flex;
            justify-content: space-between;
            gap: 20px;
            margin-bottom: 25px;
        }

        .spieler-box {
            width: 48%;
            background: white;
            border: 1px solid #bbb;
            padding: 15px;
            text-align: center;
        }

        .punkte {
            font-size: 18px;
            margin: 10px 0;
        }

        .wuerfel {
            width: 80px;
            height: 80px;
            margin: 10px auto;
            border: 2px solid #666;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 32px;
            background: #f2f2f2;
        }

        .meldung {
            margin: 20px 0;
            padding: 12px;
            background: #ffffff;
            border: 1px solid #bbb;
            min-height: 24px;
            text-align: center;
        }

        .unten {
            text-align: center;
            margin-top: 20px;
        }

        .gewonnen {
            color: darkgreen;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <div class="fenster">
        <h1>Würfelspiel</h1>

        <div class="info">
            Jeder Spieler würfelt mit 1 Würfel.<br>
            Gewonnen hat der Spieler, der zuerst 30 Punkte erreicht.
        </div>

        <form method="post" class="namen-form">
            <input type="hidden" name="aktion" value="namen_setzen">
            <input type="text" name="name1" placeholder="Spieler 1">
            <input type="text" name="name2" placeholder="Spieler 2">
            <button type="submit">Namen festlegen</button>
        </form>

        <div class="spieler-bereich">
            <div class="spieler-box">
                <h2><?= htmlspecialchars($nameAnzeige1) ?></h2>
                <div class="punkte">Punkte: <?= $spieler1->getPunkte() ?></div>
                <div>Würfel 1</div>
                <div class="wuerfel"><?= $wuerfel1->getZahl() ?></div>

                <form method="post">
                    <input type="hidden" name="aktion" value="wurf_spieler1">
                    <button type="submit" <?= $spielVorbei ? 'disabled' : '' ?>>Würfeln</button>
                </form>
            </div>

            <div class="spieler-box">
                <h2><?= htmlspecialchars($nameAnzeige2) ?></h2>
                <div class="punkte">Punkte: <?= $spieler2->getPunkte() ?></div>
                <div>Würfel 2</div>
                <div class="wuerfel"><?= $wuerfel2->getZahl() ?></div>

                <form method="post">
                    <input type="hidden" name="aktion" value="wurf_spieler2">
                    <button type="submit" <?= $spielVorbei ? 'disabled' : '' ?>>Würfeln</button>
                </form>
            </div>
        </div>

        <div class="meldung <?= $spielVorbei ? 'gewonnen' : '' ?>">
            <?= htmlspecialchars($meldung) ?>
        </div>

        <div class="unten">
            <form method="post">
                <input type="hidden" name="aktion" value="neues_spiel">
                <button type="submit">Neues Spiel</button>
            </form>
        </div>
    </div>
</body>
</html>