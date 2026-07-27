<?php
declare(strict_types=1);

class Wuerfel
{
    private int $zahl;

    public function __construct()
    {
        $this->zahl = 1;
    }

    public function wuerfeln(): void
    {
        $this->zahl = rand(1, 6);
    }

    public function getZahl(): int
    {
        return $this->zahl;
    }
}