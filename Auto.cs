using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverleih
{
    public class Auto
    {
        public string Hersteller { get; set; }
        public string Typ { get; set; }
        public string Autonummer { get; set; }
        public double Preis { get; set; }
        public string Anzeige { get; set; }
        public Auto() { }
        public Auto(string hersteller, string typ, string autonummer, double preis)
        {
            Hersteller = hersteller;
            Typ = typ;
            Autonummer = autonummer;
            Preis = preis;
            Anzeige = hersteller + " " + typ + ", " + preis + " CHF";
        }
    }
}
