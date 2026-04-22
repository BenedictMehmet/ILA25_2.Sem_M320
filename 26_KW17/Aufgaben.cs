using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA25_2.Sem_M320._26_KW17
{
    internal class Aufgaben
    {

        /*
Aufgabe 1 – Einfache Ja/Nein-Frage

Erstelle ein Konsolenprogramm, das dem Benutzer eine Ja/Nein-Frage stellt.

Beispiel:
    "Ist C# eine Programmiersprache? (ja/nein)"

Anforderungen:
- Lies die Antwort mit Console.ReadLine().
- Vergleiche die Eingabe mit der richtigen Antwort.
- Wenn die Antwort korrekt ist, gib aus:
    "Richtig!"
- Wenn die Antwort falsch ist, gib aus:
    "Falsch."
- Achte darauf, dass Gross- und Kleinschreibung keine Rolle spielt.
*/


        /*
        Aufgabe 2 – Zwei Fragen hintereinander

        Erstelle ein kleines Quiz mit 2 Fragen.

        Beispiele:
            - "Wie viele Monate hat ein Jahr?"
            - "Welche Zahl kommt nach 9?"

        Anforderungen:
        - Verwende eine Variable int punkte = 0;
        - Stelle beide Fragen nacheinander.
        - Für jede richtige Antwort gibt es 1 Punkt.
        - Gib am Schluss aus:
            "Du hast X von 2 Punkten erreicht."
        */


        /*
        Aufgabe 3 – Antworten prüfen und richtige Lösung anzeigen

        Erstelle ein Quiz mit 3 einfachen Fragen.

        Anforderungen:
        - Stelle jede Frage einzeln.
        - Prüfe jede Antwort direkt nach der Eingabe.
        - Wenn die Antwort falsch ist, soll zusätzlich die richtige Lösung angezeigt werden.
        - Zähle die Punkte.
        - Gib am Ende die Gesamtpunktzahl aus.

        Beispiel:
            "Leider falsch. Die richtige Antwort ist: 12"
        */


        /*
        Aufgabe 4 – Quiz mit Kategorien

        Erstelle ein Quiz mit 4 Fragen aus verschiedenen Kategorien.

        Beispiel:
            - Mathematik
            - Geografie
            - Informatik
            - Allgemeinwissen

        Anforderungen:
        - Gib vor jeder Frage die Kategorie aus.
        - Zähle die Punkte des Benutzers.
        - Gib am Ende aus, wie viele Antworten richtig waren.
        - Gib zusätzlich aus, in welcher Kategorie eine Frage gestellt wurde.

        Beispiel:
            "Kategorie: Geografie"
            "Frage: Welches Land hat die Hauptstadt Bern?"
        */


        /*
        Aufgabe 5 – Fragen überspringen und später zählen

        Erstelle ein Quiz mit 5 Fragen.

        Anforderungen:
        - Der Benutzer darf eine Frage überspringen, indem er einfach Enter drückt.
        - Übersprungene Fragen gelten als nicht beantwortet.
        - Zähle:
            - richtige Antworten
            - falsche Antworten
            - übersprungene Fragen

        Am Ende:
        - Gib eine kleine Statistik aus.

        Beispiel:
            "Richtig: 3"
            "Falsch: 1"
            "Übersprungen: 1"
        */


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
    }
}
