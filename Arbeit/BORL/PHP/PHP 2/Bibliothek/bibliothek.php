<?php
// Strikte Typprüfung aktivieren
declare(strict_types=1);

/**
 * Klasse für die Datenbankverbindung und allgemeine Datenbankmethoden.
 */
final class DB {
    // PDO-Objekt für die Verbindung zur SQLite-Datenbank
    private PDO $pdo;

    /**
     * Konstruktor: Erstellt die Verbindung zur SQLite-Datenbank.
     * Falls keine Datei übergeben wird, wird bibliothek.sqlite im selben Ordner verwendet.
     */
    public function __construct(string $file = __DIR__ . '/bibliothek.sqlite') {
        $this->pdo = new PDO('sqlite:' . $file);

        // PDO soll Fehler als Exceptions werfen
        $this->pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        // Aktiviert Fremdschlüssel in SQLite
        $this->pdo->exec('PRAGMA foreign_keys = ON;');
    }

    /**
     * Führt direkt ein SQL-Statement ohne Parameter aus.
     */
    public function exec(string $sql): void {
        $this->pdo->exec($sql);
    }

    /**
     * Führt ein vorbereitetes SQL-Statement mit Parametern aus.
     */
    public function run(string $sql, array $params = []): void {
        $stmt = $this->pdo->prepare($sql);
        $stmt->execute($params);
    }

    /**
     * Führt eine SELECT-Abfrage aus und gibt alle Ergebnisse als Array zurück.
     */
    public function all(string $sql, array $params = []): array {
        $stmt = $this->pdo->prepare($sql);
        $stmt->execute($params);
        return $stmt->fetchAll(PDO::FETCH_ASSOC);
    }

    /**
     * Führt eine Abfrage aus und gibt genau einen Wert zurück.
     * Falls kein Wert gefunden wird, wird null zurückgegeben.
     */
    public function one(string $sql, array $params = []): mixed {
        $stmt = $this->pdo->prepare($sql);
        $stmt->execute($params);
        $value = $stmt->fetchColumn();
        return $value === false ? null : $value;
    }

    /**
     * Gibt die zuletzt eingefügte ID zurück.
     */
    public function lastId(): int {
        return (int)$this->pdo->lastInsertId();
    }
}

/**
 * Hauptklasse für die Bibliothekslogik.
 * Enthält Methoden zum Erstellen, Löschen und Auslesen der Daten.
 */
final class Bibliothek {
    /**
     * Konstruktor mit Datenbankobjekt.
     */
    public function __construct(private DB $db) {}

