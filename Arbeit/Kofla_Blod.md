# Insert, Update, Delete: Wie ein „provisorisches" Startup-Schema mir fast den Feierabend versaut hat

*Geschrieben von einem Applikationsentwickler im 4. Lehrjahr · Lesezeit: ca. 15–20 Minuten*

## Einleitung: Warum ich fast einen Herzinfarkt bekommen habe, bloß weil jemand eine neue Abteilung anlegen wollte

Moin! Willkommen auf meinem Blog. Heute geht's um ein Thema, das man in der Berufsschule gerne mal mit einem müden Seufzer abtut – Datenbank-Normalisierung. Ich bin gerade im 4. Lehrjahr als Applikationsentwickler, und wenn ich eins in den letzten Jahren gelernt habe, dann das: Eine Datenbank, die „irgendwie funktioniert", ist meistens nur eine Änderung von einer Katastrophe entfernt.

Stellt euch folgendes Szenario vor, das mir kürzlich in einem (fiktiven, aber schmerzhaft realistischen) Übungsprojekt passiert ist: Ein Startup ist gewachsen, und das ursprüngliche „wir-hacken-das-schnell-in-eine-Tabelle"-Setup muss dringend refactored werden, bevor es explodiert. Egal ob ich gerade in C#, PHP oder Python unterwegs bin, ob die Daten in einer MariaDB, PostgreSQL oder einem SQL Server liegen – das Grundproblem ist immer dasselbe: Wer beim Tabellendesign schlampt, handelt sich Insert-, Update- und Delete-Anomalien ein. Und genau die zerlege ich euch heute anhand von acht Praxisfällen, die mir auf einem Aufgabenblatt zu genau diesem Thema untergekommen sind.

Holt euch also euer Lieblingskuscheltier, damit ihr nicht alleine leiden müsst, und lasst uns eintauchen in die Welt der bösen, relationalen Datenbanken, kaputter Primärschlüssel und der Frage, warum euer zukünftiges Ich euch dankbar sein wird, wenn ihr das hier einmal richtig verinnerlicht.

Kleine Triggerwarnung vorweg: Ich werde in diesem Beitrag mehrfach das Wort „Redundanz" verwenden. Das ist Absicht. Redundanz ist nämlich fast immer die Wurzel allen Übels, wenn es um Anomalien geht – und sobald man einmal gelernt hat, sie zu erkennen, sieht man sie überall. In jeder Legacy-Codebase, in jedem hastig zusammengeklickten Prototyp, und ja, auch in so manchem produktiven System, das seit Jahren klaglos vor sich hinläuft. „Never Touch A Running System" und so.

## Die Theorie kurz und schmerzlos: Was ist eine Anomalie überhaupt?

Bevor wir in den Code einsteigen, kurz die Basics. In der Datenbanktheorie – nachzulesen zum Beispiel bei Elmasri und Navathe in „Fundamentals of Database Systems" – spricht man von einer Anomalie, wenn ein schlecht entworfenes Tabellenschema dazu führt, dass CRUD-nahe Operationen (Insert, Update, Delete) unerwünschte Nebenwirkungen haben.

Die Ursache ist praktisch immer dieselbe: Redundanz. Wenn eine Information – der Name einer Abteilung, die Support-Adresse eines Anbieters, die Notfallnummer eines Account Managers – mehrfach in derselben Tabelle herumliegt, öffnet das die Tür für drei Typen von Anomalien:

- Insert-Anomalie: Ich kann etwas Sinnvolles nicht einfügen, ohne gleichzeitig unabhängige Daten mitliefern oder Platzhalter erfinden zu müssen.
- Update-Anomalie: Eine Änderung muss an mehreren Stellen gleichzeitig passieren – vergisst man eine, widersprechen sich die Daten.
- Delete-Anomalie: Beim Löschen eines Datensatzes reißt man versehentlich Wissen über ein ganz anderes Objekt mit.

Elmasri und Navathe leiten daraus die zweite ihrer informellen Entwurfsrichtlinien ab: Ein Schema sollte so gebaut sein, dass gar keine dieser Anomalien auftreten kann – und falls doch, sollten sie zumindest bewusst dokumentiert und über Anwendungslogik abgefangen werden.

