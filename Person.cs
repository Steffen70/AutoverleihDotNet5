using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverleih
{
    public class Data
    {
        public List<Person> persons { get; set; }
        public List<Auto> autos { get; set;  }
        public List<Buchung> buchungen { get; set; }

        public Data()
        {
            persons = new List<Person>();
            autos = new List<Auto>();
            buchungen = new List<Buchung>();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Email { get; set; }
        public string Anzeige { get; set; }
        public Person() { }
        public Person(string name, string vorname, string email)
        {
            Name = name;
            Vorname = vorname;
            Email = email;
            Anzeige = name + " " + vorname + ", " + email;
        }
    }
}