    /**
     * Erstellt die Datenbanktabellen, falls sie noch nicht existieren.
     */
    public function initSchema(): void {
        $this->db->exec("
            CREATE TABLE IF NOT EXISTS ort (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL UNIQUE
            );

            CREATE TABLE IF NOT EXISTS verlag (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL UNIQUE,
                ort_id INTEGER NOT NULL,
                FOREIGN KEY (ort_id) REFERENCES ort(id)
            );

            CREATE TABLE IF NOT EXISTS autor (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL,
                jahrgang INTEGER NOT NULL
            );

            CREATE TABLE IF NOT EXISTS buch (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                titel TEXT NOT NULL,
                isbn TEXT NOT NULL UNIQUE,
                seiten INTEGER NOT NULL,
                verlag_id INTEGER NOT NULL,
                FOREIGN KEY (verlag_id) REFERENCES verlag(id)
            );

            CREATE TABLE IF NOT EXISTS buch_autor (
                buch_id INTEGER NOT NULL,
                autor_id INTEGER NOT NULL,
                PRIMARY KEY (buch_id, autor_id),
                FOREIGN KEY (buch_id) REFERENCES buch(id) ON DELETE CASCADE,
                FOREIGN KEY (autor_id) REFERENCES autor(id) ON DELETE CASCADE
            );
        ");
    }

    /**
     * Fügt einen neuen Ort hinzu.
     */
    public function addOrt(string $name): void {
        $name = trim($name);

        // Prüfen, ob der Name leer ist
        if ($name === '') {
            throw new Exception('Ort darf nicht leer sein.');
        }

        $this->db->run("INSERT INTO ort (name) VALUES (?)", [$name]);
    }

    /**
     * Fügt einen neuen Verlag hinzu.
     */
    public function addVerlag(string $name, int $ortId): void {
        $name = trim($name);

        // Prüfen, ob der Verlagsname leer ist
        if ($name === '') {
            throw new Exception('Verlagsname darf nicht leer sein.');
        }

        $this->db->run("INSERT INTO verlag (name, ort_id) VALUES (?, ?)", [$name, $ortId]);
    }

    /**
     * Fügt einen neuen Autor hinzu.
     */
    public function addAutor(string $name, int $jahrgang): void {
        $name = trim($name);

        // Prüfen, ob der Name leer ist
        if ($name === '') {
            throw new Exception('Autorenname darf nicht leer sein.');
        }

        // Jahrgang darf nicht negativ sein
        if ($jahrgang < 0) {
            throw new Exception('Jahrgang ist ungültig.');
        }

        $this->db->run("INSERT INTO autor (name, jahrgang) VALUES (?, ?)", [$name, $jahrgang]);
    }

    /**
     * Fügt ein neues Buch hinzu und verknüpft es mit einem oder mehreren Autoren.
     */
    public function addBuch(string $titel, string $isbn, int $seiten, int $verlagId, array $autorIds): void {
        $titel = trim($titel);
        $isbn = trim($isbn);

        // Eingaben prüfen
        if ($titel === '') {
            throw new Exception('Titel darf nicht leer sein.');
        }
        if ($isbn === '') {
            throw new Exception('ISBN darf nicht leer sein.');
        }
        if ($seiten < 1) {
            throw new Exception('Seitenanzahl muss größer als 0 sein.');
        }
        if (empty($autorIds)) {
            throw new Exception('Es muss mindestens ein Autor ausgewählt werden.');
        }

        // Buch speichern
        $this->db->run(
            "INSERT INTO buch (titel, isbn, seiten, verlag_id) VALUES (?, ?, ?, ?)",
            [$titel, $isbn, $seiten, $verlagId]
        );

        // ID des neuen Buches holen
        $buchId = $this->db->lastId();

        // Alle ausgewählten Autoren mit dem Buch verknüpfen
        foreach ($autorIds as $autorId) {
            $this->db->run(
                "INSERT INTO buch_autor (buch_id, autor_id) VALUES (?, ?)",
                [$buchId, (int)$autorId]
            );
        }
    }

    /**
     * Löscht einen Ort, sofern kein Verlag mehr damit verknüpft ist.
     */
    public function deleteOrt(int $id): void {
        $anzahl = (int)$this->db->one("SELECT COUNT(*) FROM verlag WHERE ort_id = ?", [$id]);

        // Löschen verhindern, wenn der Ort noch verwendet wird
        if ($anzahl > 0) {
            throw new Exception('Dieser Ort kann nicht gelöscht werden, da noch ein Verlag damit verknüpft ist.');
        }

        $this->db->run("DELETE FROM ort WHERE id = ?", [$id]);
    }

    /**
     * Löscht einen Verlag, sofern kein Buch mehr damit verknüpft ist.
     */
    public function deleteVerlag(int $id): void {
        $anzahl = (int)$this->db->one("SELECT COUNT(*) FROM buch WHERE verlag_id = ?", [$id]);

        if ($anzahl > 0) {
            throw new Exception('Dieser Verlag kann nicht gelöscht werden, da noch Bücher damit verknüpft sind.');
        }

        $this->db->run("DELETE FROM verlag WHERE id = ?", [$id]);
    }

    /**
     * Löscht einen Autor, sofern er keinem Buch mehr zugeordnet ist.
     */
    public function deleteAutor(int $id): void {
        $anzahl = (int)$this->db->one("SELECT COUNT(*) FROM buch_autor WHERE autor_id = ?", [$id]);

        if ($anzahl > 0) {
            throw new Exception('Dieser Autor kann nicht gelöscht werden, da er noch einem oder mehreren Büchern zugeordnet ist.');
        }

        $this->db->run("DELETE FROM autor WHERE id = ?", [$id]);
    }

    /**
     * Löscht ein Buch.
     * Die Verknüpfungen in buch_autor werden wegen ON DELETE CASCADE automatisch gelöscht.
     */
    public function deleteBuch(int $id): void {
        $this->db->run("DELETE FROM buch WHERE id = ?", [$id]);
    }

    /**
     * Gibt alle Orte zurück.
     */
    public function getOrte(): array {
        return $this->db->all("SELECT id, name FROM ort ORDER BY name");
    }

    /**
     * Gibt alle Verlage inklusive Ortsname zurück.
     */
    public function getVerlage(): array {
        return $this->db->all("
            SELECT verlag.id, verlag.name, ort.name AS ort_name
            FROM verlag
            INNER JOIN ort ON verlag.ort_id = ort.id
            ORDER BY verlag.name
        ");
    }

    /**
     * Gibt alle Autoren zurück.
     */
    public function getAutoren(): array {
        return $this->db->all("SELECT id, name, jahrgang FROM autor ORDER BY name");
    }

    /**
     * Gibt alle Bücher inklusive Verlag und Autoren zurück.
     */
    public function getBuecher(): array {
        $buecher = $this->db->all("
            SELECT buch.id, buch.titel, buch.isbn, buch.seiten, verlag.name AS verlag_name
            FROM buch
            INNER JOIN verlag ON buch.verlag_id = verlag.id
            ORDER BY buch.titel
        ");

        // Für jedes Buch die zugehörigen Autoren laden
        foreach ($buecher as &$buch) {
            $buch['autoren'] = array_column(
                $this->db->all("
                    SELECT autor.name
                    FROM buch_autor
                    INNER JOIN autor ON buch_autor.autor_id = autor.id
                    WHERE buch_autor.buch_id = ?
                    ORDER BY autor.name
                ", [$buch['id']]),
                'name'
            );
        }

        return $buecher;
    }

    /**
     * Zählt die Anzahl der Datensätze in einer Tabelle.
     */
    public function count(string $table): int {
        return (int)$this->db->one("SELECT COUNT(*) FROM $table");
    }

    /**
     * Summiert alle Seitenzahlen der Bücher.
     */
    public function totalSeiten(): int {
        return (int)($this->db->one("SELECT SUM(seiten) FROM buch") ?? 0);
    }
}

/**
 * Hilfsfunktion zum sicheren Ausgeben von Text in HTML.
 * Verhindert XSS durch Umwandlung von Sonderzeichen.
 */
function h(string $text): string {
    return htmlspecialchars($text, ENT_QUOTES, 'UTF-8');
}

// Datenbank und Bibliothek initialisieren
$db = new DB();
$bibliothek = new Bibliothek($db);
$bibliothek->initSchema();

// Aktuelle Seite aus der URL lesen, Standard = start
$seite = $_GET['seite'] ?? 'start';

// Variablen für Erfolgs- und Fehlermeldungen
$meldung = '';
$fehler = '';

// Prüfen, ob ein Formular abgeschickt wurde
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    try {
        // Aktion aus dem Formular holen
        $aktion = $_POST['aktion'] ?? '';

        // Je nach Aktion passende Methode ausführen
        switch ($aktion) {
            case 'ort_anlegen':
                $bibliothek->addOrt($_POST['ort_name'] ?? '');
                $meldung = 'Ort wurde gespeichert.';
                $seite = 'orte';
                break;

            case 'verlag_anlegen':
                $bibliothek->addVerlag(
                    $_POST['verlag_name'] ?? '',
                    (int)($_POST['ort_id'] ?? 0)
                );
                $meldung = 'Verlag wurde gespeichert.';
                $seite = 'verlage';
                break;

            case 'autor_anlegen':
                $bibliothek->addAutor(
                    $_POST['autor_name'] ?? '',
                    (int)($_POST['jahrgang'] ?? 0)
                );
                $meldung = 'Autor wurde gespeichert.';
                $seite = 'autoren';
                break;

            case 'buch_anlegen':
                $bibliothek->addBuch(
                    $_POST['titel'] ?? '',
                    $_POST['isbn'] ?? '',
                    (int)($_POST['seiten'] ?? 0),
                    (int)($_POST['verlag_id'] ?? 0),
                    is_array($_POST['autor_ids'] ?? null) ? $_POST['autor_ids'] : []
                );
                $meldung = 'Buch wurde gespeichert.';
                $seite = 'buecher';
                break;

            case 'ort_loeschen':
                $bibliothek->deleteOrt((int)($_POST['id'] ?? 0));
                $meldung = 'Ort wurde gelöscht.';
                $seite = 'orte';
                break;

            case 'verlag_loeschen':
                $bibliothek->deleteVerlag((int)($_POST['id'] ?? 0));
                $meldung = 'Verlag wurde gelöscht.';
                $seite = 'verlage';
                break;

            case 'autor_loeschen':
                $bibliothek->deleteAutor((int)($_POST['id'] ?? 0));
                $meldung = 'Autor wurde gelöscht.';
                $seite = 'autoren';
                break;

            case 'buch_loeschen':
                $bibliothek->deleteBuch((int)($_POST['id'] ?? 0));
                $meldung = 'Buch wurde gelöscht.';
                $seite = 'buecher';
                break;
        }
    } catch (Throwable $e) {
        // Falls ein Fehler auftritt, Fehlermeldung speichern
        $fehler = $e->getMessage();
    }
}

// Alle Daten für die Ausgabe laden
$orte = $bibliothek->getOrte();
$verlage = $bibliothek->getVerlage();
$autoren = $bibliothek->getAutoren();
$buecher = $bibliothek->getBuecher();
?>
<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <title>Bibliothekssystem</title>
    <style> /* Styles für das HTML-Formular */
        body {
            font-family: Arial, sans-serif;
            background: #f4f6f8;
            margin: 0;
            padding: 0;
        }

        header {
            background: #243447;
            color: white;
            padding: 20px;
        }

        header h1 {
            margin: 0;
        }

        nav {
            background: #324a5f;
            padding: 12px;
        }

        nav a {
            display: inline-block;
            color: white;
            text-decoration: none;
            margin: 4px 8px 4px 0;
            padding: 8px 12px;
            background: #486581;
            border-radius: 6px;
        }

        nav a:hover {
            background: #5b7c99;
        }

        main {
            max-width: 1000px;
            margin: 25px auto;
            background: white;
            padding: 25px;
            border-radius: 10px;
            box-shadow: 0 2px 12px rgba(0,0,0,0.1);
        }

        .msg {
            padding: 12px;
            border-radius: 6px;
            margin-bottom: 16px;
        }

        .ok {
            background: #e7f7ea;
            color: #1f6b2a;
            border: 1px solid #b7e1c0;
        }

        .err {
            background: #fdeaea;
            color: #8b1e1e;
            border: 1px solid #f0b5b5;
        }

        form {
            background: #f9fbfc;
            padding: 16px;
            border: 1px solid #d7e0e7;
            border-radius: 8px;
            margin-bottom: 24px;
        }

        label {
            display: block;
            margin-top: 12px;
            margin-bottom: 4px;
            font-weight: bold;
        }

        input, select {
            width: 100%;
            padding: 10px;
            border: 1px solid #b8c4ce;
            border-radius: 6px;
            box-sizing: border-box;
        }

        select[multiple] {
            min-height: 130px;
        }

        button {
            margin-top: 16px;
            padding: 10px 16px;
            border: none;
            background: #243447;
            color: white;
            border-radius: 6px;
            cursor: pointer;
        }

        button:hover {
            background: #1a2733;
        }

        .btn-loeschen {
            background: #a12626;
            margin-top: 10px;
        }

        .btn-loeschen:hover {
            background: #7d1d1d;
        }

        .karte {
            background: #eef3f7;
            padding: 14px;
            border-radius: 8px;
            margin-bottom: 12px;
            border-left: 5px solid #324a5f;
        }

        .grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(220px, 1fr));
            gap: 15px;
        }