Was mir persönlich am Anfang schwergefallen ist: Anomalien sieht man einer Tabelle nicht sofort an. Solange man nur SELECT-Statements schreibt, sieht alles wunderbar aus – erst wenn INSERT, UPDATE oder DELETE ins Spiel kommen, zeigt sich, ob das Schema hält, was es verspricht. Deshalb reicht es auch nicht, sich nur die Struktur einer Tabelle anzuschauen. Man muss sich aktiv vorstellen, wie sich die drei Grundoperationen auf konkrete, reale Szenarien auswirken. Genau das machen wir jetzt, Fall für Fall.

### Anomalie 1: Die Insert-Anomalie (Wenn die Datenbank dich zwingt, etwas zu erfinden)

Die Insert-Anomalie tritt auf, wenn du eine eigentlich unabhängige Information nicht speichern kannst, ohne zusätzlich Daten zu einem ganz anderen Objekt mitzuliefern – meistens, weil der Primärschlüssel schlecht gewählt ist.

#### Fall 1: Die Abteilung, die es offiziell nicht geben darf

Nehmen wir an, unsere Mitarbeiter und deren Abteilungen liegen in einer einzigen Tabelle:

```sql
CREATE TABLE Coworkers (
  EmployeeID    INT PRIMARY KEY,
  Name          VARCHAR (100),
  Department    VARCHAR (100),
  DeptBudget    DECIMAL (10,2)
);

-- Aktueller Stand:
-- 101 | Bauer   | Marketing | 50000
-- 102 | Schmidt | IT        | 120000
```

Primärschlüssel ist EmployeeID – jede Zeile ist also in erster Linie ein Mitarbeiter, keine Abteilung. Jetzt will das Management die neue Abteilung „R&D" gründen, aber noch niemanden dafür einstellen. Versuchen wir das trotzdem einzufügen:

```sql
INSERT INTO Coworkers (EmployeeID, Name, Department, DeptBudget)
VALUES (NULL, NULL, 'R&D', 90000);

-- ERROR 1048 (23000): Column 'EmployeeID' cannot be null
```

Booom. Die Datenbank meckert zurecht: EmployeeID ist Primärschlüssel und darf laut Entity-Integrität niemals NULL sein. Genau dieses Muster beschreiben Elmasri und Navathe wortwörtlich als zweite Variante der Insert-Anomalie – es ist unmöglich, eine neue Abteilung ohne zugehörige Mitarbeiter anzulegen, ohne Nullwerte in eigentlich unpassenden Feldern zu platzieren. Die einzige „Lösung", die viele Teams unter Zeitdruck wählen: einen Fake-Mitarbeiter mit EmployeeID 999 und Namen „N/A" anlegen. Und genau solche Workarounds sind der Anfang vom Ende jeder sauberen Datenbank.

#### Fall 2: Der Skill, den noch niemand kann

Ein subtilerer Fall derselben Anomalie taucht auf, wenn man Skills direkt in die Mitarbeitertabelle packt:

| EmployeeID | Name  | OfficeLocation | Skill |
|------------|-------|-----------------|-------|
| E-101      | Weber | Vienna          | Go    |
| E-102      | Huber | Zurich          | Rust  |

Will man den neuen Skill „Distributed Systems Architecture" ins System aufnehmen, bevor ihn irgendjemand im Team tatsächlich beherrscht, geht das nicht – der Skill existiert in diesem Schema nur als Anhängsel einer konkreten EmployeeID. Man müsste also eine Person „erfinden", die diesen Skill hat, nur um ihn überhaupt in der Datenbank zu haben. Nebenbei wird hier auch noch OfficeLocation für jede weitere Skill-Zeile derselben Person unnötig wiederholt – eine Steilvorlage für die nächste Anomalie.

### Anomalie 2: Die Update-Anomalie (Wenn eine Änderung sich nicht überall durchsetzt)

Die Update-Anomalie schlägt zu, wenn dieselbe Information mehrfach gespeichert ist und eine Änderung nicht konsequent an allen Stellen nachgezogen wird.

#### Fall 3: Der Vendor mit der gespaltenen Persönlichkeit

