# Reflexionsfragen – Modul 14 – Flexbox
**Name:** Taylor Renee Kofler  
**Modul:** 14 – CSS Flex Layout

---

### 14.1 Wie werden die beiden Achsen bezeichnet, an denen sich die Flex-Item ausrichten?
Die beiden Achsen heißen:
- **main axis** (Hauptachse): standardmäßig horizontal (von links nach rechts)
- **cross axis** (Kreuzachse): standardmäßig vertikal (von oben nach unten)

---

### 14.2 Erklären Sie die Begriffe „Eltern-Element“, „Kind-Element“ und „Nachfahre“ im Zusammenhang mit einer HTML-Struktur!
- **Eltern-Element** (Parent): Ein Element, das ein anderes Element direkt enthält.
- **Kind-Element** (Child): Ein Element, das direkt innerhalb eines anderen Elements liegt.
- **Nachfahre** (Descendant): Ein Element, das irgendwo innerhalb eines anderen Elements liegt – auch verschachtelt.

Beispiel:
```html
<div>        <!-- Eltern -->
  <p>Text</p>  <!-- Kind -->
</div>
```

---

### 14.3 Welche CSS-Regel (Flex-Layout) müssen Sie wählen, um Elemente von rechts nach links horizontal anzuordnen?
```css
flex-direction: row-reverse;
```

---

### 14.4 Unterschied zwischen `flex-direction: row-reverse;` und `flex-wrap: wrap-reverse;`
- `flex-direction: row-reverse;` ändert die **Richtung** der Hauptachse (z. B. von links nach rechts → rechts nach links).
- `flex-wrap: wrap-reverse;` kehrt die **Richtung der Zeilenumbrüche** entlang der Kreuzachse um (z. B. Zeilen von unten nach oben statt von oben nach unten).

---

### 14.5 In welchem Teil eines Flex-Layouts verwenden Sie die Eigenschaft `order`?
Die Eigenschaft `order` wird im **Flex-Item** verwendet, nicht im Container.

---

### 14.6 Was passiert bei gleichen `order`-Werten?
Wenn zwei Elemente denselben `order`-Wert besitzen, bestimmt die **Reihenfolge im HTML-Code**, welches zuerst erscheint.

---

### 14.7 Wo befindet sich ein Element ohne `order`?
Ein Element ohne gesetzte `order`-Eigenschaft hat standardmäßig `order: 0`. Es wird **an seiner Stelle im HTML-Code** angezeigt – abhängig von anderen `order`-Werten.