        .inline-form {
            margin-top: 10px;
            padding: 0;
            border: none;
            background: transparent;
        }
    </style>
</head>
<body>

<header>
    <h1>Bibliothekssystem</h1>
</header>

<nav>
    <a href="?seite=start">Start</a>
    <a href="?seite=orte">Orte</a>
    <a href="?seite=verlage">Verlage</a>
    <a href="?seite=autoren">Autoren</a>
    <a href="?seite=buecher">Bücher</a>
    <a href="?seite=statistik">Statistik</a>
</nav>

<main>
    <!-- Erfolgsnachricht anzeigen -->
    <?php if ($meldung !== ''): ?>
        <div class="msg ok"><?= h($meldung) ?></div>
    <?php endif; ?>

    <!-- Fehlermeldung anzeigen -->
    <?php if ($fehler !== ''): ?>
        <div class="msg err"><?= h($fehler) ?></div>
    <?php endif; ?>

    <!-- Startseite -->
    <?php if ($seite === 'start'): ?>
        <h2>Willkommen</h2>
        <p>Hier kannst du Orte, Verlage, Autoren und Bücher direkt über Formulare verwalten.</p>

        <div class="grid">
            <div class="karte"><strong>Orte:</strong><br><?= $bibliothek->count('ort') ?></div>
            <div class="karte"><strong>Verlage:</strong><br><?= $bibliothek->count('verlag') ?></div>
            <div class="karte"><strong>Autoren:</strong><br><?= $bibliothek->count('autor') ?></div>
            <div class="karte"><strong>Bücher:</strong><br><?= $bibliothek->count('buch') ?></div>
        </div>