| LicenseKey | Vendor    | VendorSupportEmail                | RenewalCost |
|------------|-----------|-------------------------------------|-------------|
| LIC-881    | CloudCorp | enterprise-support@cloudcorp.com    | 1200        |
| LIC-882    | CloudCorp | support@cloudcorp.com               | 4500        |
| LIC-883    | CloudCorp | support@cloudcorp.com               | 800         |

CloudCorp ändert seine primäre Support-Adresse. Die Kollegin aus dem Einkauf feuert folgendes Update ab:

```sql
UPDATE Licenses
SET VendorSupportEmail = 'enterprise-support@cloudcorp.com'
WHERE LicenseKey = 'LIC-881';
```

Technisch läuft die Query fehlerfrei durch – „Query OK, 1 row affected". Das Problem: LIC-882 und LIC-883 tragen weiterhin die alte Adresse. Fragt man die Datenbank jetzt, „welche" Support-E-Mail CloudCorp hat, bekommt man je nach Lizenz zwei unterschiedliche Antworten. Support-E-Mail ist eine Eigenschaft des Vendors, nicht der einzelnen Lizenz – und genau diese falsche Zuordnung ist der Kern jeder Update-Anomalie.

#### Fall 4: Der Abteilungsleiter mit drei verschiedenen Meinungen

| ProjectID | Employee | Department | DepartmentLead |
|-----------|----------|------------|-----------------|
| P-01      | Maier    | IT         | Dr. Schwarz     |
| P-02      | Mueller  | Marketing  | Fr. Berger      |
| P-03      | Schmidt  | IT         | Dr. Schwarz     |
| P-04      | Krainer  | IT         | Prof. Weiss     |

Wechselt die IT-Leitung, muss man wissen, dass gleich drei Zeilen (P-01, P-03, P-04) betroffen sind. Ein simples UPDATE mit WHERE Department = 'IT' erledigt das zwar technisch in einer einzigen Query – aber nur, wenn man daran denkt und niemand zwischenzeitlich ein neues IT-Projekt mit dem alten Leitungsnamen anlegt. Genau dieses Risiko wächst mit jeder zusätzlichen redundanten Zeile, und in einem System mit mehreren Entwicklern, die parallel schreiben, ist das keine Frage von ob, sondern von wann es schiefgeht.

### Anomalie 3: Die Delete-Anomalie (Der Klassiker: Löschen mit Kollateralschaden)

Für mich persönlich die gemeinste der drei Anomalien, weil sie oft erst auffällt, wenn es zu spät ist: Man löscht einen Datensatz und verliert dabei ungewollt Informationen über ein völlig anderes Objekt.

#### Fall 5: Projekt Alpha nimmt die Abteilung mit ins Grab

| ProjectID | ProjectName | Department | DepartmentLocation |
|-----------|-------------|------------|---------------------|
| P01       | Alpha       | R&D        | B.02.13             |
| P02       | Beta        | Marketing  | B.01.12             |

Projekt Alpha ist fertig, also löschen wir es:

```sql
DELETE FROM Projects WHERE ProjectID = 'P01';
-- Query OK, 1 row affected.
```

Nur: B.02.13 als Standort der Abteilung R&D war nirgendwo sonst gespeichert – dieser Fakt hing komplett an dieser einen Zeile. Mit dem Projekt verschwindet also auch das Wissen, wo sich R&D überhaupt befindet, obwohl die Abteilung selbstverständlich weiterexistiert. Genau dieses Muster beschreiben Elmasri und Navathe: Löscht man die letzte Zeile, die ein Objekt referenziert, ist dessen Information komplett futsch.

#### Fall 6: Novaks verschwundene Notfallnummer

| ClientId | ClientName | AccountManager | ManagerEmergencyPhone |
|----------|------------|-----------------|-------------------------|
| C-301    | AcmeCorp   | Novak           | +43-664-0001            |
| C-302    | Globex     | Novak           | +43-664-0001            |
| C-303    | Initech    | Gruber          | +43-664-0002            |

