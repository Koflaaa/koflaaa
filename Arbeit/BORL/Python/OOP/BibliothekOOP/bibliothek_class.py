import sqlite3
from typing import Any


class Bibliothek:
    def __init__(self, db_path: str = "bibliothek.db"):
        self.db_path = db_path

    def _connect(self) -> sqlite3.Connection:
        conn = sqlite3.connect(self.db_path)
        conn.execute("PRAGMA foreign_keys = ON;")
        return conn

    def create_tables(self) -> None:
        with self._connect() as conn:
            cur = conn.cursor()

            cur.execute("""
                CREATE TABLE IF NOT EXISTS autor (
                    id   INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL UNIQUE
                );
            """)

            cur.execute("""
                CREATE TABLE IF NOT EXISTS genre (
                    id   INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL UNIQUE
                );
            """)

            # Duplikate verhindern:
            cur.execute("""
                CREATE TABLE IF NOT EXISTS buch (
                    id       INTEGER PRIMARY KEY AUTOINCREMENT,
                    titel    TEXT NOT NULL,
                    autor_id INTEGER NOT NULL,
                    genre_id INTEGER NOT NULL,
                    seiten   INTEGER NOT NULL CHECK (seiten >= 0),
                    FOREIGN KEY (autor_id) REFERENCES autor(id) ON DELETE RESTRICT,
                    FOREIGN KEY (genre_id) REFERENCES genre(id) ON DELETE RESTRICT,
                    UNIQUE (titel, autor_id, genre_id)
                );
            """)

            cur.execute("CREATE INDEX IF NOT EXISTS idx_buch_titel ON buch(titel);")
            cur.execute("CREATE INDEX IF NOT EXISTS idx_buch_autor_id ON buch(autor_id);")
            cur.execute("CREATE INDEX IF NOT EXISTS idx_buch_genre_id ON buch(genre_id);")

    def _get_or_create_autor_id(self, cur: sqlite3.Cursor, name: str) -> int:
        name = name.strip()
        if not name:
            raise ValueError("Autor-Name darf nicht leer sein.")

        cur.execute("INSERT OR IGNORE INTO autor (name) VALUES (?)", (name,))
        cur.execute("SELECT id FROM autor WHERE name = ?", (name,))
        row = cur.fetchone()
        if not row:
            raise RuntimeError("Konnte Autor-ID nicht ermitteln.")
        return int(row[0])

    def _get_or_create_genre_id(self, cur: sqlite3.Cursor, name: str) -> int:
        name = name.strip()
        if not name:
            raise ValueError("Genre-Name darf nicht leer sein.")

        cur.execute("INSERT OR IGNORE INTO genre (name) VALUES (?)", (name,))
        cur.execute("SELECT id FROM genre WHERE name = ?", (name,))
        row = cur.fetchone()
        if not row:
            raise RuntimeError("Konnte Genre-ID nicht ermitteln.")
        return int(row[0])

    def add_buch(self, titel: str, autor_name: str, genre_name: str, seiten: int) -> int:
        titel = titel.strip()
        autor_name = autor_name.strip()
        genre_name = genre_name.strip()

        if not titel:
            raise ValueError("Titel darf nicht leer sein.")
        if not autor_name:
            raise ValueError("Autor darf nicht leer sein.")
        if not genre_name:
            raise ValueError("Genre darf nicht leer sein.")
        if not isinstance(seiten, int) or seiten < 0:
            raise ValueError("Seiten muss eine ganze Zahl >= 0 sein.")

        with self._connect() as conn:
            cur = conn.cursor()
            autor_id = self._get_or_create_autor_id(cur, autor_name)
            genre_id = self._get_or_create_genre_id(cur, genre_name)

            # Versuch einzufügen. Wenn es ein Duplikat ist, wirft SQLite IntegrityError (wegen UNIQUE)
            try:
                cur.execute(
                    "INSERT INTO buch (titel, autor_id, genre_id, seiten) VALUES (?, ?, ?, ?)",
                    (titel, autor_id, genre_id, seiten),
                )
                return int(cur.lastrowid)
            except sqlite3.IntegrityError:
                # Buch existiert schon -> vorhandene ID zurückgeben
                cur.execute(
                    "SELECT id FROM buch WHERE titel = ? AND autor_id = ? AND genre_id = ?",
                    (titel, autor_id, genre_id),
                )
                row = cur.fetchone()
                if not row:
                    raise  # sollte praktisch nicht passieren
                return int(row[0])

    def get_autoren(self) -> list[dict[str, Any]]:
        with self._connect() as conn:
            cur = conn.cursor()
            cur.execute("SELECT id, name FROM autor ORDER BY name COLLATE NOCASE")
            rows = cur.fetchall()
        return [{"id": r[0], "name": r[1]} for r in rows]

    def get_genres(self) -> list[dict[str, Any]]:
        with self._connect() as conn:
            cur = conn.cursor()
            cur.execute("SELECT id, name FROM genre ORDER BY name COLLATE NOCASE")
            rows = cur.fetchall()
        return [{"id": r[0], "name": r[1]} for r in rows]

    def get_buecher(self) -> list[dict[str, Any]]:
        with self._connect() as conn:
            cur = conn.cursor()
            cur.execute("""
                SELECT b.id, b.titel, a.name, g.name, b.seiten
                FROM buch b
                JOIN autor a ON a.id = b.autor_id
                JOIN genre g ON g.id = b.genre_id
                ORDER BY b.titel COLLATE NOCASE
            """)
            rows = cur.fetchall()

        return [
            {"id": r[0], "titel": r[1], "autor": r[2], "genre": r[3], "seiten": r[4]}
            for r in rows
        ]

    def delete_buch(self, buch_id: int) -> bool:
        with self._connect() as conn:
            cur = conn.cursor()
            cur.execute("DELETE FROM buch WHERE id = ?", (buch_id,))
            return cur.rowcount > 0

    def delete_autor(self, autor_id: int) -> bool:
        try:
            with self._connect() as conn:
                cur = conn.cursor()
                cur.execute("DELETE FROM autor WHERE id = ?", (autor_id,))
                return cur.rowcount > 0
        except sqlite3.IntegrityError:
            return False

    def delete_genre(self, genre_id: int) -> bool:
        try:
            with self._connect() as conn:
                cur = conn.cursor()
                cur.execute("DELETE FROM genre WHERE id = ?", (genre_id,))
                return cur.rowcount > 0
        except sqlite3.IntegrityError:
            return False
