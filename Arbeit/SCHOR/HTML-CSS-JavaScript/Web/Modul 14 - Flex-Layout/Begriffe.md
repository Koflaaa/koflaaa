|| **Begriffe** | **Definition** |
|-| - | - |
|14.1| Wie werden die beiden Achsen bezeichnet, an denen sich die Flex-Item ausrichten? | main und cross axis |
|14.2| Erklären Sie die Begriffe ***„Eltern-Element“***, ***„Kind-Element“*** und ***„Nachfahre“*** im Zusammenhang
mit einer HTML-Struktur! | Ist ein Element welches ein anderes Element enthält. Z.B.  ````<html><article></article></html> ```` html is das parent element während article das child element ist. Ein Nachfahre wäre  ```` <li></li> in <ul></ul> ```` |
|14.3| Welche CSS-Regel (Flex-Layout) müssen Sie wählen, um Elemente von rechts nach links
horizontal anzuordnen? | Row |
|14.4| flex-direction: row-reverse | Ändert die Fließrichtung des horizontalen Textes von links -> rechts zu recht -> links |
|14.4.1| flex-direction: reverse-wrap | Ändert die Anordnung der Elemente von oben -> unten zu unten -> oben |
|14.5| In welchem Teil des CSS-Codes befindet sich 'order' (flex-container, flex-item, flex-growth) | 'order' wird in den flex-items verwendet um dessen Anordnung gezielt zu steuern bzw. zu ändern |
|14.6| Positionierung ohne 'order' | Z.B. Align-items (vertikal) und justify-content (horizontal) |
|14.7| Was passiert, wenn Sie Elemente mit „order“ formatieren und zwei Elementen die gleiche Zahl |
als Wert zuweisen? | Die Elemente orientieren sich nach Anordnung der HTML-Elemente |
|14.7| Gleiche breite bei flex |  |