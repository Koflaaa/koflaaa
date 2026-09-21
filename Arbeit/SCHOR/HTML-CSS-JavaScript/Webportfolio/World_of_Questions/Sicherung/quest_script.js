
   var nummer = 0;                 // Die aktuelle Nummer der Frage
   var fragen = 21;                // Anzahl aller Fragen
   var satz = 5;                   // Inhalte der Fragen
   var punkte = 0;                 // Anzah der ereichten Punkte
   var ende = 0;                   // Wenn alle Fragen durch, ende = 1
   var aus = 0;                    // Für Endsequenz
   var richtig = 0;                // Anzahl richtiger Antworten
   var klick = 0;                  // Feststellung was an geklickt wurde
   var Brot = 0;                   // Anazhl richtiger Antworten
   var Semmel = " ";               //Bewertung  
   var quest = new Array();        // Array für die Fragestellungen
   var antwort = new Array();      // Array für die Antworten

   antwort = [1,1,3,1,1,1,3,1,2,3,2,2,3,1,1,2,1,1,1,2,1,1]; 
       
       for (let i = 0; i < fragen; i++) 
       {           // Zuerst alle Arrayinhalte auf 0
          quest.push(new Array(satz).fill(0));      // Initialisiert das Array und setzt den ganzen Inhalt auf Null
       }

       quest[0][0] = "1.Frage"; quest[0][1] = "Ist C# Objekt orientiert?";
       quest[0][2] = "Ja"; quest[0][3] = "Nein"; quest[0][4] = "Weiß nicht";

       quest[1][0] = "2.Frage"; quest[1][1] = "Ok, wie erstellt man eine Ganzzahl in C#?";
       quest[1][2] = "mit int";  quest[1][3] = "mit double"; quest[1][4] = "mit string";

       quest[2][0] = "3.Frage"; quest[2][1] = "Welches Betriebssystem gibt es nicht?";
       quest[2][2] = "Windows"; quest[2][3] = "Cray"; quest[2][4] = "Manix";

       quest[3][0] = "4.Frage"; quest[3][1] = "Cray ist ein Betriebssystem für?";
       quest[3][2] = "Supercomputer"; quest[3][3] = "AI-Systeme"; quest[3][4] = "Navigation";

       quest[4][0] = "5.Frage"; quest[4][1] = "Wie groß kann eine 'bigInt' in JavaScript sein?";
       quest[4][2] = "Bis zu Arbeitsspeichergröße";  quest[4][3] = "Ca. 100 mal so groß wie double in C#"; quest[4][4] = "Gibts doch garnicht";

       quest[5][0] = "6.Frage"; quest[5][1] = "Wie groß ist ein Int32 Datentyp in C#?";
       quest[5][2] = "4 Byte"; quest[5][3] = "8 Byte"; quest[5][4] = "2 Byte";

       quest[6][0] = "7.Frage"; quest[6][1] = "Was ist C#?";
       quest[6][2] = "Ein Malprogramm"; quest[6][3] = "Ein Spiel"; quest[6][4] = "Eine Programmiersprache";

       quest[7][0] = "8.Frage"; quest[7][1] = "Ist HTML eine Auszeichungssprache?";
       quest[7][2] = "Ja"; quest[7][3] = "Weiß ich nicht"; quest[7][4] = "Nein";

       quest[8][0] = "9.Frage"; quest[8][1] = "Welches BOM ist in HTML-Dateien erlaubt?";
       quest[8][2] = "Big-Endian";  quest[8][3] = "Keines"; quest[8][4] = "Little-Endian";

       quest[9][0] = "10.Frage"; quest[9][1] = "1 Zoll = ";
       quest[9][2] = "1,30 cm"; quest[9][3] = "5,56 cm"; quest[9][4] = "2,54 cm";

       quest[10][0] = "11.Frage"; quest[10][1] = "Was ist eine Schnittstelle?";
       quest[10][2] = "Eine Verletzung"; quest[10][3] = "Ein Port"; quest[10][4] = "Ein kurzer Bart";

       quest[11][0] = "12.Frage"; quest[11][1] = "Was bedeutet die Abkürzung 'CC'?";
       quest[11][2] = "Cirkus Clowns";  quest[11][3] = "Creative Commons"; quest[11][4] = "Computer Cluster";

       quest[12][0] = "13.Frage"; quest[12][1] = "Was bedeutet CLI?";
       quest[12][2] = "Computer-Link-Interface"; quest[12][3] = "Hä?"; quest[12][4] = "Command-Line-Interface";

       quest[13][0] = "14.Frage"; quest[13][1] = "Was heißt HTML?";
       quest[13][2] = "Hyper Text Markup Language"; quest[13][3] = "Hyper Text Make-up Language"; quest[13][4] = "HaTeM-Line";

       quest[14][0] = "15.Frage"; quest[14][1] = "und CSS?";
       quest[14][2] = "Cascade Style Sheet"; quest[14][3] = "Computer System Service"; quest[14][4] = "Compiler Sequence Styler";

       quest[15][0] = "16.Frage"; quest[15][1] = "Mit welchen Zahlen rechnet ein Computer?";
       quest[15][2] = "Hexadezimal";  quest[15][3] = "Binär"; quest[15][4] = "Oktal";

       quest[16][0] = "17.Frage"; quest[16][1] = "Was ist eine App?";
       quest[16][2] = "Eine Applikation"; quest[16][3] = "Ein Apfel"; quest[16][4] = "Ein Apple-Programm";

       quest[17][0] = "18.Frage"; quest[17][1] = "Für was steht .exe?";
       quest[17][2] = "Executable"; quest[17][3] = "Exekutieren"; quest[17][4] = "Exekutive";

       quest[18][0] = "19.Frage"; quest[18][1] = "RGB steht für....?";
       quest[18][2] = "Red-Blue-Green";  quest[18][3] = "Residence Gigabit"; quest[18][4] = "Royal Green Barets";

       quest[19][0] = "20.Frage"; quest[19][1] = "Ist sKGB eine Farbpalette?";
       quest[19][2] = "Ja"; quest[19][3] = "Nein"; quest[19][4] = "Weiß nicht";

       quest[20][0] = "21.Frage"; quest[20][1] = "255 in Hexadezimal";
       quest[20][2] = "ff"; quest[20][3] = "ee"; quest[20][4] = "cf";
       
     function Start()
     {
          pfg(0);
          return;
     }

