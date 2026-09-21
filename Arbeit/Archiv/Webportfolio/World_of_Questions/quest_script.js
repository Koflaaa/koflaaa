
   var nummer = 0;                 // Die aktuelle Nummer der Frage
   var fragen = 22;                // Anzahl aller Fragen
   var satz = 5;                   // Inhalte der Fragen
   var punkte = 0;                 // Anzah der ereichten Punkte
   var ende = 0;                   // Wenn alle Fragen durch, ende = 1
   var aus = 0;                    // Für Endsequenz
   var richtig = 0;                // Anzahl richtiger Antworten
   var klick = 0;                  // Feststellung was an geklickt wurde
   var richtigeAntwort = 0;        // Anazhl richtiger Antworten
   var falscheAnwtort = 0;		   // Anzahl falscher Antworten
   var Bewertung = " ";            // Bewertung  
   var Startzeit = 0;              // Startzeit
   var Endzeit = 0;                // Endzeit
   var aufgaben = new Array();     // Array für die Fragestellungen
   var antwort = new Array();      // Array für die Antworten

   antwort = [1,1,3,1,1,1,3,1,3,3,2,2,3,1,1,2,1,1,1,2,1,1];           // Antworten der Fragen 1 bis 21
       
     for (let i = 0; i < fragen; i++) 
     {
          aufgaben.push(new Array(satz).fill(0));                     // Initialisiert das Array und setzt den ganzen Inhalt auf Null
     }

     aufgaben[0][0] = "1.Frage"; aufgaben[0][1] = "Ist C# Objekt orientiert?";
     aufgaben[0][2] = "Ja"; aufgaben[0][3] = "Nein"; aufgaben[0][4] = "Weiß nicht";

     aufgaben[1][0] = "2.Frage"; aufgaben[1][1] = "Ok, wie erstellt man eine Ganzzahl in C#?";
     aufgaben[1][2] = "mit int";  aufgaben[1][3] = "mit double"; aufgaben[1][4] = "mit string";

     aufgaben[2][0] = "3.Frage"; aufgaben[2][1] = "Welches Betriebssystem existiert nicht?";
     aufgaben[2][2] = "Windows"; aufgaben[2][3] = "Cray"; aufgaben[2][4] = "Manix";

     aufgaben[3][0] = "4.Frage"; aufgaben[3][1] = "Cray ist ein Betriebssystem für...";
     aufgaben[3][2] = "Supercomputer"; aufgaben[3][3] = "AI-Systeme"; aufgaben[3][4] = "Navigation";

     aufgaben[4][0] = "5.Frage"; aufgaben[4][1] = "Wie groß kann 'bigInt' in JavaScript sein?";
     aufgaben[4][2] = "Bis zu Arbeitsspeichergröße";  aufgaben[4][3] = "Ca. 100 mal so groß wie double in C#"; aufgaben[4][4] = "Gibts doch garnicht"
       
     aufgaben[5][0] = "6.Frage"; aufgaben[5][1] = "Wie groß ist ein Int32 Datentyp in C#?";
     aufgaben[5][2] = "4 Byte"; aufgaben[5][3] = "8 Byte"; aufgaben[5][4] = "2 Byte";

     aufgaben[6][0] = "7.Frage"; aufgaben[6][1] = "Was ist C#?";
     aufgaben[6][2] = "Ein Malprogramm"; aufgaben[6][3] = "Ein Spiel"; aufgaben[6][4] = "Eine Programmiersprache";

     aufgaben[7][0] = "8.Frage"; aufgaben[7][1] = "Ist HTML eine Auszeichungssprache?";
     aufgaben[7][2] = "Ja"; aufgaben[7][3] = "Nein"; aufgaben[7][4] = "Weiß ich nicht";

     aufgaben[8][0] = "9.Frage"; aufgaben[8][1] = "Welches BOM ist in HTML-Dateien erlaubt?";
     aufgaben[8][2] = "Big-Endian";  aufgaben[8][3] = "Little-Endian"; aufgaben[8][4] = "Keines";

     aufgaben[9][0] = "10.Frage"; aufgaben[9][1] = "1 zoll/inch = ";
     aufgaben[9][2] = "1,30 cm"; aufgaben[9][3] = "5,56 cm"; aufgaben[9][4] = "2,54 cm";

     aufgaben[10][0] = "11.Frage"; aufgaben[10][1] = "Was ist eine Schnittstelle?";
     aufgaben[10][2] = "Eine Verletzung"; aufgaben[10][3] = "Ein Port"; aufgaben[10][4] = "Ein kurzer Bart";

     aufgaben[11][0] = "12.Frage"; aufgaben[11][1] = "Was bedeutet die Abkürzung 'CC'?";
     aufgaben[11][2] = "Cirkus Clowns";  aufgaben[11][3] = "Creative Commons"; aufgaben[11][4] = "Computer Cluster";

     aufgaben[12][0] = "13.Frage"; aufgaben[12][1] = "Was bedeutet CLI?";
     aufgaben[12][2] = "Computer-Link-Interface"; aufgaben[12][3] = "Hä?"; aufgaben[12][4] = "Command-Line-Interface";

     aufgaben[13][0] = "14.Frage"; aufgaben[13][1] = "Was heißt HTML?";
     aufgaben[13][2] = "Hyper Text Markup Language"; aufgaben[13][3] = "Hyper Text Make-up Language"; aufgaben[13][4] = "HaTeM-Line";

     aufgaben[14][0] = "15.Frage"; aufgaben[14][1] = "und CSS?";
     aufgaben[14][2] = "Cascading Style Sheet"; aufgaben[14][3] = "Computer System Service"; aufgaben[14][4] = "Compiler Sequence Styler";

     aufgaben[15][0] = "16.Frage"; aufgaben[15][1] = "Mit welchen Zahlen arbeitet ein Computer?";
     aufgaben[15][2] = "Hexadezimal";  aufgaben[15][3] = "Binär"; aufgaben[15][4] = "Oktal";

     aufgaben[16][0] = "17.Frage"; aufgaben[16][1] = "Was ist eine App?";
     aufgaben[16][2] = "Eine Applikation"; aufgaben[16][3] = "Ein Apfel"; aufgaben[16][4] = "Ein Apple-Programm";

     aufgaben[17][0] = "18.Frage"; aufgaben[17][1] = "Für was steht .exe?";
     aufgaben[17][2] = "Executable"; aufgaben[17][3] = "Exekutieren"; aufgaben[17][4] = "Exekutive";

     aufgaben[18][0] = "19.Frage"; aufgaben[18][1] = "und...RGB?";
     aufgaben[18][2] = "Red-Green-Blue";  aufgaben[18][3] = "Residence Gigabit"; aufgaben[18][4] = "Royal Green Barets";

     aufgaben[19][0] = "20.Frage"; aufgaben[19][1] = "Ist KGB eine Farbpalette?";
     aufgaben[19][2] = "Ja"; aufgaben[19][3] = "Nein"; aufgaben[19][4] = "Weiß nicht";

     aufgaben[20][0] = "21.Frage"; aufgaben[20][1] = "255 in Hexadezimal";
     aufgaben[20][2] = "ff"; aufgaben[20][3] = "ee"; aufgaben[20][4] = "cf";

     aufgaben[21][0] = "22.Frage"; aufgaben[21][1] = "Weiß in Hexadezimal";
     aufgaben[21][2] = "ffffff"; aufgaben[21][3] = "eeeeee"; aufgaben[22][4] = "cccccc";

     function Start()
     {
          pfg(0);
          return;
     }

     function pfg(k)
     {
          klick = parseInt(k);
          if (aus > 0) {return;}                                            // Keine Eingabemöglichkeiten wenn Spiel aus
          if (ende > 0){endsequenz();}                                      // Wenn letzte Frage beantwortet - nur mehr Ergebnis anzeigen

          document.getElementById("fnum").innerHTML = aufgaben[nummer][0];         // Nummer der Frage (1.Frage, 2.Frage, ...)
          document.getElementById("frage").innerHTML = aufgaben[nummer][1];        // Die Frage
          document.getElementById("a1").innerHTML = aufgaben[nummer][2];           // Mögliche Antwort 1
          document.getElementById("a2").innerHTML = aufgaben[nummer][3];           // Mögliche Antwort 2
          document.getElementById("a3").innerHTML = aufgaben[nummer][4];           // Mögliche Antwort 3
     
          if (nummer > 0) {                                                 // Erst wenn die erste Frage beatwortet wurde
               xpunkte();}                            
          nummer += 1;                                                      // Nummer der nächsten Frage die kommt
          StartA = performance.now();                                       // Festellung Startzeit
          if (nummer > fragen - 1) {ende = 1;}                              // Nummer darf nicht die Anzahl der Fragen übersteigen
     }

     function endsequenz()
     {                
          Endzeit = performance.now();                                      // Festellung Endzeit                      
          xpunkte();                                                        // Spiel ist Aus, es wird nur das Ergebnis angezeigt

          document.getElementById("fnum").innerHTML = "ABGESCHLOSSEN";
          document.getElementById("frage").innerHTML = "Hoffentlich waren die Fragen nicht zu Schwer.";
          document.getElementById("a1").innerHTML = "Ihre Punkte: " + punkte;
          document.getElementById("a2").innerHTML = "Richtige Antworten: " + richtigeAntwort;
		  document.getElementById("a3").innerHTML = "Falsche Antworten: " + falscheAnwtort;
          document.getElementById("zeit").innerHTML = "Ihre Zeit: " + ((Endzeit - Startzeit) / 1000).toFixed(2) + " sek";
          
          ButtonEx();                                                       // Die Funktion zum Buttons entfernen wird aufgerufen
          aus = 1;                                                          // aus = 1, keine Reaktionen bei User-Eingaben
     }

     function xpunkte()
     {
          let status = "Falsch";
          if (klick == antwort[nummer - 1])
          {
               status = "Richtig";
               richtigeAntwort += 1;
               punkte += 20;
          }
          else
          {
			   falscheAnwtort += 1;
               if (punkte == 0)
               {
                    punkte = 0;
               }
               else if (punkte >= 10)
               {
                    punkte -= 10;
               }
          }
          
          document.getElementById("pnkt").innerHTML = "Punkte: " + punkte;  // Gibt aktuelle Punkte aus
          return;
     }
     function ButtonEx()
	 // Entfernt alle Buttons am Ende des Spiels
     {
          do                                                                //Solange es Button's gibt...
          {
               var button = document.querySelector("input[type = 'button']");
               button.parentNode.removeChild(button);
          }while(button);                                                   //...werden alle nacheinander entfernt
          return;
     }