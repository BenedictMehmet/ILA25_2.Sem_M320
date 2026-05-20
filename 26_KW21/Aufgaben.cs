using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA25_2.Sem_M320._26_KW21
{
    internal class Aufgaben
    {
        // =========================================================
        // AUFGABE 1 – Einfacher Konstruktor
        // =========================================================

        /*
        Aufgabe:
        Erstelle eine Klasse Auto.

        Anforderungen:
        - Eigenschaften:
            - Marke
            - Baujahr
        - Konstruktor:
            - Übergibt Marke und Baujahr
        - Methode:
            - Info() gibt alle Daten aus

        Beispiel:
            Auto auto1 = new Auto("BMW", 2022);
            auto1.Info();
        */



        // =========================================================
        // AUFGABE 2 – Standardkonstruktor
        // =========================================================

        /*
        Aufgabe:
        Erstelle eine Klasse Person.

        Anforderungen:
        - Eigenschaften:
            - Name
            - Alter
        - Ein parameterloser Konstruktor setzt:
            - Name = "Unbekannt"
            - Alter = 0
        - Methode:
            - Vorstellen()

        Beispiel:
            Person p = new Person();
            p.Vorstellen();
        */



        // =========================================================
        // AUFGABE 3 – Überladene Konstruktoren
        // =========================================================

        /*
        Aufgabe:
        Erstelle eine Klasse Rechteck.

        Anforderungen:
        - Eigenschaften:
            - Breite
            - Hoehe
        - Konstruktor 1:
            - setzt beide Werte
        - Konstruktor 2:
            - setzt nur die Breite
            - Höhe soll automatisch denselben Wert erhalten
        - Methode:
            - FlaecheBerechnen()

        Beispiel:
            Rechteck r1 = new Rechteck(5, 10);
            Rechteck r2 = new Rechteck(7);
        */



        // =========================================================
        // AUFGABE 4 – Konstruktorverkettung
        // =========================================================

        /*
        Aufgabe:
        Erstelle eine Klasse Student.

        Anforderungen:
        - Eigenschaften:
            - Name
            - Klasse
            - Notendurchschnitt
        - Nutze Konstruktorverkettung mit : this(...)
        - Ein Konstruktor soll Standardwerte setzen

        Beispiel:
            Student s1 = new Student("Ali");
            Student s2 = new Student("Lena", "INF202");
        */



        // =========================================================
        // AUFGABE 5 – Konstruktor mit Validierung
        // =========================================================

        /*
        Aufgabe:
        Erstelle eine Klasse Bankkonto.

        Anforderungen:
        - Eigenschaften:
            - Kontoinhaber
            - Kontostand
        - Konstruktor prüft:
            - Kontostand darf nicht negativ sein
        - Falls negativ:
            - Kontostand = 0
            - Fehlermeldung ausgeben

        Beispiel:
            Bankkonto konto = new Bankkonto("Mehmet", -500);
        */



        // =========================================================
        // AUFGABE 6 – Private Konstruktoren (Singleton)
        // =========================================================

        /*
        Aufgabe:
        Erstelle eine Klasse Datenbank.

        Anforderungen:
        - Konstruktor soll private sein
        - Verwende das Singleton-Prinzip
        - Methode:
            - GetInstance()
        - Es darf nur ein Objekt erstellt werden

        Beispiel:
            Datenbank db = Datenbank.GetInstance();
        */



        // =========================================================
        // AUFGABE 7 – Konstruktor mit Objektbeziehungen
        // =========================================================

        /*
        Aufgabe:
        Erstelle zwei Klassen:
            - Motor
            - Auto

        Anforderungen:
        - Motor besitzt:
            - PS
        - Auto besitzt:
            - Marke
            - Motor
        - Der Motor wird im Konstruktor an das Auto übergeben
        - Methode:
            - AutoInfo()

        Beispiel:
            Motor motor = new Motor(250);
            Auto auto = new Auto("Audi", motor);
        */

    }
}