function pfg(k)
{
     klick = parseInt(k);
     if (aus > 0) {return;}                         // Keine Eingabemöglichkeiten wenn Spiel aus
     if (ende > 0){endsequenz();}                   // Wenn letzte Frage beantwortet - nur mehr Ergebnis anzeigen

     document.getElementById("fnum").innerHTML = quest[nummer][0];         // Nummer der Frage (1.Frage, 2.Frage, ...)
     document.getElementById("frage").innerHTML = quest[nummer][1];        // Die Frage
     document.getElementById("a1").innerHTML = quest[nummer][2];           // Mögliche Antwort 1
     document.getElementById("a2").innerHTML = quest[nummer][3];           // Mögliche Antwort 2
     document.getElementById("a3").innerHTML = quest[nummer][4];           // Mögliche Antwort 3
 
     if (nummer > 0) {                                       // Erst wenn die erste Frage beatwortet wurde
          xpunkte();}                            
     nummer += 1;                                            // Nummer der nächsten Frage die kommt
     if (nummer > fragen - 1) {ende = 1;}                    // Nummer darf nicht die Anzahl der Fragen übersteigen
}

function endsequenz()
{                                      
     xpunkte();                                              // Spiel ist Aus, es wird nur das Ergebnis angezeigt
     if(punkte < 300) {Semmel = "Gut";}
     else if (punkte > 299 && punkte < 500) {Semmel = "Sehr Gut";}
     else if (punkte > 499) {Semmel = "Ausgezeichnet";}
     //alert("SIE HABEN " + punkte + " PUNKTE EREICHT");
     document.getElementById("fnum").innerHTML = "ABGESCHLOSSEN";
     document.getElementById("frage").innerHTML = "Hoffentlich waren die Fragen nicht Schwer.";   // Zeit?, nö
     document.getElementById("a1").innerHTML = "Ihre Punkte: " + punkte;    
     document.getElementById("a2").innerHTML = "Die Antworten wahren " + Semmel;
     document.getElementById("a3").innerHTML = "Richtige Antworten: " + Brot;
     
     aus = 1;                                                // aus = 1, keine Reaktionen bei User-Eingaben
}

function xpunkte()
{
     let mr = "Falsch";                       
     if (klick == antwort[nummer - 1])
     {
          mr = "Richtig";
          punkte += 30;
          Brot += 1;
     }
     
     document.getElementById("pnkt").innerHTML = "Punkte: " + punkte;  // Schreibt Punkte 
     return;
}