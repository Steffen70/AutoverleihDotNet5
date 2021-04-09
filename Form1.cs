using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Autoverleih
{
    public partial class Form1 : Form
    {
        #region Serializer
        public List<Person> persons = new List<Person>();
        public List<Auto> autos = new List<Auto>();
        public List<Buchung> buchungen = new List<Buchung>();
        public Data xmldata = new Data();
        #endregion

        public Form1()
        {
            InitializeComponent();

            tabPage1.Text = @"Verleih";
            tabPage2.Text = @"User";
            tabPage3.Text = @"Auto";
            tabPage4.Text = @"Abrechnen";

            UserAuswahl.DisplayMember = "Anzeige";
            AutoAuswahl.DisplayMember = "Anzeige";
            UserRemove.DisplayMember = "Anzeige";
            AutoRemove.DisplayMember = "Anzeige";
            Ausgeliehen.DisplayMember = "Anzeige";
        }

        private void BtnUserAdd_Click(object sender, EventArgs e)
        {
            Person p = new Person(TextName.Text, TextVorname.Text, TextEmail.Text);
            TextName.Clear();
            TextVorname.Clear();
            TextVorname.Clear();
            TextEmail.Clear();
            xmldata.persons.Add(p);
            personBindingSource.Add(p);
        }

        private void BtnAutoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Auto a = new Auto(TextHersteller.Text, TextTyp.Text, TextAutonummer.Text, Convert.ToDouble(TextPreis.Text));
                TextHersteller.Clear();
                TextTyp.Clear();
                TextAutonummer.Clear();
                TextPreis.Clear();
                xmldata.autos.Add(a);
                autoBindingSource.Add(a);
            }
            catch
            {
                MessageBox.Show("Bitte überprüfen Sie Ihre Eingaben", "Hinweis");
            }
        }

        private void BtnBuchen_Click(object sender, EventArgs e)
        {
            Person u = UserRemove.SelectedItem as Person;
            Auto a = AutoRemove.SelectedItem as Auto;
            Buchung b = new Buchung(a.Hersteller, a.Typ, a.Autonummer, u.Email, DateTime.Now.ToString("dd.MM.yyy"), DateTime.Today, a.Preis);
            xmldata.buchungen.Add(b);
            buchungBindingSource.Add(b);
            xmldata.autos.Remove(a);
            autoBindingSource.Remove(a);
        }

        private void BtnUserRemove_Click(object sender, EventArgs e)
        {
            Person u = UserRemove.SelectedItem as Person;
            int itemsfound = xmldata.buchungen.Count(item => item.Email == u.Email);
            if (itemsfound < 1)
            {
                personBindingSource.Remove(u);
                xmldata.persons.Remove(u);
            }
            else
            {
                MessageBox.Show("Der Benutzer ist im Besitz eines Autos", "Hinweis");
            }
        }

        private void BtnAutoRemove_Click(object sender, EventArgs e)
        {
            Auto a = AutoRemove.SelectedItem as Auto;
            autoBindingSource.Remove(a);
            xmldata.autos.Remove(a);    /*Serializer*/
        }

        private void btnAbrechnen_Click(object sender, EventArgs e)
        {
            Buchung b = Ausgeliehen.SelectedItem as Buchung;
            double Days = (b.Von - DateTime.Today).TotalDays;
            if (Days == 0) { Days++; }
            double Kosten = Days * b.Preis;
            DialogResult dialogResult = MessageBox.Show(Days + "Tag(e) kosten: " + Kosten, "Abrechnung", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Auto a = new Auto(b.Hersteller, b.Typ, b.Autonummer, b.Preis);
                xmldata.autos.Add(a);
                autoBindingSource.Add(a);
                xmldata.buchungen.Remove(b);
                buchungBindingSource.Remove(b);
            }
        }

        #region Serializer
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Data));
                using (TextWriter writer = new StreamWriter(@".\Data.xml"))
                {
                    serializer.Serialize(writer, xmldata);
                    writer.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("XML konnte nicht gespeichert werden.", "Hinweis");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Data));
                TextReader reader = new StreamReader(@".\Data.xml");
                object obj = deserializer.Deserialize(reader);
                xmldata = (Data)obj;
                reader.Close();

                foreach (Person u in xmldata.persons)
                {
                    personBindingSource.Add(u);
                }

                foreach (Auto a in xmldata.autos)
                {
                    autoBindingSource.Add(a);
                }

                foreach (Buchung b in xmldata.buchungen)
                {
                    buchungBindingSource.Add(b);
                }
            }
            catch (Exception)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Data));
                    using (TextWriter writer = new StreamWriter(@".\Data.xml"))
                    {
                        serializer.Serialize(writer, xmldata);
                        writer.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("XML konnte nicht geladen werden.", "Hinweis");
                }
            }
        }
        #endregion
    }
}
