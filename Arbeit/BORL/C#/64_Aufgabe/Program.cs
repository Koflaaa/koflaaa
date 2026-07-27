using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        static void Main()
        {
            //Aufgabe1();
            //Aufgabe2();
            //Aufgabe3();
            //Aufgabe4();
            //Aufgabe5();
            //Aufgabe6();
            //Aufgabe7();
            //Aufgabe8();
            //Aufgabe9();
            //Aufgabe10();
            //Aufgabe11();
            //Aufgabe12();
            //Aufgabe13();
            //Aufgabe14();
            //Aufgabe15();
            //Aufgabe16();
            //Aufgabe17();
            //Aufgabe18();
            //Aufgabe19();
            //Aufgabe20();
            //Aufgabe21();
            //Aufgabe22();
            //Aufgabe23();
            //Aufgabe24();
            //Aufgabe25();
            //Aufgabe26();
            //Aufgabe27();
            //Aufgabe28();
            //Aufgabe29();
            //Aufgabe30();
            //Aufgabe31();
            //Aufgabe32();
            //Aufgabe33();
            //Aufgabe34();
            //Aufgabe35();
            //Aufgabe36();
            //Aufgabe37();
            Aufgabe38();
            //Aufgabe39();
            //Aufgabe40();
            //Aufgabe41();
            //Aufgabe42();
            //Aufgabe43();
            //Aufgabe44();
            //Aufgabe45();
            //Aufgabe46();
            //Aufgabe47();
            //Aufgabe48();
            //Aufgabe49();
            //Aufgabe50();
            //Aufgabe51();
            //Aufgabe52();
            //Aufgabe53();
            //Aufgabe54();
            //Aufgabe55();
            //Aufgabe56();
            //Aufgabe57();
            //Aufgabe58();
            //Aufgabe59();
            //Aufgabe60();
            //Aufgabe61();
            //Aufgabe62();
            //Aufgabe63();
            //Aufgabe64();
        }
        public static void Aufgabe1()
        {//Erstellt ein F in hashtags
            Console.WriteLine(" ######");
            Console.WriteLine(" #");
            Console.WriteLine(" #");
            Console.WriteLine(" #####");
            Console.WriteLine(" #");
            Console.WriteLine(" #");
            Console.WriteLine(" #");

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe2()
        {//Erstellt ein C in hashtags
            Console.WriteLine("    ######");
            Console.WriteLine("  ##      ##");
            Console.WriteLine(" #");
            Console.WriteLine(" #");
            Console.WriteLine(" #");
            Console.WriteLine(" #");
            Console.WriteLine(" #");
            Console.WriteLine("  ##      ##");
            Console.WriteLine("    ######");

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe3()
        {// Gibt den umgekehrten Text aus
            Console.WriteLine(" XML");
            Console.WriteLine(" The reverse of XML us LMX");

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe4()
        {   //Berechnet eine Fläche eines Rechtecks
            //Höhe und Fläche wird in den jeweiligen Rechnungen in inch/zoll umgewandelt
            float inch1 = (float)12.70 / (float)2.54;                                          //Der Wert von float inch1 setzt sich aus der angegebenen Rechnung zusammen. Die Rechnung ist in zoll umgewandelt
            float inch2 = (float)17.78 / (float)2.54;                                          //Der Wert von float inch2 setzt sich aus der angegebenen Rechnung zusammen. Die Rechnung ist in zoll umgewandelt
            float flaeche = inch1 * inch2;
            float umfang = 2 * (inch1 + inch2);

            Console.WriteLine("Seite a = {0}", inch1);                                          //Die Ausgabe gibt a mit dem Werten von inch1 aus und
            Console.WriteLine("Höhe = {0}\n", inch2);                                           //Höhe mit den Werten von inch2.

            //Fläche des Rechtecks ist (in zoll/inch):
            Console.WriteLine("Die Fläche des Rechtecks ist {0} inch", flaeche);                //Gibt die Fläche des Rechtecks aus
            //Der Umfang des Rechtecks ist (in zoll/inch):
            Console.WriteLine("Der Umfang des Rechtecks ist {0} inch", umfang);                //Gibt den Umfang des Rechtecks aus

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");
            Console.ReadKey();
        }
        public static void Aufgabe5()
        {   //Berechnet den Umfang eines Kreises

            double radius = 15.24 / 2.54;                                                       //in inch umgewandelt
            double pi = Math.Acos(0) * 2;                                                       //gibt Pi wieder
            double fläche;                                                                      //erstellt eine Variable mit Nuller Wert
            double umfang;                                                                      //erstellt eine Variable mit Nuller Wert

            umfang = 2 * pi * radius;                                                           //Umfang wird aus 2* pi * radius berechnet
            Console.WriteLine("Umfang ist " + umfang);                                          //Gibt den Umfang aus
                fläche = pi * Math.Pow(radius, 2);                                              //Fläche setzt sich aus pi mal radius^2
            Console.WriteLine("Fläche ist " + fläche);                                          //Gibt die Fläche aus

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe6()
        {   //Addiert Variablen zusammen

            int a = 125;
            int b = 12345;
            long ax = 1234567890;
            short s = 4043;
            float x = 2.13459F;
            double dx = 1.1415927;
            char c = 'W';
            ulong ux = 2541567890;

            Console.WriteLine("Variable 1 ist " + (a + c));
            Console.WriteLine("Variable 2 ist " + (x + c));
            Console.WriteLine("Variable 2 ist " + (x + dx));
            Console.WriteLine("Variable 4 ist " + (((int)dx) + ax));
            Console.WriteLine("Variable 5 ist " + (a + x));
            Console.WriteLine("Variable 6 ist " + (s + b));
            Console.WriteLine("Variable 7 ist " + (ax + b));
            Console.WriteLine("Variable 8 ist " + (s + c));
            Console.WriteLine("Variable 9 ist " + (ax + c));
            Console.WriteLine("Variable 10 ist " + ((ulong)ax + ux));

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe7()                                                               //Gibt Tage als Jahre, Wochen und Tage an
        {
            int d = 1329;                                                                           //Veränderbar, rechnet immer auf jahre, wochen und tage
            int jahre = d / 365;                                                                    // jahre = d /365
            int woche = (d - (jahre * 365)) / 7;                                                    //woche setzt sich aus der Rechnung (d - (jahre * 365)) /7 zusammen
            int tage = (d - (woche * 7) - (jahre * 365));                                           //tage setzt sich aus der Rechnung (d - (woche * 7) - (jahre * 365)) / 7 zusammen

            Console.WriteLine(jahre);                                                               //}
            Console.WriteLine(woche);                                                               //} --> Gibt den jeweiligen Wert aus
            Console.WriteLine(tage);                                                                //}

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");
            Console.ReadLine();
        }
        public static void Aufgabe8()
        {   //Addiert 2 Zahlen zusammen
          double[] zahlen = new double[2];                                                          //Erstellt eine double Array mit 2 Indexplätzen

            for (int i = 0; i < 2; i++)                                                             //Führt die for-Schleife solange aus, solange i kleiner als 2 ist
            {
              Console.WriteLine("Bitte geben Sie {0}. Zahl ein.", i+1);                             //Forder den Nutzer auf eine Zahl einzugeben
              if (double.TryParse(Console.ReadLine(), out double x)==true)                          //sollte die angegebeBedingung zutreffen wird der Rest der Abfrage ausgeführt
              {
                Console.WriteLine("Die {0}.Zahl ist: {1}", i+1, x);                                 //Gibt die eingegebenen Werte nochmals aus
                    zahlen[i] = x;
                }
              else
              {
                    Console.WriteLine("Keine gültige Eingabe");                                     //Sollte die oben genannteBedingung nicht zutreffen wird eine "Error"-Nachricht ausgegeben
              }
            }
            Console.WriteLine("Das Ergebnis der Addition ist: {0}", zahlen[0] + zahlen[1] );        //Gibt das Ergebnis der Addition aus

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                //Kennzeichnet das Ende des Programms und fordert den User auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe9()
        {   //Multipliziert 2 Zahlen miteinnander
            double zahl1;                                                                           //erstellt eine Variable mit Nullerwert
            double zahl2;                                                                           //erstellt eine Variable mit Nullerwert

            Console.WriteLine("Bitte geben Sie erste Zahl ein.");                                   //Fordert den User auf eine Zahl einzugeben
            zahl1 = Convert.ToDouble(Console.ReadLine());                                           //Konvertiert die User-Eingabe in double und weißt sie anschließend zahl1 zu
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein.");                              //Fordert den User auf eine Zahl einzugeben
            zahl2 = Convert.ToDouble(Console.ReadLine());                                           //Konvertiert die User-Eingabe in double und weißt sie anschließend zahl1 zu

            Console.WriteLine("Ergebnis ist " + (zahl1 * zahl2));                                   //Gibt das Ergebnis der Multiplikation von zahl1 mal zahl2 aus

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe10()
        {   //Berechnet den Durchschnitt zweier Objekte
            double Gewicht1;                                                                        //}
            double Anzahl1;                                                                         //}
            double Gewicht2;                                                                        //} --> erstellt vier double Variablen mit Nullerwerten
            double Anzahl2;                                                                         //}

            Console.WriteLine("Geben Sie Gewicht1 ein");                                            //Forder den User auf Gewicht1 einzugeben
            Gewicht1 = Convert.ToDouble(Console.ReadLine());                                        //Konvertiert die User-Eingabe in double und weißt sie anschließend Gewicht1 zu
            Console.WriteLine("Geben Sie Anzahl1 ein");                                             //Forder den User auf Anzahl1 einzugeben
            Anzahl1 = Convert.ToDouble(Console.ReadLine());                                         //Konvertiert die User-Eingabe in double und weißt sie anschließend Anzahl1 zu
            Console.WriteLine("Geben Sie Gewicht2 ein");                                            //Forder den User auf Gewicht2 einzugeben
            Gewicht2 = Convert.ToDouble(Console.ReadLine());                                        //Konvertiert die User-Eingabe in double und weißt sie anschließend Gewicht2 zu
            Console.WriteLine("Geben Sie Anzahl2 ein");                                             //Forder den User auf Anzahl2 einzugeben
            Anzahl2 = Convert.ToDouble(Console.ReadLine());                                         //Konvertiert die User-Eingabe in double und weißt sie anschließend Anzahl2 zu

            Console.WriteLine("Ergebnis ist " + (((Anzahl1 * Gewicht1) + (Anzahl2 * Gewicht2)) / (Anzahl1 + Anzahl2)));       //Gibt den Durchschnitt der eingegebenen Werte aus

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe11()
        {// Berechnet den Gehalt mit den angegebenen Stundenlohn und Arbeitsstunden. Anschließend werden sie multiploziert und in USD ausgegeben.
            double id;
            double hours;
            double salary_per_hour;

            Console.WriteLine("Geben Sie ihre ID ein");                                             //Fordert den User auf eine ID einzugeben.
            id = Convert.ToDouble(Console.ReadLine());                                              // Konvertiert den eingegebenen Wert in double
            Console.WriteLine("Geben Sie ihre Stunden ein");                                        //Fordert den User auf seine Arbeitsstunden einzugeben
            hours = Convert.ToDouble(Console.ReadLine());                                           // Konvertiert den eingegebenen Wert in double
            Console.WriteLine("Geben Sie Ihren Stundenlohn an");
            salary_per_hour = Convert.ToDouble(Console.ReadLine());                                 // Konvertiert den eingegebenen Wert in double

            Console.WriteLine("Employee's ID = " + id);                                             //Gibt die vorhin eingegebene Employee ID aus
            Console.WriteLine("Salary = U$" + hours * salary_per_hour);                              //Gibt den vorhin eingegebenen Stunden- und Arbeitslohn multipliziert als Lohn wieder aus

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe12()                                                              //Rechnet mit einer For schleife den Maximalen Wert 4er Zahlen aus
        {
            int eingabe;
            int max = 0;

            Console.WriteLine("Geben Sie drei Zahlen ein");
            for (int x = 0; x < 3; x++)                                                             //int = x erstellt eine iteger variable x, anschließend wird abgefragt ob x kleiner als 4 ist, und das bei jeden durchlauf +1 zu x dazu gezählt werden soll
            {
                //Wandelt die angegebene Zahl in eine String variable um.
                eingabe = Convert.ToInt32(Console.ReadLine());                                      //Integer variable Eingabe wird in eine Int32 Variable konvertiert und ein Input erstellt

                if (eingabe > max)                                                                  //Sollte EIngabe GRÖSSER sein als max wird eingabe zu max
                {
                    max = eingabe;
                }
            }
            Console.WriteLine("Die größte Zahl ist " + max);                                        //Output + max

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();

        }
        public static void Aufgabe13()                                                              //Berechnet den Durchschnitt von Benzinverbrauch
        {
            int TotalDistance;
            double spentFuel;
            double durch;


            Console.WriteLine("Geben Sie die Distanz ein");                                        //Fordert den User auf eine Distanz einzugeben
            TotalDistance = Convert.ToInt32(Console.ReadLine());                                   //Konvertiert den eingegebenen
            Console.WriteLine("Geben Sie den Benzinverbrauch an");
            spentFuel = Convert.ToDouble(Console.ReadLine());
            durch = (double)TotalDistance / spentFuel;                                             //Konvertiert die Eingabe von TotalDistance(int) in eine double Eingabe die anschließend durch spentFuel (double) dividiert wird

            Console.WriteLine(" Durchschnit ist {0:N3}", durch);                                   //Berechnet den Durchschnitt Benzin gehalt

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe14()                                                              //Berechnet die Distanz zwischen zweier Koordinatenpunkte
        {
            double x1, x2, y1, y2;

            Console.WriteLine("Geben Sie die Koordinaten des erstens Punktes ein");
            Console.WriteLine("x1:");
            x1 = Convert.ToDouble(Console.ReadLine());                                              //Die Eingabe(Console.ReadLine()) von x1 wird in eine double konvertiert (Convert.Toxy)
            Console.WriteLine("y1:");
            y1 = Convert.ToDouble(Console.ReadLine());                                              //Die Eingabe(Console.ReadLine()) von y1 wird in eine double konvertiert (Convert.Toxy)

            Console.WriteLine("\nGeben Sie die Koordinaten des zweiten Punktes ein");
            Console.WriteLine("x1:");
            x2 = Convert.ToDouble(Console.ReadLine());                                              //Die Eingabe(Console.ReadLine()) von x2 wird in eine double konvertiert (Conver.Toxy)
            Console.WriteLine("y2:");
            y2 = Convert.ToDouble(Console.ReadLine());                                              //Die Eingabe(Console.ReadLine()) von y2 wird in eine double konvertiert (Conver.Toxy)

            double distanz = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);                         //Berechnet den Abstand der Koordinatenpunkte mit Hilfe der vorhin eingegebenen Werte
            if (distanz > 0)
            {
                distanz = Math.Sqrt(distanz);                                                       //Math.Sqrt() wird verwendet um die Wurzel einer Zahl zu ziehn
            }
            else
            {
                distanz = 0;
            }

            // Gibt die oben eingegebenen Werte mit der ausgerechneten Distanz aus:
            Console.WriteLine("Die Distanz zwischen den Punkten ({0}, {1}) und ({2}, {3}) beträgt {4:F2}", x1, y1, x2, y2, distanz);

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe15()
        {//Wandelt einen gegebenen Wert in Banknoten um
            int Fünfhunderter = 0;                                                                 //}
            int Hunderter = 0;                                                                     //}
            int Fünfziger = 0;                                                                     //}
            int Zwanziger = 0;                                                                     //} Erstellt jeweils ein Variable mit dem jeweils gebrauchten Datentypen
            int Zehner = 0;                                                                        //}
            int Fünfer = 0;                                                                        //}
            int zweier = 0;                                                                        //}
            int einser = 0;                                                                        //}

            Console.Write("Geben Sie einen Betrag ein: ");
            int VerbleibenderWert = Convert.ToInt32(Console.ReadLine());                            //Konventiert den Eingegebenen Wert in einen Integer Wert

            if (VerbleibenderWert >= 500)                                                           //Überprüft ob der eingebene Wert größer als 500 ist
            {
                Fünfhunderter = VerbleibenderWert / 500;                                            //Dividiert den Eingebenen Wert druch 500 und ordnet ihn der Integer Variable Fünfhundert zu
                VerbleibenderWert -= (Fünfhunderter * 500);
            }
            if (VerbleibenderWert >= 100)                                                           //Überprüft ob der VerbleibendeWert größer als 100 ist
            {
                Hunderter = VerbleibenderWert / 100;                                                //Falls der VW über oder gleich 100 ist dividiert er ihn durch 100 und orned ihn wieder zu Hunderter Variable hinzu
                VerbleibenderWert -= (Hunderter * 100);
            }
            if (VerbleibenderWert >= 50)                                                            //Überprüft ob der neue Wert wieder über oder gleich 50 ist sollte das der Fall sein
            {
                Fünfziger = VerbleibenderWert / 50;                                                 //wird er durch 50 dividiert und
                VerbleibenderWert -= (Fünfziger * 50);                                              //der Rest zu der Variable hinzugefügt
            }
            if (VerbleibenderWert >= 20)                                                            //Überprüft ob der verbleibende Wert größer oder gleich 20 ist
            {
                Zwanziger = VerbleibenderWert / 20;                                                 //divisdiert den Wert durch 20 und der Rest wird der Integer Variable Zwanzig hinzugefügt
                VerbleibenderWert -= (Zwanziger * 20);
            }
            if (VerbleibenderWert >= 10)                                                            //Überprüft ob der Wert größer oder gleich 10 ist sollte das der Fall sein
            {
                Zehner = VerbleibenderWert / 10;                                                    //wird der Wert druch 10 Dividiert und der Integer Variable Zehner zu geordnet
                VerbleibenderWert -= (Zehner * 10);
            }
            if (VerbleibenderWert >= 5)                                                             //Überprüft ob der Wert einen größeren oder gleichen Wert wie 5 hat
            {
                Fünfer = VerbleibenderWert / 5;                                                     //Dividiert den Wert durch 5 und ordnet den Rest der Integer Variable Fünfer zu
                VerbleibenderWert -= (Fünfer * 5);
            }
            if (VerbleibenderWert >= 2)                                                             //Überprüft ob der Wert einen größeren oder gleichen Wert wie 2 hat
            {
                zweier = VerbleibenderWert / 2;                                                     //Dividiert den Wert durch 2 und ordnet den Rest der Integer Variable Zweier zu
                VerbleibenderWert -= (zweier * 2);
            }
            if (VerbleibenderWert >= 1)                                                             //Überprüft ob der Wert einen größeren oder gleichen Wert wie 1 hat
            {
                einser = VerbleibenderWert / 1;                                                     //Dividiert den Wert durch 1 und ordnet den Rest der Integer Variable Einser zu
            }

            Console.WriteLine("500-Euro-Schein(e)" + Fünfhunderter);                                //}
            Console.WriteLine("100-Euro-Schein(e): " + Hunderter);                                  //}
            Console.WriteLine("50-Euro-Schein(e): " + Fünfziger);                                   //}
            Console.WriteLine("20-Euro-Schein(e): " + Zwanziger);                                   //}  -->        Gibt den jeweiligen Wert aus
            Console.WriteLine("10-Euro-Schein(e): " + Zehner);                                      //}
            Console.WriteLine("5-Euro-Schein(e): " + Fünfer);                                       //}
            Console.WriteLine("2-Euro-Münze(n): " + zweier);                                        //}
            Console.WriteLine("1-Euro-Münze(n)" + einser);                                          //}

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe16()                                                                  //Wandelt einen Wert in Sekunden, Minutenm Stunden um
        {
            Console.Write("Geben Sie die Sekunden ein: ");
            int totaleSekunden = int.Parse(Console.ReadLine());                                         //Parse wird verwendet um eine Zahlenfolge in einen numerischen Typ wie int, double, float usw. zu umwandeln
            int stunden = totaleSekunden / 3600;
            int minuten = totaleSekunden % 3600 / 60;
            int sekunden = totaleSekunden % 60;                                                         //% wird verwendet um den Rest einer Division anzugeben

            Console.WriteLine("{0} Stunden, {1} Minuten, {2} Sekunden", stunden, minuten, sekunden);
            Console.ReadLine();
        }
        public static void Aufgabe17()                                                              //Wandelt Sekunden in Stunden, Minuten und Sekunden um
        {
            int insgesamteTage, jahre, monate, wochen, verbleibendeTage;
            Console.Write("Geben Sie die Tage ein: ");
            insgesamteTage = Convert.ToInt32(Console.ReadLine());
            jahre = insgesamteTage / 365;                                                           //jahre wird durch das Dividieren von den Insesamten Tagen durch 365 gerechnet
            insgesamteTage -= (jahre * 365);
            monate = insgesamteTage / 30;                                                           //monate wird durch das berechnen von tage - (jahre * 365) und anschließend  tage / 30 ergeben
            insgesamteTage -= (monate * 30);
            wochen = insgesamteTage / 7;                                                            //wochen wird druch das berechnen von tage - (monate * 30), anschließend tage / 7
            insgesamteTage -= (wochen * 7);
            verbleibendeTage = insgesamteTage;                                                      // und die verbleibenen Tage werden durch den Rest ergeben

            Console.WriteLine(jahre + " Jahr(e), " + monate + " Monat(e), " + wochen + " Woche(n), und " + verbleibendeTage + " Tag(e)");

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();                                                                     //Console.ReadKey liest einen Key ein
        }
        public static void Aufgabe18()                                                              //Berechnet Werte und gibt anschließend ist True oder is False aus
        {
            int p, q, r, s;

            Console.Write("Enter p: ");
            p = int.Parse(Console.ReadLine());                                                      //Versucht p in einen neuen Wert zu ändern

            Console.Write("Enter q: ");
            q = int.Parse(Console.ReadLine());                                                      //Versucht q in einen neuen Wert zu ändern

            Console.Write("Enter r: ");
            r = int.Parse(Console.ReadLine());                                                      //Versucht r in einen neuen Wert zu ändern

            Console.Write("Enter s: ");
            s = int.Parse(Console.ReadLine());                                                      //Versucht s in einen neuen Wert zu ändern

            if (r > 0 && s > 0 && p % 2 == 0 && q > r && s > p && r + s > p + q)
            {
                Console.WriteLine("Correct Value");                                                 //Gibt aus ob die if(Bedingung) Richtig ist oder
            }
            else
            {
                Console.WriteLine("Wrong Value");                                                   //ob die if(Bedingung) Falsch ist
            }
            Console.ReadKey();
        }
        public static void Aufgabe19()
        {// Berechnet den möglichen ursprung der Rechnungswerte
            Console.WriteLine("Enter three floating-point numbers:");                               //User wird aufgefordert drei Nummern einzugeben
            Console.Write("a: ");                                                                   //User wird aufgefordert 1. Zahl (a) einzugeben
            double a = Convert.ToDouble(Console.ReadLine());                                        //Die erste Eingabe (a) wird mit Hilfe des Convert.ToDouble Commands in einen double Datentypen gespeichert
            Console.Write("b: ");                                                                   //User wird aufgeforder 2. Zahl (b) einzugeben
            double b = Convert.ToDouble(Console.ReadLine());                                        //Die zweite Eingabe (b) wird mit Hilfe des Convert.ToDouble Commands in einen double Datentypen gespeichert
            double bn = b / -1;                                                                     //bn wird durch b / -1, also die Eingabe von b durch -1 in einen negativen Wert umberechnet
            Console.Write("c: ");                                                                   //User wird aufgeforder 3. Zahl (c) einzugeben
            double c = Convert.ToDouble(Console.ReadLine());                                        //Die dritte Eingabe (c) wird mit Hilfe des Convert.ToDouble Commands in einen double Datentypen gespeichert
            double wurzel1 = Math.Pow(b, 2) + (4 * (a * c)) / (2 * a);                              //wurzel1 wird mit Hilfe des Math.Pow() Commands berechnet. Math.Pow ist der ersatz für hoch 2 z.B. in Math.pow wäre x^2 Math.Pow(x,2);
            double wurzel2 = Math.Pow(b, 2) - (4 * (a * c)) / (2 * a);                              //wurzel2 wird ebenso mit Hilfe des Math.Pow() Commands berechnet nur wird ein das erste plus durch ein minus ersetzt


            double root1 = (bn + (Math.Sqrt(wurzel1))) / (2 * a);                                   //double root1 wird aus den Werten bn + der Wurzel von wurtel1 und anschließend druch 2*a berechnet
            double root2 = (bn - (Math.Sqrt(wurzel2))) / (2 * a);                                   //double root1 wird aus den Werten bn - der Wurzel von wurtel2 und anschließend druch 2*a berechnet
            Console.WriteLine("Root 1: {0} ", Math.Round(root1, 4));                                //Anschließend wird das Ergebnis von root1 mit Hilfe des Math.Round(x,y) commands auf 4 Nachkommerstellen gerundet
            Console.WriteLine("Root 2: {0}", Math.Round(root2, 4));                                 //ebenso wird das Ergebnis von root2 mit Hilfe des Math.Round(x,y) commands auf 4 Nachkommerstellen gerundet

            Console.ReadLine();
        }
        public static void Aufgabe20()
        {// Das Programm zählt von 1 bis zur User-Eingabe. Sollte die Eingabe größer als 80 schreibt er einen Error
            int x;
            Console.WriteLine("Geben Sie eine Zahl zwischen 0 und 80 ein");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 1 || x > 80 || x == 0)                                                          //Überprüft ob  x KLEINER als 0 ODER x GRÖSSER als 80 ODER ob x GLEICH 0 ist
            {
                Console.WriteLine("ERROR");                                                         //Gibt einen ERROR aus falls eines oder drei genanntenBedingungen anfällt,
            }
            else
            {
                Console.WriteLine("Gut");                                                           //falls nicht schreib er Gut
            }
            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(i);                                                               //anschließend  gibt er solange i aus bis er bei der oben eingegebenen User-Eingabe ankommt.
            }


            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe21()
        {// Das Programm soll 5 zahlen akzeptieren und anschließend alle ungeraden Zahlen zwischen den Eingabe zusammen zählen und amENDE, drücken Sie Enter um das Programm zu schließen ausgeben
            int[] numbers = new int[5];                                                             //int[] erstellt eine Array die 5 Indexe groß sein soll
            int sum = 0;                                                                            //Erstellt eine Variable sum mit einem Wert von 0
            Console.WriteLine("Geben Sie bitte 5 Zahlen ein:");                                     //User wird aufgefordert 5 Zahlen einzugeben

            for (int i = 0; i < numbers.Length; i++)                                                //die for-Schleife wird solange ausgeführt solange i kleiner als das oben erstellte Array ist, also kleiner als 5
            {
                Console.Write("Zahl {0}: ", i+1);                                                   //Erstellt eine Ausgaben mit der jeweiligen Zahl
                numbers[i] = int.Parse(Console.ReadLine());                                         //dem Array numbers wird die Variable i zugewiesen, damit die User-Eingabe immer die gleiche Zahl ist die auf der i gerade steht.
            }
            for (int i = 0; i < numbers.Length; i++)                                                //die for-Schleife wird solange ausgeführt solange i kleiner als das oben erstellte Array ist, also kleiner als 5
            {
                if (numbers[i] % 2 != 0)                                                            //die Werte von numbers[i] werden überprüft ob die Reste bei einer division durch 2 nicht 0 sind
                {
                    sum += numbers[i];                                                              //sollte die Bedingung true sein wird der Variable sum der Wert sum + numbers[i] zugewiesen
                }
            }
            Console.WriteLine(sum);                                                                 //Ausgabe der Werte von sum

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe22()
        {
            int[] numbers = new int[3];                                                             //Es wird ein Array mit 3 Indexwerten reserviert.

            Console.WriteLine("Geben Sie 3 Zahlen ein");                                            //user wird aufgefordert 3 Zahlen einzugeben
            for (int i = 0; i < 3; i++)                                                             //for-Schleife läuft solange i kleiner als 3 ist
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());                                   //Convert.ToInt32 konvertiert alle Eingabe (Console.ReadLine) in eine int Zahl und weißt sie anschließend numbers[i] zu
            }
            Array.Sort(numbers);                                                                    //Das Array numbers wird mit Hilfe des Array.Sort(); commands sortiert
            foreach (int i in numbers)                                                              //in der foreach-Schleife werden ausschließlich Array-Elemente wieder gegeben. numbers wird int i zugewiesen
            {
                Console.WriteLine("\n{0}",i);                                                       //Gibt die Elemente von i numbers aus
            }

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe23()
        {//Überprüfung ob aus 3 Werten ein Dreieck erstellt werden kann
            float[] numbers = new float[3];

            Console.WriteLine("Geben Sie die 3 Seiten ein");                                        //Fordert den User auf 3 Seitenlängen einzugeben
            for (int i = 0; i < numbers.Length; i++)                                                //for-Schleife läuft solange i kleiner als die Indexlänge des Arrays ist
            {
                Console.Write("Seite {0}: ", i+1);                                                  //Erstellt eine Ausgabe mit der aktuallen Zahls
                numbers[i] = float.Parse(Console.ReadLine());                                       //User-Eingabe wird im jeweilig aktuellen Array index gespeichert
            }
            if (numbers[0] + numbers[1] > numbers[2] && numbers[0] + numbers[2] > numbers[1] && numbers[1] + numbers[2] > numbers[0])           //Überprüft mit der Rechnung ob ein Dreieck erstellt werden kann
            {
                Console.Write("Ist ein Dreieck");                                                   //Falls die Bedingung true sein sollte gibt es eine Ausgabe
            }
            else
            {
                Console.WriteLine("Ist kein Dreieck");                                              //Falls nicht gibt er ebenfalls eine Nachricht aus
            }
            Console.WriteLine("\nDer Umfang des Dreiecks ist: {0}", numbers[0] + numbers[1] + numbers[2]);          //Gibt das Ergebniss der Rechnung aus

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe24()
        {//Zwei Ganzzahlen werden eingegeben und überprüft ob eine davon ein mehrfaches der anderen ist
            Console.WriteLine("Geben Sie 2 Ganzzahlen ein\n");                                      //Fordert den User auf 2 Ganzezahlen einzugeben (int Zahlen)
            int nummer = 0;                                                                         //erstellt eine Variable mit dem Datentypen int
            int[] zahl = new int[2];                                                                //erstellt ein Array mit 2 Indexplätzen
            do
            {
                if (int.TryParse(Console.ReadLine(), out int x) == true)                            /*Überprüft ob User-Eingabe in int konvertiert werden kann, wenn nicht Error-Code
                                                                                                      wenn ja wird die User-Eingabe in x gespeichert und weiter verwendet.*/
                {
                    zahl[nummer] = x;
                    nummer++;
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl eingegeben");
                }
            } while (nummer < 2);                                                                   //Die do-Schleife wird solange ausgeführt solange nummer KLEINER als 2 bleibt
            if ((zahl[0] % zahl[1]) == 0 || (zahl[1] % zahl[0]) == 0)                               //Überprüft ob zahl[0] modulo zahl[1] == 0 ist also quasi ob der Rest der division zwischen zahl[0] und zahl[1] 0 ist. Das gleiche bei zahl[1] und zahl[0]
            {
                Console.WriteLine("Mehrfaches Verhältnis");                                         //Die Ausgabe erfolgt wenn eine von den beidenBedingungen true ist
            }
            else
            {
                Console.WriteLine("Kein mehrfaches Verhältnis");                                    //Wenn keine der beidenBedingungen true ist erfolgt eine "Error"-Ausgabe
            }
            Console.WriteLine("\nProgramm beendet");

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe25()
        {//Nach Eingabe einer Zahl die auf 0-11 beschränkt wird, wird der zugehörige Monat ausgegeben
            string[] Month = new string [12];                                                       //Erstellt eine Array mit 12 Indexplätzen
            Month[0] = ("January");                                                                 //}
            Month[1] = ("February");                                                                //}
            Month[2] = ("March");                                                                   //}
            Month[3] = ("April");                                                                   //}
            Month[4] = ("Mai");                                                                     //}
            Month[5] = ("June");                                                                    //}--> Weißt jeweils dem ausgewählten Indexplatz den Wert zu
            Month[6] = ("July");                                                                    //}
            Month[7] = ("August");                                                                  //}
            Month[8] = ("September");                                                               //}
            Month[9] = ("October");                                                                 //}
            Month[10] = ("November");                                                               //}
            Month[11] = ("December");                                                               //}

            Console.Write("Geben Sie eine Zahl zwischen 1 und 12 ein ");                            //Fordert den user auf eine Zahl zwischen 1 und 12 einzugeben
            if (int.TryParse(Console.ReadLine(), out int x) == true)                                //int.TryParse(Console.ReadLine) versucht die Eingegebenen Werte in ein int Typ um zu wandeln und anschließend gibt er sie in int x aus
            {
                if (x < 1) { x = 1; }                                                               //überprüft ob x kleiner als 1 ist wenn ja ist x gleich 1
                if (x > 12) { x = 12; }                                                             //falls x größer als 12 ist ist x gleich 12
                Console.WriteLine("\nDie Zahl {0} = {1}\n", x, Month[x - 1]);                       //Gibt den jeweiligen Monat mit der zu gehörigen Zahl aus
            }
            else
            {
                Console.WriteLine("\nNix da\n");                                                    //Falls die oben genannteBedingung nicht zu trifft gibt er eine "Error"-Meldung aus
            }

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe26()
        {//Das Programm gibt alle graden Zahlen von 2 bis 50 aus

            for (int x = 2; x <= 50; x += 2)                                                        //Erstellt eine int variable mit dem Wert 2, erstellt eine Bedingung, x kleiner oder gleich 50 und zählt x bei jedem durchgang +1
            {
                Console.Write(x + ", ");                                                            //Gibt x und ein , aus. Z.B. 1,2,3, etc. bis zur gewählten Zahl
            }
            Console.WriteLine("\n\nENDE");
            Console.ReadLine();
        }
        public static void Aufgabe27()
        {//Das Programm ließt 5 Zahlen ein (positiv oder negativ) und zählt die Anzahl der positiven bzw. negativen Zahlen

            int neg = 0;                                                                            //erstellt eine int Variable mit Wert 0
            int[] zahlen = new int[5];                                                              //erstellt eine int Array mit Indexplätzen von 5
            int nummer = 0;                                                                         //erstellt eine int Variable mit Wert 0

            Console.WriteLine("Geben Sie 5 negative und positive Zahlen ein");
            do
            {
                if (int.TryParse(Console.ReadLine(), out int x) == true)                            //Überprüft ob die User-Eingabe in int konvertiert werden kann, speichert sie in x
                {
                    zahlen[nummer] = x;                                                             //Falls die oben angegebene Bedingung wird x zahlen[nummer] zu gewiesen
                    nummer++;                                                                       //und zählt bei jedem durchlauf nummer +1
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl eingegeben");                             //falls nicht gibt er eine "Error"-Meldung aus
                }
            } while (nummer <= 4);                                                                  //die Codeblöcke in do-while werden solange ausgeführt solange nummer kleiner oder gleich 4 ist

            for (int i = 0; i <= 4; i++)                                                            //Erstellt eine int variable mit dem Wert 0, erstellt eine Bedingung, i kleiner oder gleich 4 und zählt i bei jedem durchgang +1
            {
                if (zahlen[i] < 0) { neg++; }                                                       //Erstellt eine Bedingung, falls zahlen[i] < 0 zählt er neg +1
            }
            Console.WriteLine("Es sind {0} negative Zahlen und {1} positive Zahlen", neg, 5 - neg); //Ausgabe der negativ und positiv gezählten Zahlen

            Console.WriteLine("\n\nENDE");
            Console.ReadLine();                                                                     //Wartet auf User-Eingabe um das programm entgültig zu schließen
        }
        public static void Aufgabe28()
        {//Das Programm liest 5 Zahlen ein und zählt die Nummer der positiven Zahlen und schreibt sie aus

            int pos = 0;                                                                            //Erstellt eine int Variable mit dem Wert 0
            int[] zahl = new int[5];                                                                //Erstellt eine Array mit 5 Indexplätzen
            int nummer = 0;                                                                         //Erstellt eine int Variable mit dem Wert 0
            int sum = 0;                                                                            //Erstellt eine int Variable mit dem Wert 0

            Console.WriteLine("Geben Sie 5 Zahlen ein");
            do
            {
                if (int.TryParse(Console.ReadLine(), out int x) == true)                            //Erstellt eine Abfrage. Falls die User-Eingabe in int konvertiert werden kann wird sie in x ausgeschrieben
                {
                    zahl[nummer] = x;                                                               //Wenn die oben genannte Bedingung true ist, wird zahl[nummer] = x
                    nummer++;                                                                       //und nummer wird bei jedem Durchgang +1 gezählt
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl eingegeben");                             //sollte die oben genannte Bedingung nicht true sein wird eine Error-Nachricht ausgeschrieben
                }
            } while (nummer <= 4);                                                                  //Der Durchgang wird solange wiederholt solange nummer KLEINER oder GLEICH 4 ist

            for (int x = 0; x <= 4; x++)                                                            //Erstellt eine for-Schleife die ausgeführt wird solange x KLEINER oder GLEICH  4 ist. x wird bei jedem Durchgang +1 gezählt
            {
                if (zahl[x] > 0)                                                                    //Erstellt eine if-Abfrage die Überprüft ob zahl[x] GRÖSSER als NULL ist
                {
                    pos++;                                                                          //Sollte die oben genannte Bedingung true sein wird pos +1 gezählt
                    sum += zahl[x];                                                                 //sum wird aus dem Ergebnis von sum + zahl[x] zusammen gesetzt
                }
            }
            Console.WriteLine("Anzahl der positiven Zahlen: {0}\nDurschnitt der positiven: {1:F2}", pos, sum / pos);        //Anschließend werden die positive Zahlen zusammen mit dem Quotienten der Division, sum / pos, ausgegeben

            Console.WriteLine("\n\nENDE");                                                          //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe um zu verhindern das sich das Programm schließt
        }
        public static void Aufgabe29()
        {//Von 5 eingegebenen Zahlen werden die ungeraden zusammen gezählt

            int nummer = 0;                                                                         //}
            int sum = 0;                                                                            //} --> Erstellt zwei Variablen mit den Werten 0

            Console.WriteLine("Geben Sie 5 ungerade und gerade Zahlen ein");
            do
            {
                if (int.TryParse(Console.ReadLine(), out int x) == true)                            //Erstellt eine if-Abfrage die überprüft ob die User-Eingabe in int konvertiert werden kann
                {
                    if (x % 2 != 0) { sum += x; }                                                   //Erstellt eine tweite if-Abfrage um zu überprüfen ob die User-Eingabe gerade oder ungerade ist. Falls sie NICHT null ist wird sum = sum + x gerechnet
                    nummer++;                                                                       //nummer wird bei jedem Durchgang +1 gezählt
                }
                else                                                                                //sollte die Bedingung der ersten Abfrage nicht true sein
                {
                    Console.WriteLine("Keine gültige Zahl eingegeben");                             //wird eine Error-Nachricht ausgeschrieben
                }
            } while (nummer <= 4);                                                                  //Alles wird solange wiederholt solange nummer KLEINER oder GLEICH 4 ist
            Console.WriteLine("Summe aller ungeraden Zahlen ist {0}", sum);                         //Zum Schluss wird die summe ausgegeben


            Console.WriteLine("\n\nENDE");                                                          //Kennteichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Verhindert das sich das Programm schließt, nur mit User-Eingabe wird es geschlossen
        }
        public static void Aufgabe30()
        {//Schreibt das Quadrat jeder geraden Zahl von 1 bis 4

            Console.WriteLine("Geben Sie die Menge an benötigten Zahlen an\n");                     //Fordert den User aus eine Menge der benötgten Zahlen einzugeben
            if (int.TryParse(Console.ReadLine(), out int x) == true)                                //Erstellt eine if-Abfrage die überprüft die User-Eingabe in int konvertiert werden kann, falls die Bedingung wahr ist,
            {
                for (int i = 1; i <= x; i++)                                                        //wird eine for-Schleife erstellt die solange durchlaufen wird solange i KLEINER oder GLEICH x, also der User-Eingabe ist
                {
                    Console.WriteLine("{0} hoch 2: {1}", i, Math.Pow(i, 2));                        //in dieser Schleife wird die aktuelle zahl zusammen mit der aktuellen Zahl hoch 2 ausgegeben
                }
            }
            else                                                                                    //sollte die Abfrage false sein,
            {
                Console.WriteLine("ungültige Eingabe");                                             //wird eine Error-Nachricht ausgegeben
            }
            Console.WriteLine("ENDE, drücken Sie Enter um das Programm zu schließen");              //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe die das Programm schließen soll
        }
        public static void Aufgabe31()
        {//Überprüft ob eine eingegebene Zahl positiv, Negativ oder NULL ist
            int zahl = 0;                                                                           //Erstellt eine int Variable mit dem Wert 0
            string art = "Positiv";                                                                 //Erstellt eine string Variable mit dem Wert "Positiv"

            Console.WriteLine("Geben Sie eine Zahl sein.\n Zahl kann negativ, positive oder null sein.");       //Fordert den Benutzer aus eine Zahl einzugeben die minus, null oder positiv sein kann
            if (int.TryParse(Console.ReadLine(), out int x) == true)                                //Erstellt eine if-Abfrage die überprüft ob die Benutzer-Eingabe in int konventiert werden kann, falls ja,
            {
                zahl = x;                                                                             //wird die User-Eingabe x der bestehenden Variable zahl überschrieben

            }
            if (zahl == 0)                                                                          //eine weiter if-Abfrage erstellt die überprüft ob zahl GLEICH Null ist, falls jq
            {
                art = "NULL";                                                                       //wird art gleich Null
            }
            else                                                                                    //sollte die oben genannte Bedingung false sein,
            {
                if (zahl < 0) { art = "Negativ"; }                                                  //wird eine neue Abfrage erstellt die Überprüft ob der Wert von zahl unter der nuller Grenze liegt falls ja wird art "Negativ"
            }
            Console.WriteLine("Die Zahl ist {0}", art);                                             //anschließend wird art ausgegeben

            Console.WriteLine("ENDE, drücken Sie Enter um das Programm zu schließen");              //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Warter auf Benutzer-Eingabe um das Programm entgültig zu beenden
        }
        public static void Aufgabe32()
        {// Alle Nummer zw. 1 und 500, Step = Eingabe, Startzahl = 3
            int zahl;                                                                               //Erstellt eine Variable mit dem Wert Null

            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 500 ein");                        //Fordert den Benutzer eine Zahl zwischen 1 und 500 einzugeben
            do
            {
                if (!int.TryParse(Console.ReadLine(), out zahl) == true)                            //Die erstellte Abfrage überprüft ob die Eingegebene Zahl NICHT konvertiert werden kann,
                {
                    Console.WriteLine("Ungültige Zahl, neue Eingabe!");                             //sollte die oben genannte Bedingung zutreffen wird eine Error-Nachricht ausgegeben
                }
            } while (zahl < 1 || zahl > 500);                                                       //Alles inerhalb der do-while Schleife wird solange ausgebführt solange zahl KLEINER als 1 ist

            for (int i = 0; i <= (zahl - 500); i += zahl)                                           //Erstellt eine for-Schleife die solange aktiv ist solange i KLEINER oder GLEICH  (500 minus den Wert von Zahl)
            {
                Console.WriteLine(i + 3);                                                           //Anschließend wird i+3 ausgegeben
            }
            Console.WriteLine("\n\nENDE");                                                          //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Warter auf eine User-Eingabe um das Programm entgültig zu schließen
        }
        public static void Aufgabe33()
        {// User-Eingabe werden im Array gespeichert und es wird die höstezahl + deren Index ausgegeben
            int[] arr1 = new int[5];                                                                //Erstellt eine integer Array mit 5 Indexplätzen
            int x = 5;                                                                              //Erstellt eine integer Variable mit einem Wert von 5
            int mx = 0;                                                                             //Erstellt eine integer Variable mit einem Wert von 0
            int n = 0;

            Console.WriteLine("Geben Sie fünf Zahlen ein");                                         //Fordert den Nutzer auf, fünf Zahlen einzugeben

            for (int i = 0; i < x; i++)                                                             //Erstellt eine for-Schleife die solange aktive ist, solange i KLEINER als x ist
            {
                Console.Write("element - {0} : ", i);                                               //Gibt die aktuellen Elemente der erstellten Array aus
                arr1[i] = Convert.ToInt32(Console.ReadLine());                                      //Konvertiert die User-Eingabe in int und wird anschließend arr1[i] zugewiesen
            }
            for (int i = 1; i < x; i++)                                                             //Erstellt eine for-Schleife die solange aktive ist, solange i KLEINER als x ist
            {
                if (arr1[i] > mx)                                                                   //Erstellt eine if-Abfrage und überprüft ob arr1[i] GRÖSSER als mx ist
                {
                    mx = arr1[i];                                                                   //ist die Bedingung true wird arr1[i] mx zugewiesen
                    n = i;                                                                          //und n wird der Wert von i zugewiesen
                }
            }
            Console.Write("Maximum element is : {0} und ist im Index {1}\n", mx, n);                //Gibt die Werte mx und n aus

                Console.WriteLine("Ende, drücken Sie ENTER um das Programm zu beenden");                 //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Wartet auf User-Eingabe um das Programm entgültig zu beenden
        }
        public static void Aufgabe34()
        {// Passwort Eingabe mit 3 Versuchen
            string Passwort = "Passwort";                                                           //Erstellt eine string Variable mit dem Wert "Passwort"

            do
            {
                Console.Write("Geben Sie das Passwort ein: ");                                      //Fordert den Benutzer auf das Passwort einzugeben
                if (Console.ReadLine() == Passwort)                                                 //Erstellt eine Abfrage die Überprüft ob die User-Eingabe dem Passwort übereinstimmt
                {
                    break;                                                                          //falls ja, wir die Abfrage beendet
                }
                else                                                                                //falls nicht wird eine Error-Nachricht ausgeschrieben
                {
                    Console.WriteLine("Falsches Passwort");                                         //Gibt die Nachricht aus
                }
            } while (true);                                                                         //Führt die Abfrage solange aus solange es true ist
            Console.WriteLine("Passwort KORREKT");                                                  //Sollte die Abfrage und somit die Schleife verlassen werden wird eine Nachricht ausgegeben

            Console.WriteLine("\nENDE");                                                            //Zeichnet das Ende des Proramms
            Console.ReadLine();
        }
        public static void Aufgabe35()
        {// Koordinatenpunkt eingeben und den Quadranten feststellen
            int x;                                                                                  //}-->
            int y;                                                                                  //}-->Erstllt 3 integer Variblen mit jweils de Wert Null
            int Test = 0;                                                                           //}-->

            Console.WriteLine("Geben Sie die Koordinaten ein:");                                    //Fordert den Nutzer auf Koordinaten einzugeben
            do
            {
                Console.WriteLine("Geben Sie die x-Koordinate ein");                                //Fordert den User auf die x-Koordinate einzugeben
                if (int.TryParse(Console.ReadLine(), out x) == true)                                //Erstellt eine Abfrage die versucht die User-Eingabe in int zu konvertieren und als x zu speichern
                {
                    Test = 1;                                                                       //sollte die Bedingung true sein wird Test von 0 zu 1
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl für X");                                  //Sollte die Abfrage false sein wird eine Error-Nachricht ausgeschrieben
                }
            } while (Test == 0);                                                                    //do wird solange aus geführt solange Test GLEICH  null ist

            do
            {
                Console.WriteLine("Geben Sie die y-Koordinate ein");                                //Fordert den Benutzer auf die y-koordinate einzugeben
                if (int.TryParse(Console.ReadLine(), out y) == true)                                //Erstellt eine if-Abfrage die überprüft und versucht die User-Eingabe in int konvertieren
                {
                    Test = 0;                                                                       //Wenn die Bedingung zutrifft ist Test wieder bei 0
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl für y");                                  //Sollte die Bedingung false sein wird eine Error-Nachricht ausgegeben
                }
            } while (Test == 1);                                                                    //do-while -Schleife wird solange ausgeführt solange Test 1 ist
            Console.WriteLine("Koodrinaten sind x = {0}, y = {1}\n", x, y);

            int QNummer = 0;                                                                        //Erstellt eine Variable für die gebrauchten Quadranten
            string Quad = "Der Koordinatenpunkt befindet sich im";                                  //Gibt dem Koordinaten Punkt
            if (x < 0 && y < 0)                                                                     //Erstellt Abfragen wo jeweils überprüft wird ob x GRÖSSER ODER GLEICH den jweilig bebrauchten Wert ist
            {
                QNummer = 3;                                                                        //}
            }
            else if (x < 0 && y > 0)
            {
                QNummer = 2;                                                                        //}
            }
            else if (x > 0 && y < 0)
            {
                QNummer = 4;                                                                        //} --> Besimmen jeweils den aktuellen Quadranten der Koordinatenpunkte mit den davor eingegebenen Bedingungen
            }
            else if (x > 0 && y > 0)
            {
                QNummer = 1;                                                                        //}
            }
            else if (x == 0 && y == 0)
            {
                QNummer = 0;                                                                        //}
            }
            if (QNummer > 0)
            {
                Console.WriteLine("{0} {1}.Quadranten", Quad, QNummer);                             //Gibt die Quadranten aus
            }
            else
            {
                Console.WriteLine("Punkt befindet sich im Ursprung");                               //sollten diese Bedeninungen alle nicht zutreffen befindet er sich im Mittelpunkt
            }


            Console.WriteLine("\nENDE");                                                            //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Wartet auf User-Eingabe die das Programm entgültig schließt
        }
        public static void Aufgabe36()
        {// Die Summer aller Zahlen zwischen 2 Zahlen die nicht durch 17 teilbar sind
            int summe = 0;                                                                          //Erstellt eine integer Variable mit dem Wert von Null

            Console.WriteLine("Geben Sie zwei Zahlen ein:");                                        //Fordert den User auf zwei Zahlen einzugeben
            if (int.TryParse(Console.ReadLine(), out int x) == true)                                //Erstellt eine Abfrage die überprüft ob die Eingabe des users in int konvertierbar ist
            {
                Console.WriteLine("Die 1.Zahl ist {0}", x);                                         //Sollte die Bedingung true sein wird die 1. Eingabe ausgegeben
            }
            else
            {
                Console.WriteLine("Keine gültige Zahl angegeben");                                  //Falls nicht, wird eine Error-Nachricht ausgegeben
            }

            if (int.TryParse(Console.ReadLine(), out int y) == true)                                //Erstellt eine Abfrage die überprüft ob die Eingabe des users in int konvertierbar ist
            {
                Console.WriteLine("Die 2.Zahl ist {0}", y);                                         //Sollte die Bedingung true sein wird die 1. Eingabe ausgegeben
            }
            else
            {
                Console.WriteLine("Keine gültige Zahl angegeben");                                  //sollte die Bedingung nicht true sein wird eine Error-Nachricht ausegegeben
            }

            int a;                                                                                  //Erstellt eine int Variable mit nuller Wert

            if (y < x)                                                                              //Erstellt eine Abfrage mit der Bedingung, y KLEINER x
            {
                a = y;                                                                              //sollte die Bedingung zutreffen wird der y Wert a zugewiesen
                y = x;                                                                              //anschließend wird y der Wert von x zugewiesen
                x = a;                                                                              //nachdem wird x der Wert von a übertragen
            }
            Console.WriteLine("\n{0}, {1}", x, y);                                                  //Dannach erfolgt die Ausgabe von x und y

            for (int i = x; i <= y; i++)                                                            //Erstellt eine for-Schleife mit der Bedingung i KLEINER oder GLEICH y
            {
                a = i % 17;                                                                         //a wird der Rest der Division zwischen i und 17 zugewiesen

                if (a != 0)                                                                         //Überprüft ob a NICHT GLEICH null ist
                {
                    summe += i;                                                                     //Trifft die Bedingung zu wird summe = summe+i gerechnet
                }
            }
            Console.WriteLine("Die Summe der zahlen zwischen x und y,\ndie nicht durch 17 teilbar sind = {0} ", summe);       //Gibt die summe aus

            Console.WriteLine("\nENDE");                                                            //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Warte auf eine User-Eingabe damit das Programm entgültig geschlossen wird
        }
        public static void Aufgabe37()
        {// zahlen durch 7 dividieren und wenn der Rest gleich 2 oder 3: Zahl wird ausgegeben
            int a;                                                                                  //Erstellt eine int Variable mit einem nuller Wert

            Console.WriteLine("Geben Sie zwei Zahlen ein");                                         //Fordert den Benutzer auf zwei Zahlen einzugeben
            if (int.TryParse(Console.ReadLine(), out int x) == true)                                //Erstellt eine Abfrage und überprüft ob die User-Eingabe in int konvertierbar ist
            {
                Console.WriteLine("Die 1.Zahl ist {0}", x);                                         //Wenn die Bedingung true ist, wird x ausgegeben
            }
            else
            {
                Console.WriteLine("Keine gültige Zahl angegeben");                                  //Wenn die Bedingung false ist wird eine Error-Nachricht ausgegeben
            }

            if (int.TryParse(Console.ReadLine(), out int y) == true)                                //Erstellt eine Abfrage und überprüft ob die User-Eingabe in int konvertierbar ist
            {
                Console.WriteLine("Die 2.Zahl ist {0}", y);                                         //Wenn die Bedingung true ist, wird x ausgegeben
            }
            else
            {
                Console.WriteLine("Keine gültige Zahl angegeben");                                  //Wenn die Bedingung false ist wird eine Error-Nachricht ausgegeben
            }

            if (y < x)                                                                              //Erstellt eine Abfrage mit der Bedingung, y KLEINER x
            {
                a = y;                                                                              //sollte die Bedingung zutreffen wird der y-Wert -> a zugewiesen
                y = x;                                                                              //anschließend wird y der Wert von x zugewiesen
                x = a;                                                                              //nachdem wird x der Wert von a übertragen
            }

            for (int i = x; i < y; i++)                                                             //Erstellt eine for-Schleife
            {
                a = i % 7;                                                                          //a wird der Rest der Division zugewiesen
                if (a == 2 || a == 3)                                                               //Erstellt eine if-Abfrage mit 2 mglichen Bedingungen
                {
                    Console.WriteLine(i);                                                           //sollte die oben hinzugefügte Bedingung true sein wird i ausgegeben
                }
            }

            Console.WriteLine("\nENDE");                                                            //Kennzeichnet das Ende des Programms
            Console.ReadLine();                                                                     //Warte auf eine User-Eingabe um das Programm entgültig zu schließen
        }
        public static void Aufgabe38()
        {// Zahlen in 3er Linien
            double a = 0;                                                                           //Erstellt eine double Variable mit dem Wert von 0

            Console.WriteLine("Geben Sie eine Zahl ein");                                           //Fordert den Benutzer auf eine Zahl einzugeben
            if (int.TryParse(Console.ReadLine(), out int x) == true)                                //Erstellt eine Abfrage die überprüft ob die User-Eingabe in in konvertierbar ist
            {
                Console.WriteLine("Die 1.Zahl ist {0}", x);                                         //Gibt die 1-Zahl (x) aus
            }
            else
            {
                Console.WriteLine("Keine gültige Zahl angegeben");                                  //Wenns es nicht wahr ist wir deine Error-nachricht ausgegeben
            }
            x *= 3;                                                                                 //x wird berechnet
            for (int i = 1; i <= x; i++)                                                            //Erstellt eine Schleife die solange läuft solange i KLEINER oder GLEICH x ist
            {
                Console.Write("{0}, ", i);                                                          //i wird ausgegeben
                a++;                                                                                //a wird bei jedem Durchlauf +1 gezählt
                if (a == 3)                                                                         //Erstellt eine Abfrage mit Bedingung a GLEICH 3
                {
                    Console.WriteLine("");                                                          //"" wird ausgeben
                    a = 0;                                                                          //a wird wieder zu 0
                }
            }

            Console.WriteLine("\nENDE");                                                            //Kennteichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Wartet auf eine user-Eingabe um das Programm zu schließen
        }
        public static void Aufgabe39()
        {

            Console.WriteLine("Geben Sie eine Zahl ein");                                           //Fordert den Nutzer auf eine zahl einzugeben
            if (int.TryParse(Console.ReadLine(), out int x) == true)                                //Erstellt eine User-Eingabe die in int konvertiert werden soll
            {
                Console.WriteLine("Die eingegebene Zahl ist {0}", x);                               //Gibt den Wert von x aus
            }
            else
            {
                Console.WriteLine("Keine gültige Zahl angegeben");                                  //Sollte die oben genannte Bedingung false sein wird eine Error-Nachrcht ausgegeben
            }
            for (int i = 1; i <= x; i++)                                                            //Erstellt eine for-Schleife, die solange aktiv ist, solange i KLEINER oder GLEICH x ist
            {
                Console.Write("{0}, {1}, {2}\n", i, Math.Pow(i, 2), Math.Pow(i, 2) * i);            //Gibt die aktuelle Zahl(i), aktuelle Zahl(i) ^2 und aktuelle Zahl(i) ^2 * aktuelle Zahl (i)
            }

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                  //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                      //Wartet auf User-Eingabe um das Programme entgültig zu beenden
        }
        public static void Aufgabe40()
        {
            int p;                                                                                   //}
            int q;                                                                                   //}Die Variablen werden mit dem Datentyp integer und dem Wert null erstellt
            do
            {
                if (int.TryParse(Console.ReadLine(), out p) == true)                                 //Erstellt eine if-Abfrage die überprüft ob die User-Eingabe in int konvertiert werden kann
                {
                    Console.WriteLine("Anzahl Zeilen: {0}", p);                                      //Sollte die oben genannte Bedingung true sein wird p ausgegeben
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl angegeben");                              //Sollte die oben genannte Bedingung false sein wird eine Error-Nachicht ausgegeben
                }
                if (int.TryParse(Console.ReadLine(), out q) == true)                                //Erstellt eine if-Abfrage due überprüft ob die User-Eingabe in int konvertiert werden kann
                {
                    Console.WriteLine("Anzahl Charakter: {0}", q);                                  //Sollte die Bedingung true sein gibt das Programm q bzw. die Anzahl der Charakter aus
                }
            } while (p < 1 && q < 1);                                                               //Der Codeblock in der do-while-Schleife wird solange ausgeführt solange p KLEINER als 1 und Q KLEINER als 1 ist

            for (int i = 1; i <= (p * (q - 1)); i += q)                                             //Die for-Schleife  wird solange ausgeführt solange i KLEINER oder GLEICH (p*)q-1)) ist
            {
                {
                    Console.Write("{0}, ", i);                                                      //Anschließend wird n ausgegeben
                }
            }
            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                //Kennzeichnet das Ende des Programmes
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe zum vollständigen Beenden
        }
        public static void Aufgabe41()
        {
            int Anzahl;                                                                             //Erstellt eine int Variable mit einem nuller Wert
            int n = 0;                                                                              //Erstellt eine integer Variable mit einem Wert von 0
            double summe = 0;                                                                       //Erstellt eine double Variable mit einem Wert von 0

            Console.WriteLine("Wie viele zahlen sollen eingegeben werden?\n");                      //Fordert den Benutzer auf die Anzahl der benötigten zahlen einzugeben
            do
            {
                if (int.TryParse(Console.ReadLine(), out Anzahl) == true) {}                        //Erstellt eine if-Abfrage die überprüft ob die User-Eingabe nach int konvertiert werden kannw
                else
                {
                    Console.WriteLine("ungültige Zahl");                                            //Falls die Bedingung nicht true sein sollte wird eine Error-Nachicht ausgegeben
                }
            } while (Anzahl < 0);                                                                   //Der Codeblock in der do-while-Schleife wird solange ausgeführt solange Anzahl KLEINER als 0 ist
            Console.WriteLine("Es werden {0} Zahlen benötigt\n", Anzahl);                           //Anschließend gibt der die Anzahl der benötigten Zahlen aus
            int[] Zahlen = new int[Anzahl];                                                         //Erstellt eine int Array mit die als Indexanzahl de Variable Anzahl hat

            do
            {
                Console.WriteLine("Geben Sie die {0}. Zahl ein", n + 1);                            //Gibt n+1 aus
                if (int.TryParse(Console.ReadLine(), out int x) == true)                            //Erstellt eine if-Abfrage die überprüft ob die User-Eingabe nach int konvertierbar ist
                {
                    Console.WriteLine("Die {0}.Zahl ist {1}\n", n + 1, x);                          //Falls die Bedingung true ist gibt das Programm n+1 und x aus
                    Zahlen[n] = x;                                                                  //Zahlen[n] ist gleich der Wert von x
                    n++;                                                                            //n wird bei jedem Durchlauf +1 gerechnet
                }
                else
                {
                    Console.WriteLine("Keine Zahl");                                                //Sollte die Bedingung false sein wird eine Felermedlung ausgeschrieben
                }
            } while (n < Anzahl);                                                                   //Die do-while-Schleife wird solange ausgeführt solange n KLEIENR ist als Anzahl

            Console.WriteLine("Es wruden die folgenden {0} zahlen eingegeben:\n", Anzahl);          //Anschließend gibt das Programm nochmals alle eingegebenen Zahlen aus
            for (int i = 0; i <= Anzahl - 1; i++)                                                   //Erstellt eine for-Schleife die solange ausgeführt wird solange i KLEINER oder GLEICH Anzahl ist
            {
                Console.Write(Zahlen[i] + ", ");                                                    //Dannach wird Zahlen[i] mit Beistrichen ausgegeben
                summe += Zahlen[i];                                                                 //Anschließend wird summe + Zahlen[i] zusammengezählt und summe zugewiesen
            }
            Console.WriteLine("Der Durchschnitt der Zahlen ist: {0}", summe / Anzahl);              //Dannach wird der Durchschnitt berechnet und ausgegeben (summe / Anzahl)
            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                 //Kennzeichnet im ausgeführten Programm das Ende des Programm, User wird ausgefordert Enter zu drücken um das Programm zu beenden
            Console.ReadLine();                                                                     //Wartet auf User.Eingabe zum vollständigen beenden des Programmes
        }
        public static void Aufgabe42()
        {
            Console.Write("Summe = 1 + 1/2 + 1/3 + ... + 1/50 = ");                                 //Gibt die Aufgabenstellung bzw. die ungefähre Lösung aus wie das Programm zufunktionieren hat
            double summe = 0;                                                                       //Anschließend wird eine double Variable mit dem Wert 0 erstellt

            for (double i = 1; i <= 50; i++)                                                        //Erstellt eine for-Schleife die solange ausgeführt wird solange i KLEINER oder GLEICH 50 ist
            {
                summe += (1 / i);                                                                   //der Wert der Variable summe setzt sich aus der Rechnung summe = summe +  (1 / i)
            }
            Console.Write("{0:F2}", summe);                                                         //Anschließend wir die Summe mit zwei Nachkommerstellen ausgegeben

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                //Kenzeichnet das Ende des Programmes und fordert den User auf Enter zu drücken
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe um das Programm entgültig zu beenden
        }
        public static void Aufgabe43()
        {
            double summe = 1.0 + 3.0 / 2.0 + 5.0 / 4.0 + 7.0 / 8.0;                                 //Erstellt eine double Variable mit der oben angegebenen Rechnung

            Console.Write("Die Summe aus 1 + 3/2 + 5/4 + 7/8 ist:");                                //Anschließend gibt er eine die Summe mit den davor angegebenen Text aus
            Console.WriteLine("{0:F2}", summe);                                                     //} --^

            Console.WriteLine("Ende, drücken Sie Enter um das Programmm zu beenden");               //Kennzeichnet das Ende des Programmes und fordert den User auf Enter zu drücken
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe um das Programm entgültig zu schließen
        }
        public static void Aufgabe44()
        {
            int x;                                                                                  //Erstellt eine integer Variable mit einem nuller Wert

            do
            {
                Console.WriteLine("Geben Sie eine ganze Zahl ein");                                 //Fordert den User auf eine ganze Zahl (integer) einzugeben
                if (int.TryParse(Console.ReadLine(), out x) == true)                                //Erstellt eine if-Abfrage die überprüft ob die User-Eingabe in eine integer konvertiert werden kann
                {
                    Console.WriteLine("Die Zahl {0} ist durch folgende Zahlen teilbar:\n", x);      //Gibt die aktuelle zahl und dessen teiler aus
                    for (int i = x; i >= 1; i--)                                                    //Erstellt eine for-Schleife die solange ausgeführt wird solange i GRÖSSER oder GLEICH  1 ist
                    {
                        int a = x % i;                                                              //Erstellt eine integer Variable mit dem Wert x % i, also den Rest der Division von x/i
                        if (a == 0)                                                                 //Erstellt eine if-Abfrage mit der Bedingung, a GLEICH null
                        {
                            Console.Write("{0}, ", i);                                              //Gibt i aus
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Keine Zahl\n");                                              //Sollte die oben genannte Bedingung false sein, wird eine Fehlermeldung ausgeschrieben
                }
            } while (x < 1);                                                                        //Die do-while Schleife wird solange ausgeführt solange x KLEINER  als 1 ist

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                //Kennzeichnet das Ende des Programmes und fordert den User auf Enter zu drücken
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe um das Programm entgültig zu schließen
        }
        public static void Aufgabe45()
        {
            int n = 0;                                                                              //Erstellt eine integer Variable mit einem Wert von 0
            int Anzahl = 5;                                                                         //Erstellt eine integer Variable mit einem Wert von 5
            int[] Zahlen = new int[Anzahl];                                                         //Erstellt eine Array mit 5 indexplätzen

            Console.WriteLine("Geben Sie 5 ganze Zahlen ein\n");                                    //Der User wird aufgefordert fünf ganze Zahlen einzugeben
            do
            {
                if (int.TryParse(Console.ReadLine(), out int x) == true)                            //Erstellt eine if-Abfrage die überprüft ob die User-Eingabe in eine integer konventiert werden kann
                {
                    if (x > 0)                                                                      //Erstellt eine interne if-Abfrgage die überprüft ob x GRÖSSER als 0 Ist
                    { Zahlen[n] = x; }                                                              //Wenn ja Wird Zahlen[n] zu x
                    else { Zahlen[n] = 100; }                                                       //Falls die Bedingung false ist wird Zahlen[n] zu 100

                    Console.WriteLine("Die {0}.Zahl ist: {1}", n + 1, Zahlen[n]);                   //gibt den Wert n+1 und Zahlen[n] aus
                    n++;                                                                            //nach jedem Durchlauf wird n++, also n+1 gezählt
                }
                else                                                                                //Falls die Bedingungfalse ist
                {
                    Console.WriteLine("Keine Zahl");                                                //wird eine Fehlermeldung ausgeschrieben
                }
            } while (n < Anzahl);                                                                   //die do-while Schleife wird solange ausgeführt solange n KLEINER als Azahl ist
            Console.WriteLine("\n");                                                                //Fügt eine leere Zeile hinzu um den Abstand zwischen den Zeilen zu erhöhen

            for (int i = 0; i <= Anzahl - 1; i++)                                                   //Erstellt eine for-Schleife die solange ausgeführt wird solange i KLEINER oder GLEICH Anzahl ist
            {
                Console.WriteLine("n[{0}] = {1}", i, Zahlen[i]);                                    //Gibt i und Zahlen[i] aus
            }

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                //Kennzeichnet das Programmende und fordert den User auf Enter zu drücken um das programm entgültig zu schließen
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe die das Programm beendet
        }
        public static void Aufgabe46()
        {
            int n = 0;                                                                              //Erstellt eine integer Variable mit einem Wert von 0
            int Anzahl = 5;                                                                         //Erstllt eine Variable mit einem Wert von 5
            int[] Zahlen = new int[Anzahl];                                                         //Erstellt eine integer Array mit einem Indexwert von 5

            Console.WriteLine("Geben Sie 5 ganze Zahlen ein\n");                                    //Fordert den Nutzer auf 5 ganze Zahlen einzugeben
            do
            {
                if (int.TryParse(Console.ReadLine(), out int x) == true)                            //Erstellt eine if-Abfrage die überprüft ob die User-Eingabe in eine int konvertiert werden kann
                {
                    Zahlen[n] = x;                                                                  //ist die Bedingung true dann wird Zahlen[n] x zugewiesen
                    Console.WriteLine("Die {0}.Zahl ist: {1}", n + 1, Zahlen[n]);                   //Gibt die zahlen nach der Reihe aus
                    n++;                                                                            //nach jedem Durchgang wird n um 1 erhöht
                }
                else                                                                                //Sollte die Bedingung false sein
                {
                    Console.WriteLine("Keine Zahl");                                                //wird eine Fehlermeldung ausgegeben
                }
            } while (n < Anzahl);                                                                   //Die do-while Schleife wird solange ausgeführt solange n KLEINER als Anzahl ist

            Console.WriteLine("Alle Zahlen kleiner als 5:\n");


            for (int i = 0; i <= Anzahl - 1; i++)                                                   //Erstellt eine for-Schleife mit einer Bedingung, n ist KLEINER oder GLEICH
            {
                if (Zahlen[i] < 5)                                                                  //Erstellt eine if-Abfrage die überprüft ob Zahlen[i] KLEINER als 5 ist
                {
                    Console.WriteLine("A[{0}] = {1}", i, Zahlen[i]);                                //wenn die Bedingung true ist werden alle Zahlen die kleiner als 5 sind ausgeschrieben
                }
            }
            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                //Kennzeichnet das Ende des Programmes und fordert den User auf Enter zu drücken
            Console.ReadLine();                                                                     //Wartet aud eine User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe47()
        {
            int Anzahl = 5;                                                                         //Erstellt eine int Variable mit einem Wert von 5
            int[] array = new int[Anzahl];                                                          //Erstellt eine Array mit 5 Indexplätzen

            for (int i = 0; i < 5; i++)                                                             //Erstellt eine for-Schleife mit einer Bedingung, i ist KLEIENER als 5
            {
                Console.WriteLine("Geben Sie {0}. Zahl ein:", i + 1);                               //Gibt die aktuelle Zahl aus z.B. 1.Zahl, 2.Zahl, etc.
                array[i] = Convert.ToInt32(Console.ReadLine());                                     //Erstellt eine Array mit User-Eingabe
            }

            int a;                                                                                  //Erstellt eine Variable zur Hilfe des Tasuchvorgangs

            // Tauschvorgänge
            a = array[0];                                                                           //array[0] wird a zugewiesen
            array[0] = array[4];                                                                    //array[4] wird array[0] zugewiesen
            array[4] = a;                                                                           //a wird array[4] zugewiesen

            a = array[1];                                                                           // array[1] wird a zugewiesen
            array[1] = array[3];                                                                    // array[1] wird array[3] zugewiesen
            array[3] = a;                                                                           //a wird array[3] zugewiesen

            for (int i = 0; i < Anzahl; i++)                                                        //Erstellt eine for-Schlefie die solange ausgeführt wird solange i KLEINER als Anzahl ist
            {
                Console.WriteLine("array_n[{0}] = {1}", i, array[i]);                               //Gibt den aktuellen array index und den passenden Wert dazu aus
            }

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");                 //Kennzeichnet das Ende des Progeamm und fordert den user auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                     //Wartet auf die Eingabe des Users die das Programm beenden soll
        }
        public static void Aufgabe48()
        {
            int[] Zahlen = new int[5];                                                              //Erstellt eine Array mit einem Indexwert von 5

            for (int i = 0; i <= 4; i++)                                                            //Erstellt eine for-Schleife die solange ausgeführt wird solange i KLEINER oder GLEICH  4 ist
            {
                if (int.TryParse(Console.ReadLine(), out Zahlen[i]))                                //Erstellt eine if-Abfrage die versucht den User-Input in einen int Datentyp zu konvertieren
                {
                    Console.WriteLine("{0} = Zahlen[{1}] ", Zahlen[i], i);                          //Gibt die aktuelle Zahl z.B. 1,2, etc. und Zahlen[i] z.B. 24 aus
                }
            }

            int Wert = 50000;                                                                       //Erstellt eine integer Variable mit einem Wert von 50000
            int Position = 0;                                                                       //Erstellt eine int Variable mit einem Wert von 0

            for (int a = 0; a <= 4; a++)                                                            //Erstellt eine for-Schleife die solange ausgeführt wird solange a KLEINER oder GLEICH  4 ist
            {
                Console.WriteLine(Zahlen[a]);                                                       //Gibt zahlen[a] aus
                if (Zahlen[a] < Wert)                                                               //Erstellt eine if-Abfrage
                {
                    Wert = Zahlen[a];                                                               //Falls die Bedingung (Zahlen[a] KLEINER als Wert) ist wird Zahlen[a] zu Wert
                    Position = a;                                                                   //und a wird zu Position
                }
            }
            Console.WriteLine("\nDer kleinste Wert ist {0} auf Position {1}", Wert, Position);      //Gibt den kleinsten Indexwert aus und die jewilige Position

            Console.WriteLine("Ende, drücke Sie Enter um das Programm zu beenden");                 //Kennzeichnet das Ende des Programmes und fordert den User auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                     //Wartet auf eine User-Eingabe die das Programm schließen soll
        }
        public static void Aufgabe49()
        {// Ein Programm das aus den Anfangsbetrag, den Zinssatz und der Laufzeit, die Gesamtzinsen berechnet.

            double principle = 0;                     //Anfangsbetrag                               //}
            double rate_of_interest = 0;              //Zinsbetrag in %                             //} --> Erstellt eine double Variable mit dem Wert 0
            double time = 0;                          //Laufzeit in Jahre                           //}

            Console.WriteLine("Geben Sie 3 Zahlen ein");                                            //Fordert den Nutzer auf 3 Zahlen einzugeben
            for (int i = 0; i <= 3; i++)                                                            //Erstellt eine for-Schleife die solange ausgeführt wird solange i KLEINER oder GLEICH 3 ist
            {
                if (double.TryParse(Console.ReadLine(), out principle) == true)                     //Erstellt eine if-Abfrage die eine User-Eingabe zur Eingabe des Anfangsbetrags beinhaltet
                {
                    Console.WriteLine("Principle = {0}", principle);                                //Gibt den Anfangsbetrag an, wenn die Bedingung true ist
                    i++;

                    if (double.TryParse(Console.ReadLine(), out rate_of_interest) == true)          //Erstellt eine if-Abfrage die eine User-Eingabe zur Eingabe des Zinsbetrags beinhaltet
                    {
                        Console.WriteLine("Rate of interest = {0}", rate_of_interest);              //Gibt den Zinsbetrag in Prozent aus
                        i++;

                        if (double.TryParse(Console.ReadLine(), out time) == true)                  //Erstellt eine if-Abfrage die eine User-Eingabe zur Eingabe der Laufzeit beinhaltet
                        {
                            Console.WriteLine("Time = {0}", time);                                  //Gibt die Zeit aus
                            i++;                                                                    //Zählt bei jedem Durchgang +1
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No valid numbers given");                                  //Sollte die Bedingung false sein wird eine Fehlermeldung ausgegeben
                }
            }
            Console.WriteLine("Total interest = {0:F2}", principle * Math.Pow((1 + rate_of_interest / 100), time));         //Die Ausgabe beinhaltet summe der angegebenen Rechnung

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");              //Kennzeichnet das Ende des Programmes und fordert den User auf Enter zu drücken
            Console.ReadLine();                                                                   //Wartet auf die User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe50()
        {
            Console.WriteLine("Geben Sie einen Wert ein, in cm, um es in inch (zoll) um zu wandeln\n");                     //Fordert den User auf einen Wert einzugeben der anschließend in inch umgewandelt werden soll
            do
            {
                if (double.TryParse(Console.ReadLine(), out double x) == true)                    //Erstellt eine if-Abfrage die eine User-Eingabe zur Eingabe der cm beinhaltet
                {
                    Console.WriteLine("{0} cm = {1:F2} inch", x, x / 2.54);                       //gibt den eingegebenen Wert und den umgewandelten Wert aus
                    break;                                                                        //Springt sofort aus der Abfrage und der Schleife nachdem oberem Beispiel
                }
                else
                {
                    Console.WriteLine("Keine gürtlige Eingabe");                                  //Sollte die Bedingung false sein wird die Fehlermeldung ausgegeben
                }
            } while (true);                                                                       //Die do-while Schleife wird solange ausgeführt solange true ist

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");               //Kenzeichnet das Ende des Programmes und fordert den User auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                   //Wartet auf die User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe51()
        {
            int[] Zahl = new int[2];                                                              //Erstellt eine int Array mit 2 Indexwerten
            int n = 0;                                                                            //Erstellt eine Hilftvariable zum zählen

            Console.WriteLine("Geben Sie 2 Zahlen, a und b ein");                                 //Das Programm fordert den User auf zwei Zahlen einzugeben

            do
            {
                if (int.TryParse(Console.ReadLine(), out int x) == true)                          //Erstellt eine if-Abfrage die eine User-Eingabe zum eingeben der benötigten Daten beinhaltet
                {
                    Zahl[n] = x;                                                                  //Zahl[5] wird der variable x zugewiesen
                    Console.WriteLine("{1}.Zahl = {0}", Zahl[n], n + 1);                          //Gibt den Wert der jewiligen Zahl aus z.B. 1.Zahl = 30, 2.Zahl = etc.
                    n++;                                                                          //Nach jedem Durchgang wird bei n 1 dazu gerechnet
                }
                else
                {
                    Console.WriteLine("Nix");                                                     //Falls die oben genannte Bedingung false ist gibt das Programm eine Fehlernachricht aus
                }
            } while (n < 2);                                                                      //Die do-while Schleife wird solange ausgeführt solange n KLEINER als 2 ist
            Console.WriteLine("\nDie Zahlen lauten {0} und {1}\n", Zahl[0], Zahl[1]);             //Gibt die zwei Zahlen nochmals aus
            Console.WriteLine("Zahlen werden vertauscht:\n");
            (Zahl[0], Zahl[1]) = (Zahl[1], Zahl[0]);                                              //Tauschvorgang
            Console.WriteLine("\nDie Zahlen lauten {0} und {1}\n", Zahl[0], Zahl[1]);             //Gibt die vertauschten Zahlen nochmals an


            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");              //Kenzeichnet das Ende des Programmes und fordert den User auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                   //Wartet auf die User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe52()
        {
            int a = 2;                                                                            //Erstellt eine int Variable mit einem Wert von 2
            Console.WriteLine(" Zahl {0} nach Links:\n", a);                                      //Gibt die Zahl aus die nach links verschoben werden soll

            for (int i = 0; i <= 5; i++)                                                          //Erstellt eine for-Schleife die solange ausgeführt wird solange i KLEINER oder GLEICH 5 ist
            {
                Console.WriteLine(" Zahl {0} um {1} nach Links = {2}", a, i, a << i);             //Gibt die verschobenen Zahlen an. Die Zahlen wurde mit Hilfe des << um 2 bits nach links verschoben
            }
            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");              //Kenzeichnet das Ende des Programmes und fordert den User auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                   //Wartet auf die User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe53()
        {// Das Programm soll eine eingegebene Zahl umdrehen z.B. 123 --> 321

            int Zahl = Convert.ToInt32(Console.ReadLine());                                       //Erstellt eine int Variable mit User-Eingabe
            int y = 0;                                                                            //Erstellt eine int Variable mit einem nuller Wert

            while (Zahl > 0)                                                                      //Die whie-do Schleife wird solange ausgeführt solange Zahl KLEINER ist als 0
            {
                y = y * 10 + Zahl % 10;                                                           //Tauschvorgang
                Zahl /= 10;                                                                       //Zahl = Zahl/10
            }
            Console.WriteLine(y);                                                                 //Gibt den Wert von y aus

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");              //Kenzeichnet das Ende des Programmes und fordert den User auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                   //Wartet auf die User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe54()
        {
            double[] number = new double[4];                                                      //Erstellt eine double Array mit 4 Indexplätzen

            Console.WriteLine("Geben Sie 4 Zahlen ein:\n");                                       //Fordert den Nutzer auf vier Zahlen einzugeben
            for (double i = 0; i <= 3; i++)                                                       //Erstellt eine for-Schleife die solange ausgeführt wird solange i KLEINER oder GLEICH 3 ist
            {
                if (double.TryParse(Console.ReadLine(), out number[(int)i]) == true)              //Die if-Abfrage beinghaltet eine User-Eingabe durch diese die benötigten Informationen eingegeben werden können
                {
                    Console.WriteLine("Eingegebene Zahl: {0}", number[(int)i]);                   //Sollte die oben genannte Bedingung true sein wird die eingegebenen Zahl ausgegeben
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl eingegeben");                           //sollte die oben genannte Bedingung false sein wird eine Fehlermeldung ausgegeben
                }
            }

            Console.WriteLine("Die Differenz zwischen größter und kleinster Zahl ist: {0}", number.Max() - number.Min());         //Gibt die Differenz zwischen der größten und kleinsten Zahl aus

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");              //Kenzeichnet das Ende des Programmes und fordert den User auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                   //Wartet auf die User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe55()
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };                     //Erstellt ein Array mit den sieben Wochentagen

            for (int i = 0; i < 7; i++)                                                                                           //Erstellt eine for-Schleife die solange ausgeführt wird solange i KLEINER ist als 7
            {
                Console.WriteLine("{0} = {1}", days[i], i);                                                                       //Gibt einen Wochentag aus und eine dazugehöroge Nummer z.b. Tuesday und 3
            }

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");              //Kenzeichnet das Ende des Programmes und fordert den User auf die Enter-Taste zu drücken
            Console.ReadLine();                                                                   //Wartet auf die User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe56()
        {
            if (double.TryParse(Console.ReadLine(), out double x) == true)                        //Erstellt eine if-Abfrage die eine User-Eingabe beinhaltet durch die man die benötigten Daten eingeben kann
            {
                Console.WriteLine("Value of sin(1/x) is {0:F4}", Math.Sin(1 / x));                //Gibt den Sinuswert mit vier Nachkommerstellen, 1 durch x an 
            }

            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");              //Kennzeichnet das Ende des Programmes und fordert den User auf die Enter-Taste zudrücken
            Console.ReadKey();                                                                    //Wartet auf die User-Eingabe die das Programm beenden soll
        }
        public static void Aufgabe57()
        {//Der User gibt eine Zahl ein und das Programm zählt alle ganzen zahlen aus %10 zusammen
            int x, sum = 0, m;

            Console.WriteLine("Gib eine Nummer unter 500 ein");                                   //Fordert den User auf eine Zahl unter 500 einzugeben
            x = int.Parse(Console.ReadLine());                                                    //Die User-Eingabe wird der integer Variable x zugewiesen
            while (x > 0 && x <= 500)                                                             //Die while-Schleife wird solange ausgeführt solange x > 0 und >= 500
            {
                m = x % 10;                                                                       //Der Rest der Divison von x/10 wird m zugewiesen
                sum += m;                                                                         //Der Wert der summe (sum) setzt sich aus der Addition, sum + m, zusammen
                x /= 10;                                                                          //x wird durch 10 geteilt
            }
            Console.WriteLine("Sum is = {0}", +sum);                                              //Ausgabe der summe
            Console.WriteLine("Ende, drücken Sie Enter um das Programm zu beenden");
            Console.ReadLine();
        }
        public static void Aufgabe58()
        {//Das Programm zählt die Reihe 1^4 + 2^4 + 4^4 + 7^4 + 11^4 + ... + Eingabe^4 zusammen
            int n = 1;                                                                            //Erstellt eine integer Variable mit dem Wert 1
            int k = 0;                                                                            //Erstellt eine integer Variable mit nuller Wert
            Console.WriteLine("Geben Sie eine ganze Zahl zwischen 1 und 100 ein");                //Eingabe Auffoderung, Zahl 1 bis 100
            int m = Convert.ToInt32(Console.ReadLine());                                          //konvertiert Eingabe in integer
            double sum = 0;                                                                       //Erstellt eine double Variable mit dem Wert 0

            //Berechnet und gibt die summe aller zahlen^4 bis Eingabe aus
            do
            {
                n += k;                                                                            //n wird um k erhöht
                if (n > m - 1) { break; }                                                          //Wird die Eingabe erreicht wird die Schleife verlassen
                k++;                                                                               //erhöht k nach jedem durchlauf um 1
                sum += Math.Pow(n, 4);                                                             //erhöht die summe um n^4
                Console.WriteLine("{0} hoch 4 = {1}", n, Math.Pow(n, 4));                          //Gibt n und n^4 aus
            } while (true);                                                                        //Bleibt solange in der Schleife bis break
            Console.WriteLine("\nSumme aller Zahlen = {0}" ,sum);                                  //gibt summe aller zahlen^4 aus

            Console.WriteLine("Programm Ende");
            Console.ReadLine();
        }
        public static void Aufgabe59()
        {// Zahlen Eingabe und anschließend Audgabe von Max, Min und Average (Durchschnitt)

            int[] arr = new int[1];  // Index mindestens eins
            int index = 0;           // Indexzähler
            int sum = 0;             // Summe aller akzeptierten Eingaben

            Console.Write("\n Eingabe von GanzZahlen - Beenden mit 0 oder negativer Zahl:\n");
            //Berechnet und zählt alle zahlen bis null oder negativ und erhöht den Arrayindex
            do
            {
                Console.Write("\n Geben Sie die {0}. Zahl ein: ", index + 1);                   //Gibt die aktuell gezählte Zahl aus
                if (int.TryParse(Console.ReadLine(), out arr[index]) == true)                   //Eingabe Aufforderung und überprüfen der Umwandlung nach int
                {
                    if (arr[index] <= 0)                                                        //Wenn Wert in arrayindex <= 0
                    {                                                                           //dann:
                        if (index > 0) { Array.Resize(ref arr, index); }                        //Index um den Letzten Eintrag verringern
                        break;                                                                  //und Schleife verlassen
                    }
                    sum += arr[index];                                                          //sum wird um arr[index] erhöht
                    index++;                                                                    //index wird um 1 erhöht bei jedem Durchgang
                    Array.Resize(ref arr, index + 1);                                           // Index für den nächsten Eintrag erhöhen
                }
                else
                {
                    Console.Write("\n  - Keine gültige Eingabe -\n");                            //Bedingung false, dann Fehlermeldung
                }
            } while (true);                                                                      //Wird fortgeführt bis break

            Console.WriteLine("\n Sie haben {0} Zahlen Eingegeben\n", index);                    //Gibt Anzahl der eingegebenen Zahlen aus

            if (index > 0)                                                                       //Wenn zahlen eingegeben wurden
            {
                Console.WriteLine(" Die Zahlen sind:\n");
                foreach (int i in arr)
                {
                    Console.WriteLine("  {0}", i);                                               //Gibt eingegebene Zahlen aus
                }

                Console.WriteLine("\n Die kleinste Zahl = {0}\n Die größte Zahl = {1}", arr.Min(), arr.Max());          //Gibt die größte und kleinste Zahl aus

                Console.WriteLine("\n Die Summe der Zahlen = {0}", sum);                                                //Gibt die Summe aller Zahlen aus

                Console.WriteLine("\n Der Durschnitt der Zahlen = {0}", sum / index);                                   //Gibt den Durchschnitt aller Zahlen aus
            }

            Console.WriteLine("\n Programm beendet.\n");
            Console.ReadLine();
        }

        public static void Aufgabe60()
        {
            //Gibt alle Primzahlen von einer Startzahl bis zur Endzahl aus
            Console.Write("Geben Sie die Startzahl ein: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Geben Sie die Endzahl ein: ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Die Primzahlen zwischen {startNumber} und {endNumber} sind: ");

            int n = 1;
            //Berechnung der Zahlen auf Primzahlen
            for (int i = startNumber; i <= endNumber; i++)                          //Geht alle Zahlen von Start bin Ende durch
            {
                int counter = 0;                                                    //Deklariere zähler

                for (int j = 2; j <= i / 2; j++)                                    //Überprüfe auf Rest bis zahl / 2
                {
                    if (i % j == 0)                                                 //wenn rest null dann keine Primzahl
                    {
                        counter++;                                                  //und zähler +1
                        break;                                                      //Schleife wird verlassen
                    }
                }

                if (counter == 0 && i != 1)                                         //Wenn counter 0 und i nicht 1 (Wenn Primzahl vorhanden)
                {
                    if (n < 20)
                    {
                        Console.Write("{0} ", i);                                   //Schreibt Primzahl in eine Reihe
                        n++;
                    }
                    else
                    {
                        Console.WriteLine("{0}", i);                                //schreibt Primzahl dann nächste Zeile
                        n = 1;                                                      //und wiederholt sich
                    }

                }
            }
            Console.WriteLine("ENDE");
            Console.ReadLine();
        }
        public static void Aufgabe61()
        {// Erstellt zufalls Zahlen zwischen -0.5 und 0.5

            var rand = new Random();                                                //Erstellt Objekt für Zufallszahlen
            Console.WriteLine("Geben Sie eine Zahl ein");                           //Eingabe Aufforderung
            if (!int.TryParse(Console.ReadLine(), out int Anzahl) == true)          //Wenn keine konvertierung nach int möglich
            {
                Anzahl = 1;
                Console.WriteLine("Ungütltige Eingabe, Anzahl auf 1 gesetzt.");      //Fehlermeldung und Anzahl auf 1 gesetzt
            }
            double[] Zahlen = new double[Anzahl];                                    //Erstellung Array mit Index Anzahl
            for (int i = 0; i < Anzahl; i++)
            {
                Zahlen[i] = rand.Next(-5, 5);                                        //Schreibt ganze Zahlen zwischen -5 und 5
                Zahlen[i] /= 10;                                                     // durch 10 damit nachkommerstellen
                Console.Write("{0:F3}, ", Zahlen[i]);                                //Schreibt Zufallszahlen auf 3 Nachkommerstellen genau
            }

            using (StreamWriter sr = new StreamWriter(@"G:\\Visual Studios\\64_Aufgaben\\Zufalls-Zahlen.txt"))          //Vorbereitung für externe Datei
            {
                foreach (double x in Zahlen)                                         //Ließt Arrayinhalte nach x aus
                {
                    string a = Convert.ToString(x);                                 //konvertiert x nach string a
                    sr.WriteLine(a);                                                //Schreibt string a in Datei
                }
            }
            Console.WriteLine("ENDE");
            Console.ReadKey();
        }
        public static void Aufgabe62()
        {// Zwei Zahlenreihen, 0-10 und 1 bis n, wobei sich n ständig verdoppelt, sowie 1/n.
            float n = 0.5F;

            for (int i = 0; i <= 10; i++)                                           //Lässt die for-Schleife solange laufen solange i kleiner oder 10 ist
            {
                n *= 2;                                                             //n wird um 2 erhöht
                Console.WriteLine("{0}, {1}, {2:F12}", i, n, 1 / n);
            }
            Console.ReadLine();                                                     //Wartet auf User-Eingabe
        }
        public static void Aufgabe63()
        {
            for (int i = 65; i <= 122; i++)                                          //Lässt die for-Schleife solange laufe solange i kleiner oder 122 ist
            {
                if(i < 90 || i > 96)                                                 //Überprüft ob i kleiner 90 oder größer als 96 ist
                {
                    Console.Write("[" + (char)i + "-{0}], ", i);                     //konvertiert i in char und schreibt i aus
                }
            }

            Console.ReadLine();
        }
        public static void Aufgabe64()
        {
            Console.WriteLine("Geben Sie eine nagative Zahl ein");
            if (int.TryParse(Console.ReadLine(), out int x) == true)               //konvertiert User-Eingabe in int und schreibt in x aus
            {
                if (x < 0)                                                          //Überprüft ob x kleiner als 0 ist
                {
                    Console.WriteLine(x * (-1));                                    //Anschließend wird x + -1 gerechnet um sie umzuwandeln
                }
                else
                {
                    Console.WriteLine("Die Zahl hat kein Vorzeichen");               //Bedingung false, dann Fehlermeldung
                }
            }
            Console.ReadLine();
        }
    }
}