Werden AcmeCorp und Globex – Novaks einzige Kundenprojekte – beide abgeschlossen und aus dem aktiven Tracker gelöscht, verschwindet auch Novaks Notfallnummer aus der Datenbank. Novak selbst ist aber weiterhin bei uns angestellt und müsste im Ernstfall erreichbar sein. Das Problem: Seine Personendaten existieren in diesem Schema nur, solange mindestens ein Projekt an ihn hängt – eine strukturelle Sollbruchstelle, die man sich mit ein bisschen schlechtem Timing schmerzhaft einfängt.

### Bonus-Runde: Wenn zwei Anomalien im selben System gleichzeitig zuschlagen

So richtig gemein wird es, wenn ein Schema mit zusammengesetzten Primärschlüsseln arbeitet – dann können Insert- und Delete-Anomalie im selben Vorgang gleichzeitig auftreten. Zwei Beispiele aus dem Infrastruktur-Alltag:

#### Die Cluster-Registry, die keine leeren Regionen kennt

| ServiceID | ServiceName | ClusterId | Region  | RegionMaxNodes |
|-----------|-------------|-----------|---------|-----------------|
| S-01      | Auth        | C-East-1  | us-east | 500             |
| S-02      | Billing     | C-East-1  | us-east | 500             |
| S-03      | Metrics     | C-West-1  | us-west | 250             |

Primärschlüssel ist (ServiceID, ClusterId). Zwei Dinge sollen gleichzeitig passieren: Erstens soll die neue Region eu-central mit RegionMaxNodes = 300 angelegt werden, bevor überhaupt ein Service dorthin deployt. Das scheitert aus demselben Grund wie unsere Abteilung „R&D" weiter oben – eine Insert-Anomalie, weil Region-Daten nur an einer konkreten (ServiceID, ClusterId)-Zeile hängen können. Zweitens wird S-03 gestoppt und gelöscht, der einzige Service in C-West-1 – womit auch jede Information über diesem Cluster und die Region us-west verschwindet. Eine waschechte Delete-Anomalie, huckepack mit der Insert-Anomalie.

#### Die API-Gateway-Registry und der Tarif, den niemand kennt

| RoutePath     | ServiceID   | RateLimitTier | MaxRequestsPerMin |
|----------------|-------------|----------------|---------------------|
| /v2/auth       | S-Auth      | Tier-Standard  | 1000                |
| /v2/payments   | S-Billing   | Tier-High      | 5000                |
| /v1/telemetry  | S-Telemetry | Tier-Low       | 200                 |

Gleiches Spiel: Der neue Tarif Tier-Enterprise (10.000 Requests/Min) soll existieren, bevor ihm irgendeine Route zugeordnet ist – Insert-Anomalie, weil RateLimitTier nur zusammen mit einer konkreten RoutePath/ServiceID-Kombination gespeichert werden kann. Und wird /v1/telemetry – die einzige Route zu S-Telemetry und zum Tarif Tier-Low – als veraltet entfernt, verschwinden gleich zwei Fakten auf einmal: dass es den Service S-Telemetry gibt, und dass Tier-Low ein Limit von 200 Requests pro Minute hat. Zwei Anomalien, ein DELETE-Statement.

## Die Rettung: Normalisierung statt Datenbank-Roulette

Wie kommen wir daraus? Mit derselben Antwort, die euch jede Berufsschullehrkraft um die Ohren haut: Normalisierung. Das Prinzip dahinter ist simpel – jedes Attribut sollte nur an dem Schlüssel hängen, zu dem es inhaltlich auch gehört. Elmasri und Navathe formalisieren das über funktionale Abhängigkeiten: Eine Menge von Attributen X bestimmt eindeutig eine andere Menge Y, wenn zu jedem X-Wert immer derselbe Y-Wert gehört.

### Normalformen – „Der Schlüssel, der ganze Schlüssel und nichts als der Schlüssel"

#### Normalform (1NF – Der Schlüssel)

Jede Zeile enthält nur einen einzelnen, atomaren Wert (keine Listen oder kommagetrennten Werte in einer Spalte), und es gibt einen eindeutigen Primärschlüssel.

#### Normalform (2NF – der ganze Schlüssel)

