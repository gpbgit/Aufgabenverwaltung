using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabenliste
{
    public class Aufgabe
    {
        public string Bezeichnung { get; set;  }
        public DateTime Abgabedatum { get; set; }
        public string Mitarbeiter { get; set; }
        public int Erledigungsgrad { get; set; }

        public Aufgabe(string bezeichnung, DateTime abgabedatum, string mitarbeiter, int erledigungsgrad)
        {
            Bezeichnung = bezeichnung;
            Abgabedatum = abgabedatum;
            Mitarbeiter = mitarbeiter;
            Erledigungsgrad = erledigungsgrad;
        }

        public override string ToString()
        {
            // TODO Abgabedatum und Mitarbeiter in die String-Darstellung hinzufügen
            // Formatierung des Datums: CultureInfo benutzen 
            return Bezeichnung + " (" + Erledigungsgrad + "%)";
        }
    }
}
