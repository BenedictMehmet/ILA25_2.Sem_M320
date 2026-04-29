using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA25_2.Sem_M320._26_KW17
{
    /*
       Aufgabe 7 – Quiz aus Listen mit Auswertung pro Frage

       Erstelle ein Quiz mit mindestens 5 Fragen.

       Anforderungen:
       - Speichere die Fragen in einer List<string>.
       - Speichere die richtigen Antworten in einer zweiten List<string>.
       - Verwende eine Schleife, um alle Fragen durchzugehen.
       - Speichere nach jeder Frage, ob die Antwort richtig oder falsch war.

       Am Ende:
       - Gib die Gesamtpunktzahl aus.
       - Gib zusätzlich für jede Frage einzeln aus, ob sie richtig oder falsch beantwortet wurde.

       Beispiel:
           "Frage 1: richtig"
           "Frage 2: falsch"
           "Frage 3: richtig"

       Zusatz:
       - Berechne am Schluss die Erfolgsquote in Prozent.
       */
    internal class Aufgabe7
    {
        static void Main(string[]args)
        {
            List<string> fragen = new List<string>();

            fragen.Add("Frage 1");
            fragen.Add("Frage 2");
            fragen.Add("Frage 3");
            fragen.Add("Frage 4");
            fragen.Add("Frage 5");

            List<string> antworten = new List<string>();

            antworten.Add("antwort1");
            antworten.Add("antwort2");
            antworten.Add("antwort3");
            antworten.Add("antwort4");
            antworten.Add("antwort5");

            int punkte = 0;

            List<bool> auswertung = new List<bool>();

            for(int i = 0; i < fragen.Count; i++)
            {
                Console.WriteLine($"Frage {i + 1}:" + fragen[i]);
                string eingabe = Console.ReadLine();

                if(eingabe.ToLower() == antworten[i])
                {
                    Console.WriteLine("Die Antwort ist richtig");
                    auswertung.Add(true);
                    punkte++;
                }
                else
                {
                    Console.WriteLine($"Falsche Antwort. Die richtige Antwort ist {antworten[i]}");
                    auswertung.Add(false);
                }
            }


            for(int i = 0; i < auswertung.Count; i++) // Schleife geht die Auswerung jeder Frage durch
            {
                if (auswertung[i] == true) 
                {
                    Console.WriteLine($"Frage {i + 1}: " + "richtig");
                }
                else
                {
                    Console.WriteLine($"Frage {i + 1}: " + "falsch");
                }
            }







        }
    }
}
