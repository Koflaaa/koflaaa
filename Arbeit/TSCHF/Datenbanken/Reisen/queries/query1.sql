-- Active: 1737960078280@@127.0.0.1@3306@kofler_reisen
CREATE TABLE Personal(
    Personalnummer int PRIMARY KEY AUTO_INCREMENT,
    Nachname VARCHAR(255) NOT NULL,
    Vorname VARCHAR(255) NOT NULL,
    Straße VARCHAR(255) NOT NULL,
    PLZ VARCHAR(100) NOT NULL,
    Ort VARCHAR(255) NOT NULL
);

CREATE TABLE Reise (
    Rechnungsnummer INT PRIMARY KEY AUTO_INCREMENT,
    Datum date NOT NULL,
    Personalnummer int,
    FOREIGN KEY (Personalnummer) REFERENCES Personal(Personalnummer)
);