    <!-- Seite Orte -->
    <?php elseif ($seite === 'orte'): ?>
        <h2>Orte</h2>

        <form method="post">
            <input type="hidden" name="aktion" value="ort_anlegen">
            <label for="ort_name">Ortname</label>
            <input type="text" id="ort_name" name="ort_name" required>
            <button type="submit">Ort speichern</button>
        </form>

        <h3>Vorhandene Orte</h3>
        <?php foreach ($orte as $ort): ?>
            <div class="karte">
                <?= h($ort['name']) ?>

                <form method="post" class="inline-form" onsubmit="return confirm('Ort wirklich löschen?');">
                    <input type="hidden" name="aktion" value="ort_loeschen">
                    <input type="hidden" name="id" value="<?= (int)$ort['id'] ?>">
                    <button type="submit" class="btn-loeschen">Löschen</button>
                </form>
            </div>
        <?php endforeach; ?>

    <!-- Seite Verlage -->
    <?php elseif ($seite === 'verlage'): ?>
        <h2>Verlage</h2>

        <?php if (empty($orte)): ?>
            <div class="msg err">Bitte zuerst mindestens einen Ort anlegen.</div>
        <?php else: ?>
            <form method="post">
                <input type="hidden" name="aktion" value="verlag_anlegen">
                <label for="verlag_name">Verlagsname</label>
                <input type="text" id="verlag_name" name="verlag_name" required>