1NF plus: Jedes Nicht-Schlüssel-Attribut muss von der gesamten Kombination des Primärschlüssels (PK) abhängen – nicht nur von einem Teil davon. Das ist nur relevant, wenn der Schlüssel aus mehreren Spalten besteht, sprich zusammengesetzter PK.

#### Normalform (3NF – nichts als der Schlüssel)

2NF plus: Kein Nicht-Schlüssel-Attribut darf von einem anderen Nicht-Schlüssel-Attribut abhängig sein. D. h. jedes Attribut muss direkt von einem Schlüssel abhängig sein.

Auf dieser Basis lässt sich systematisch prüfen, ob eine Tabelle in eine Normalform gebracht werden kann.

Für unsere acht Fälle heißt das konkret: Mitarbeiter und Abteilungen, Lizenzen und Vendoren, Projekte und Abteilungsstandorte, Cluster/Regionen und Services, Rate-Limit-Tiers und Routen – jedes dieser Konzepte bekommt seine eigene Tabelle mit eigenem Primärschlüssel, verbunden über Fremdschlüssel. Aus unserer Coworkers-Tabelle würde zum Beispiel:

```sql
CREATE TABLE Departments (
  DepartmentID    VARCHAR (50) PRIMARY KEY,
  DeptBudget      DECIMAL (10,2)
);

CREATE TABLE Employees (
  EmployeeID      INT PRIMARY KEY,
  Name            VARCHAR (100),
  DepartmentID    VARCHAR (50) REFERENCES Departments (DepartmentID)
);
```

Jetzt kann R&D angelegt werden, ganz ohne Fake-Mitarbeiter. Ändert sich der Abteilungsleiter, wird genau eine Zeile in Departments aktualisiert. Und löscht man ein Projekt, bleibt die Abteilung unberührt in ihrer eigenen Tabelle stehen. Dieselbe Logik gilt eins zu eins für Vendoren/Lizenzen, Cluster/Services und Rate-Limit-Tiers/Routen.

## Praxis: Und wie frage ich das jetzt ab, ohne mir die Finger wund zu joinen?

Klar, aus einer Tabelle werden jetzt zwei oder drei. Aber genau dafür sind relationale Datenbanken gebaut. Egal ob MariaDB, PostgreSQL oder SQL Server, egal ob Backend in C#, PHP oder Python geschrieben – ein sauberer JOIN ist keine Raketenwissenschaft:

```sql
SELECT e.Name, d.DepartmentID, d.DeptBudget
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID;
```

Und wenn ich auch neue Mitarbeiter sehen will, die noch keiner Abteilung zugeordnet sind, hilft ein LEFT JOIN:

```sql
SELECT e.Name, d.DepartmentID
FROM Employees e
LEFT JOIN Departments d ON e.DepartmentID = d.DepartmentID;
```

In Laravel würde man das über Eloquent-Relations abbilden (belongsTo, hasMany), in .NET über Entity Framework Navigation Properties – das Prinzip bleibt dasselbe. Ein ORM nimmt einem die SQL-Schreibarbeit ab, aber relationales Denken muss man trotzdem intus haben. Wenn das Schema drunter Murks ist, rettet einen auch das schickste ORM nicht mehr.

Für komplexere Auswertungen – etwa, wenn ich für ein Reporting-Feature Mitarbeiter, deren Abteilung und alle laufenden Projekte in einer einzigen Ansicht brauche – greife ich gerne auf Common Table Expressions zurück, weil sie den Code lesbar halten, statt fünf JOINs ineinander zu verschachteln:

```sql
WITH DeptInfo AS (
  SELECT DepartmentID, DeptBudget FROM Departments
)
SELECT e.Name, di.DepartmentID, di.DeptBudget
FROM Employees e
JOIN DeptInfo di ON e.DepartmentID = di.DepartmentID;
```

Der Mehraufwand beim Lesen ist also überschaubar – und er wiegt die gewonnene Datenintegrität um Längen auf. Kein Vergleich zu der Zeit, die man in einer einzigen Riesentabelle mit dem Aufspüren von Inkonsistenzen verbringt, sobald die Anwendung erstmal in Produktion läuft und mehrere Leute gleichzeitig schreibend zugreifen.

