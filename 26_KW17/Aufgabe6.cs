using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA25_2.Sem_M320._26_KW17
{
    /*
       Aufgabe 6 – Quiz mit 2 Teilaufgaben

       Erstelle ein Programm mit einer Hauptfrage und einer Zusatzfrage.

       Teil A:
       - Stelle eine normale Quizfrage.
       - Prüfe, ob die Antwort richtig ist.
       - Für die richtige Antwort gibt es 1 Punkt.

       Teil B:
       - Stelle danach eine zweite, etwas schwierigere Zusatzfrage.
       - Für diese richtige Antwort gibt es 2 Punkte.

       Anforderungen:
       - Verwende eine Variable für die Gesamtpunktzahl.
       - Gib am Ende aus, wie viele Punkte erreicht wurden.
       - Gib zusätzlich aus, ob der Benutzer die Zusatzfrage geschafft hat.

       Beispiel:
           "Du hast insgesamt 3 Punkte erreicht."
       */
    internal class Aufgabe6
    {
        static void Main(string[]args)
        {
            int punkte = 0;
            Console.WriteLine("Wie hoch ist der Eiffelturm?");
            string antwort1 = Console.ReadLine();

            bool zusatzFrageGeschafft = false;

            if (antwort1.ToLower() == "300")
            {
                punkte += 1;
                Console.WriteLine("Korrekt. Du hast einen Punkt erhalten");
            }
            else
            {
                Console.WriteLine("Falsch. Die richtige Antwort ist 300");
            }


            Console.WriteLine("Wie viele Gemeinden hat Kanton Luzern?");
            string antwort2 = Console.ReadLine();

            if (antwort2.ToLower() == "20")
            {
                Console.WriteLine("Korrekt. Du hast zwei Punkte erhalten");
                punkte += 2;
                zusatzFrageGeschafft = true;
            }
            else
            {
                Console.WriteLine("Falsch. Die richtige Antwort ist 20");
            }

            Console.WriteLine($"Du hast {punkte} Punkte erreicht");
            Console.WriteLine($"Du hast die Zusatzfrage korrekt beantwortet: {zusatzFrageGeschafft}");

        }


     
    }
}