                <label for="ort_id">Firmensitz</label>
                <select id="ort_id" name="ort_id" required>
                    <option value="">Bitte wählen</option>
                    <?php foreach ($orte as $ort): ?>
                        <option value="<?= (int)$ort['id'] ?>"><?= h($ort['name']) ?></option>
                    <?php endforeach; ?>
                </select>

                <button type="submit">Verlag speichern</button>
            </form>
        <?php endif; ?>

        <h3>Vorhandene Verlage</h3>
        <?php foreach ($verlage as $verlag): ?>
            <div class="karte">
                <strong><?= h($verlag['name']) ?></strong><br>
                Firmensitz: <?= h($verlag['ort_name']) ?>

                <form method="post" class="inline-form" onsubmit="return confirm('Verlag wirklich löschen?');">
                    <input type="hidden" name="aktion" value="verlag_loeschen">
                    <input type="hidden" name="id" value="<?= (int)$verlag['id'] ?>">
                    <button type="submit" class="btn-loeschen">Löschen</button>
                </form>
            </div>
        <?php endforeach; ?>

    <!-- Seite Autoren -->
    <?php elseif ($seite === 'autoren'): ?>
        <h2>Autoren</h2>

        <form method="post">
            <input type="hidden" name="aktion" value="autor_anlegen">
            <label for="autor_name">Name</label>
            <input type="text" id="autor_name" name="autor_name" required>

