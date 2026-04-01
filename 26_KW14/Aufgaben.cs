using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA25_2.Sem_M320._26_KW14
{
    internal class Aufgaben
    {
        class QuizAufgaben
        {
            /*
            Aufgabe 1 – Einfache Quizfrage

            Erstelle ein Konsolenprogramm, das dem Benutzer eine einfache Frage stellt.
            Beispiel: "Was ist die Hauptstadt von Frankreich?"

            Anforderungen:
            - Lies die Antwort des Benutzers mit Console.ReadLine().
            - Vergleiche die Antwort mit der korrekten Lösung ("Paris").
            - Wenn die Antwort korrekt ist, erhält der Benutzer 1 Punkt.
            - Gib eine entsprechende Meldung aus:
                - "Richtig! Du erhältst 1 Punkt."
                - oder "Falsch. Die richtige Antwort wäre Paris gewesen."
            */

            /*
            Aufgabe 2 – Mehrere Fragen mit Punktestand

            Erstelle ein Konsolenprogramm mit mindestens 3 Fragen.
            Beispiele:
                - "Wie viele Kontinente gibt es auf der Erde?"
                - "Wie viele Tage hat ein Schaltjahr?"
                - "Welche Sprache läuft auf der .NET-Plattform?"

            Anforderungen:
            - Verwende eine Variable int punkte = 0;
            - Für jede richtige Antwort wird punkte um 1 erhöht.
            - Am Ende wird der gesamte Punktestand ausgegeben.
            */

            /*
            Aufgabe 3 – Quiz mit Prozentstatistik

            Erstelle ein Quiz mit 5 Fragen.

            Anforderungen:
            - Zähle die richtigen Antworten.
            - Berechne am Ende den Prozentsatz der richtigen Antworten.

            Beispiel:
                Prozent = (richtigeAntworten / gesamtFragen) * 100

            Ausgabe:
                "Du hast 4 von 5 Fragen richtig beantwortet."
                "Deine Erfolgsquote beträgt 80%."
            */

            /*
            Aufgabe 4 – Bewertung nach Punktzahl

            Erstelle ein Quiz mit mindestens 4 Fragen.

            Anforderungen:
            - Speichere die Punkte.
            - Gib am Ende eine Bewertung aus:

                0–1 Punkte → "Du solltest noch etwas üben."
                2–3 Punkte → "Ganz gut!"
                4 Punkte   → "Perfekt!"

            Ziel:
            - Verwende if / else oder switch.
            */

            /*
            Aufgabe 5 – Quiz mit Wiederholung (Schleife)

            Erstelle ein Programm, das mehrere Fragen stellt,
            bis alle Fragen beantwortet wurden.

            Anforderungen:
            - Speichere Fragen und Antworten in Arrays oder Listen.
            - Gehe mit einer Schleife durch alle Fragen.
            - Vergleiche jede Eingabe mit der richtigen Antwort.
            - Zähle die Punkte.

            Am Ende:
                - Zeige die Gesamtpunkte.
                - Zeige zusätzlich eine Statistik wie:
                  "Du hast 3 von 5 Fragen korrekt beantwortet."
            */

            class ArrayQuizAufgaben
            {
                /*
                Aufgabe 6 – Fragen aus einem Array anzeigen

                Erstelle ein Array mit mindestens 4 Quizfragen.

                Beispiel:
                string[] fragen = {
                    "Wie viele Tage hat eine Woche?",
                    "Wie viele Kontinente gibt es?",
                    "Welche Farbe hat der Himmel bei klarem Wetter?",
                    "Wie viele Stunden hat ein Tag?"
                };

                Anforderungen:
                - Gehe mit einer Schleife durch das Array.
                - Gib jede Frage auf der Konsole aus.
                - Der Benutzer soll eine Antwort eingeben.
                - Vergleiche die Antwort mit einer passenden Lösung.
                - Zähle die Punkte für richtige Antworten.
                */


                /*
                Aufgabe 7 – Fragen und Antworten in zwei Arrays

                Erstelle zwei Arrays:
                    - eines für Fragen
                    - eines für die passenden Antworten

                Beispiel:
                    string[] fragen = { ... }
                    string[] antworten = { ... }

                Anforderungen:
                - Beide Arrays müssen gleich viele Elemente haben.
                - Verwende eine Schleife mit Index (for).
                - Stelle die Frage fragen[i].
                - Vergleiche die Eingabe mit antworten[i].
                - Wenn die Antwort korrekt ist, erhält der Benutzer einen Punkt.
                - Am Ende wird die Gesamtpunktzahl ausgegeben.
                */


                /*
                Aufgabe 8 – Zufällige Frage aus einem Array

                Erstelle ein Array mit mindestens 5 Fragen.

                Anforderungen:
                - Verwende die Klasse Random.
                - Wähle eine zufällige Position aus dem Array.
                - Stelle nur diese eine Frage.
                - Der Benutzer gibt eine Antwort ein.
                - Prüfe, ob die Antwort korrekt ist.
                - Gib eine Meldung aus, ob sie richtig oder falsch war.
                */


                /*
                Aufgabe 9 – Statistik mit einem Punkte-Array

                Erstelle ein Array, das speichert, ob eine Frage
                richtig oder falsch beantwortet wurde.

                Beispiel:
                    bool[] ergebnisse = new bool[5];

                Anforderungen:
                - Stelle 5 Fragen.
                - Wenn eine Antwort korrekt ist, speichere true im Array.
                - Wenn sie falsch ist, speichere false.

                Am Ende:
                - Zähle alle true-Werte im Array.
                - Das ergibt die Anzahl der richtigen Antworten.
                - Gib eine Statistik aus.
                */


                /*
                Aufgabe 10 – Mehrere Spieler speichern

                Erstelle ein Programm, das die Punkte mehrerer Spieler speichert.

                Anforderungen:
                - Erstelle ein Array für Spielernamen.
                - Erstelle ein zweites Array für deren Punkte.

                Beispiel:
                    string[] spieler = new string[3];
                    int[] punkte = new int[3];

                Ablauf:
                - Frage jeden Spieler nach seinem Namen.
                - Jeder Spieler beantwortet eine Quizfrage.
                - Wenn die Antwort korrekt ist, bekommt er einen Punkt.

                Am Ende:
                - Gib eine Übersicht aus:

                    Spieler 1: Max – 1 Punkt
                    Spieler 2: Anna – 0 Punkte
                    Spieler 3: Leon – 1 Punkt
                */

                class ListQuizAufgaben
                {
                    /*
                    Aufgabe 11 – Antworten in einer Liste speichern

                    Erstelle ein Quiz mit 3 Fragen.

                    Anforderungen:
                    - Erstelle eine List<string>, um die Antworten des Benutzers zu speichern.
                    - Stelle nacheinander die Fragen.
                    - Speichere jede eingegebene Antwort in der Liste.
                    - Gib am Ende alle Antworten wieder aus.

                    Beispiel:
                    "Deine Antworten waren:"
                    Antwort 1: ...
                    Antwort 2: ...
                    Antwort 3: ...
                    */


                    /*
                    Aufgabe 12 – Punkte in einer Liste speichern

                    Erstelle ein Quiz mit 4 Fragen.

                    Anforderungen:
                    - Erstelle eine List<int> für die Punkte pro Frage.
                    - Wenn eine Antwort korrekt ist, füge 1 zur Liste hinzu.
                    - Wenn sie falsch ist, füge 0 hinzu.

                    Am Ende:
                    - Summiere alle Werte der Liste.
                    - Gib die Gesamtpunktzahl aus.
                    */


                    /*
                    Aufgabe 13 – Fragen dynamisch zu einer Liste hinzufügen

                    Erstelle eine List<string> für Quizfragen.

                    Anforderungen:
                    - Der Benutzer darf selbst Fragen eingeben.
                    - Die Fragen werden mit Add() zur Liste hinzugefügt.
                    - Beende die Eingabe, wenn der Benutzer "stop" schreibt.

                    Danach:
                    - Gehe mit einer Schleife durch die Liste.
                    - Gib alle eingegebenen Fragen aus.
                    */


                    /*
                    Aufgabe 14 – Richtige Antworten zählen

                    Erstelle eine List<bool>, um zu speichern,
                    ob eine Antwort richtig oder falsch war.

                    Ablauf:
                    - Stelle 5 Fragen.
                    - Wenn die Antwort richtig ist → Add(true)
                    - Wenn die Antwort falsch ist → Add(false)

                    Am Ende:
                    - Zähle alle true-Werte in der Liste.
                    - Gib aus:
                      "Du hast X von 5 Fragen richtig beantwortet."
                    */


                    /*
                    Aufgabe 15 – Bestenliste mit List

                    Erstelle zwei Listen:
                        List<string> namen
                        List<int> punkte

                    Anforderungen:
                    - Frage die Namen von 3 Spielern ab.
                    - Jeder Spieler beantwortet eine Frage.
                    - Wenn die Antwort korrekt ist, erhält er einen Punkt.
                    - Speichere Name und Punktzahl in den Listen.

                    Am Ende:
                    - Gib eine Rangliste aus:

                      Spieler: Max – 1 Punkt
                      Spieler: Anna – 0 Punkte
                      Spieler: Leon – 1 Punkt
                    */
                }
            }
        }
    }
}
