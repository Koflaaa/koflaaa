<?php

require_once "KaffeeGeschaeft.php";
require_once "KaffeemaschinenAusgleichen.php";
require_once "Kaffeemaschine.php";

$maschine1 = new Kaffeemaschine();
$maschine2 = new Kaffeemaschine();

$geschaeft = new KaffeeGeschaeft(12); // 12€/kg
$service = new KaffeemaschinenAusgleichen();


?>