## Bonus-Gedanken: Wann Denormalisierung doch mal okay ist

Ich habe jetzt gefühlt eine Ewigkeit gepredigt, wie böse Redundanz ist. Trotzdem gibt es Situationen, in denen man bewusst dagegen verstößt – Denormalisierung genannt. Der Hauptgrund dafür ist fast immer Performance: In Analytics-Dashboards oder Data-Warehouse-Systemen (OLAP), wo Millionen Zeilen in Millisekunden gelesen werden müssen, können zu viele Joins die Datenbank ausbremsen. Dort nimmt man Update- oder Insert-Anomalien bewusst in Kauf – oft abgefangen über ETL-Prozesse – um die Lesegeschwindigkeit auf flachen Tabellen zu maximieren.

Für die meisten Web-Anwendungen, die im Alltag entstehen – CRUD-Backends, interne Tools, Webshops – bleibt eine saubere Normalisierung trotzdem der Goldstandard. Denormalisiert wird nur mit einem handfesten, messbaren Grund, nicht aus Bequemlichkeit.

Ein Beispiel aus meinem eigenen Erfahrungsschatz: Für ein kleines Übungsprojekt mit SQLite als lokaler Datenhaltung habe ich anfangs bewusst mit einer flacheren Struktur gearbeitet, weil die Datenmenge überschaubar und der Lesezugriff viel wichtiger war als komplexe Schreiboperationen. Sobald aber mehrere Entitäten in echten Beziehungen zueinanderstehen – etwa Nutzer, Projekte und Rollen –, führt für mich kein Weg an einem sauber normalisierten Schema vorbei. Die Faustregel, die ich mir selbst mitgebe: normalisieren als Standard, denormalisieren nur mit handfesten Zahlen in der Hinterhand, die das rechtfertigen.

## Fazit: Ein bisschen Mehraufwand jetzt erspart euch ein Feuerwehreinsatz später

Egal ob privates Side-Project, Übungsaufgabe für die Berufsschule oder produktives Kundenprojekt: Nehmt euch die Zeit für euer Datenbankschema. Die Minuten, die man spart, indem man alles in eine große Tabelle wirft, zahlt man später in Stunden oder Tagen Debugging zurück. Insert-, Update- und Delete-Anomalien sind kein Zufall, sondern die logische Folge eines Schemas, das mehr Verantwortung trägt, als es sollte.

Die gute Nachricht: Sobald man weiß, wonach man suchen muss – repräsentiert jede Zeile wirklich nur ein Objekt? –, lassen sich diese Probleme in jedem Schema aufspüren und mit sauberer Normalisierung beheben. Stay relational, normalisiert eure Tabellen, und lasst euch von Anomalien nicht den Feierabend versauen. Bis zum nächsten Post!

## Appendix: Eine Checkliste fürs nächste Datenbankschema

1. Hat jede Tabelle einen eindeutigen Primärschlüssel?
2. Repräsentiert jede Zeile wirklich nur ein einziges Objekt der realen Welt – oder schleicht sich ein zweites mit ein?
3. Kann ich ein neues Objekt (z. B. eine Abteilung) anlegen, ohne ein anderes (z. B. einen Mitarbeiter) erfinden zu müssen? → Insert-Anomalie-Check!
4. Muss ich bei einer Änderung mehr als eine Zeile aktualisieren? → Update-Anomalie-Check!
5. Verliere ich beim Löschen eines Datensatzes Informationen über ein unabhängiges Objekt? → Delete-Anomalie-Check!
6. Bei zusammengesetzten Primärschlüsseln: Funktioniert Insert und Delete unabhängig für jeden Teil des Schlüssels?
7. Gibt es einen wirklich guten, messbaren Grund, hier bewusst zu denormalisieren – oder ist es nur Bequemlichkeit?

## Quellen

- Elmasri, R. & Navathe, S. B.: Fundamentals of Database Systems
- Pennings, E.: How to start a blog (the right way) and write posts people actually want to read
- Samuel Shaibu: Normalisierung in SQL (1NF - 5NF): Ein Leitfaden für Anfänger
- Internes Aufgabenblatt für die Beispieltabellen, zur Verfügung gestellt durch Hr. T. Auer