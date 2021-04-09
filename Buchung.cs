using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverleih
{
    public class Buchung
    {
        public string Hersteller { get; set; }
        public string Typ { get; set; }
        public string Autonummer { get; set; }
        public string Email { get; set; }
        public string Anzeige { get; set; }
        public DateTime Von { get; set; }
        public double Preis { get; set; }
        public Buchung() { }
        public Buchung(string hersteller, string typ, string autonummer, string email, string anzeigevon, DateTime von, double preis)
        {
            Hersteller = hersteller;
            Typ = typ;
            Autonummer = autonummer;
            Email = email;
            Von = von;
            Preis = preis;
            Anzeige = anzeigevon + "   " + email + ",    " +  hersteller + " " + typ + "    " + autonummer;
        }
    }
}