            <label for="jahrgang">Jahrgang</label>
            <input type="number" id="jahrgang" name="jahrgang" required>

            <button type="submit">Autor speichern</button>
        </form>

        <h3>Vorhandene Autoren</h3>
        <?php foreach ($autoren as $autor): ?>
            <div class="karte">
                <strong><?= h($autor['name']) ?></strong><br>
                Jahrgang: <?= (int)$autor['jahrgang'] ?>

                <form method="post" class="inline-form" onsubmit="return confirm('Autor wirklich löschen?');">
                    <input type="hidden" name="aktion" value="autor_loeschen">
                    <input type="hidden" name="id" value="<?= (int)$autor['id'] ?>">
                    <button type="submit" class="btn-loeschen">Löschen</button>
                </form>
            </div>
        <?php endforeach; ?>

    <!-- Seite Bücher -->
    <?php elseif ($seite === 'buecher'): ?>
        <h2>Bücher</h2>

        <?php if (empty($verlage) || empty($autoren)): ?>
            <div class="msg err">Für Bücher brauchst du mindestens einen Verlag und einen Autor.</div>
        <?php else: ?>
            <form method="post">
                <input type="hidden" name="aktion" value="buch_anlegen">

                <label for="titel">Titel</label>
                <input type="text" id="titel" name="titel" required>

                <label for="isbn">ISBN</label>
                <input type="text" id="isbn" name="isbn" required>

                <label for="seiten">Seiten</label>
                <input type="number" id="seiten" name="seiten" min="1" required>

                <label for="verlag_id">Verlag</label>
                <select id="verlag_id" name="verlag_id" required>
                    <option value="">Bitte wählen</option>
                    <?php foreach ($verlage as $verlag): ?>
                        <option value="<?= (int)$verlag['id'] ?>">
                            <?= h($verlag['name']) ?> (<?= h($verlag['ort_name']) ?>)
                        </option>
                    <?php endforeach; ?>
                </select>

                <label for="autor_ids">Autoren</label>
                <select id="autor_ids" name="autor_ids[]" multiple required>
                    <?php foreach ($autoren as $autor): ?>
                        <option value="<?= (int)$autor['id'] ?>">
                            <?= h($autor['name']) ?> (<?= (int)$autor['jahrgang'] ?>)
                        </option>
                    <?php endforeach; ?>
                </select>

                <button type="submit">Buch speichern</button>
            </form>
        <?php endif; ?>

        <h3>Vorhandene Bücher</h3>
        <?php foreach ($buecher as $buch): ?>
            <div class="karte">
                <strong><?= h($buch['titel']) ?></strong><br>
                ISBN: <?= h($buch['isbn']) ?><br>
                Seiten: <?= (int)$buch['seiten'] ?><br>
                Verlag: <?= h($buch['verlag_name']) ?><br>
                Autoren: <?= h(implode(', ', $buch['autoren'])) ?>

                <form method="post" class="inline-form" onsubmit="return confirm('Buch wirklich löschen?');">
                    <input type="hidden" name="aktion" value="buch_loeschen">
                    <input type="hidden" name="id" value="<?= (int)$buch['id'] ?>">
                    <button type="submit" class="btn-loeschen">Löschen</button>
                </form>
            </div>
        <?php endforeach; ?>

    <!-- Seite Statistik -->
    <?php elseif ($seite === 'statistik'): ?>
        <h2>Statistik</h2>

        <div class="grid">
            <div class="karte"><strong>Orte:</strong><br><?= $bibliothek->count('ort') ?></div>
            <div class="karte"><strong>Verlage:</strong><br><?= $bibliothek->count('verlag') ?></div>
            <div class="karte"><strong>Autoren:</strong><br><?= $bibliothek->count('autor') ?></div>
            <div class="karte"><strong>Bücher:</strong><br><?= $bibliothek->count('buch') ?></div>
            <div class="karte"><strong>Gesamtseiten:</strong><br><?= $bibliothek->totalSeiten() ?></div>
        </div>

    <!-- Falls ungültige Seite aufgerufen wurde -->
    <?php else: ?>
        <h2>Seite nicht gefunden</h2>
    <?php endif; ?>
</main>

</body>
</html>
