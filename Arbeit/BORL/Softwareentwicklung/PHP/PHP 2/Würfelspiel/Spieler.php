<?php
declare(strict_types=1);

class Spieler
{
    private string $name;
    private int $punkte;

    public function __construct()
    {
        $this->name = '';
        $this->punkte = 0;
    }

    public function getName(): string
    {
        return $this->name;
    }

    public function setName(string $name): void
    {
        $this->name = trim($name);
    }

    public function getPunkte(): int
    {
        return $this->punkte;
    }

    public function setPunkte(int $punkte): void
    {
        $this->punkte = $punkte;
    }

    public function addPunkte(int $punkte): void
    {
        $this->punkte += $punkte;
    }
}