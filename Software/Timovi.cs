using Baza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogometni_planer
{
    public partial class Timovi : Form
    {
        private Termin termin;

        private List<Korisnik> neutralniIgraci = new List<Korisnik>();

        private List<Korisnik> timAIgraci = new List<Korisnik>();

        private List<Korisnik> timBIgraci = new List<Korisnik>();

        private bool kreatorGrupe;

        public Timovi(Termin termin, bool kreatorGrupe)
        {
            this.termin = termin;
            this.kreatorGrupe = kreatorGrupe;
            InitializeComponent();
        }

        private void Timovi_Load(object sender, EventArgs e)
        {
            var timAId = DohvatiTimA();
            var timBId = DohvatiTimB();

            if (timAId == null && timBId == null)
            {
                neutralniIgraci = DohvatiIgrace();
                OsvjeziPopisNeutralnihIgraca();
            }
            else
            {
                timAIgraci = DohvatiIgraceTima(timAId);
                timBIgraci = DohvatiIgraceTima(timBId);
                OsvjeziPopisIgracaTimaA();
                OsvjeziPopisIgracaTimaB();

                OnemoguciKontrole();
            }
            if (!kreatorGrupe)
            {
                OnemoguciKontrole();
            }
        }

        private void buttonNeutralniTimA_Click(object sender, EventArgs e)
        {
            if (neutralniIgraci.Count > 0)
            {
                PrebaciUTimA();
            } 
        }

        private void buttonTimANeutralni_Click(object sender, EventArgs e)
        {
            if (timAIgraci.Count > 0)
            {
                PrebaciUNeutralneIzTimaA();
            }
        }

        private void buttonNeutralniTimB_Click(object sender, EventArgs e)
        {
            if (neutralniIgraci.Count > 0)
            {
                PrebaciUTimB();
            }
        }

        private void buttonTimBNeutralni_Click(object sender, EventArgs e)
        {
            if (timBIgraci.Count > 0)
            {
                PrebaciUNeutralneIzTimaB();
            }
        }

        private void buttonKreiranjeTimova_Click(object sender, EventArgs e)
        {
            if (neutralniIgraci.Count == 0 && timAIgraci.Count != 0 && timBIgraci.Count != 0)
            {
                string upit = "SELECT * FROM timovi WHERE termin= '" + termin.Id + "'";
                SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
                bool postojeTimovi = dataReader.HasRows;
                dataReader.Close();
                if (!postojeTimovi)
                {
                    DodajTim("Tim A");
                    DodajTim("Tim B");
                }

                DodajKorisnikeUTimove();
                OnemoguciKontrole();

                MessageBox.Show("Timovi su uspješno kreirani");
            }
            else
            {
                MessageBox.Show("Krivo raspoređeni igrači. Potrebno je rasporediti sve moguće igrače. " +
                    "Niti jedan tim ne smije biti prazan. Ukoliko nema igrača na popisu potrebno ih je pozvati u termin.");
            }
        }

        private List<Korisnik> DohvatiIgrace()
        {
            List<Korisnik> igraci = new List<Korisnik>();

            string upit = "SELECT * FROM korisnik WHERE korisnik_id IN (SELECT korisnik FROM termini_korisnici WHERE termin= '" + termin.Id + "')";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (dataReader.Read())
            {
                Korisnik korisnik = new Korisnik();
                korisnik.Id = (int)dataReader["korisnik_id"];
                korisnik.Ime = dataReader["ime"].ToString();
                korisnik.Prezime = dataReader["prezime"].ToString();
                korisnik.KorisnickoIme = dataReader["korisnicko_ime"].ToString();
                korisnik.Lozinka = dataReader["lozinka"].ToString();
                korisnik.Email = dataReader["email"].ToString();

                igraci.Add(korisnik);
            }
            dataReader.Close();

            return igraci;
        }

        private void DodajTim(string naziv)
        {
            Tim tim = new Tim
            {
                Naziv = naziv,
                Termin = termin.Id
            };
            string upit = "INSERT INTO timovi VALUES('" + tim.Naziv + "', '" + tim.Termin + "');";
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        private void DodajKorisnikeUTimove()
        {
            var timAId = DohvatiTimA();
            foreach (var igrac in timAIgraci)
            {
                string upit = "INSERT INTO timovi_korisnici VALUES('" + timAId + "', '" + igrac.Id + "');";
                BazaPodataka.Instanca.IzvrsiUpit(upit);
            }

            var timBId = DohvatiTimB();
            foreach (var igrac in timBIgraci)
            {
                string upit = "INSERT INTO timovi_korisnici VALUES('" + timBId + "', '" + igrac.Id + "');";
                BazaPodataka.Instanca.IzvrsiUpit(upit);
            }
        }

        public int? DohvatiTimA()
        {
            string upit = "SELECT Id FROM timovi WHERE termin= '" + termin.Id + "' AND naziv= 'Tim A';";
            return (int?)BazaPodataka.Instanca.DohvatiVrijednost(upit);
        }

        public int? DohvatiTimB()
        {
            string upit = "SELECT Id FROM timovi WHERE termin= '" + termin.Id + "' AND naziv= 'Tim B';";
            return (int?)BazaPodataka.Instanca.DohvatiVrijednost(upit);
        }

        private void PrebaciUTimA()
        {
            var igrac = neutralniIgraci.Where(_ => _.KorisnickoIme == listBoxNeutralni.SelectedItem.ToString()).FirstOrDefault();
            timAIgraci.Add(igrac);
            neutralniIgraci.Remove(igrac);
            OsvjeziPopisIgracaTimaA();
            OsvjeziPopisNeutralnihIgraca();
        }

        private void PrebaciUTimB()
        {
            var igrac = neutralniIgraci.Where(_ => _.KorisnickoIme == listBoxNeutralni.SelectedItem.ToString()).FirstOrDefault();
            timBIgraci.Add(igrac);
            neutralniIgraci.Remove(igrac);
            OsvjeziPopisIgracaTimaB();
            OsvjeziPopisNeutralnihIgraca();
        }

        private void PrebaciUNeutralneIzTimaA()
        {
            var igrac = timAIgraci.Where(_ => _.KorisnickoIme == listBoxTimA.SelectedItem.ToString()).FirstOrDefault();
            neutralniIgraci.Add(igrac);
            timAIgraci.Remove(igrac);
            OsvjeziPopisIgracaTimaA();
            OsvjeziPopisNeutralnihIgraca();
        }

        private void PrebaciUNeutralneIzTimaB()
        {
            var igrac = timBIgraci.Where(_ => _.KorisnickoIme == listBoxTimB.SelectedItem.ToString()).FirstOrDefault();
            neutralniIgraci.Add(igrac);
            timBIgraci.Remove(igrac);
            OsvjeziPopisIgracaTimaB();
            OsvjeziPopisNeutralnihIgraca();
        }

        private void OsvjeziPopisNeutralnihIgraca()
        {
            listBoxNeutralni.DataSource = neutralniIgraci.Select(_ => _.KorisnickoIme).ToList();
        }

        private void OsvjeziPopisIgracaTimaA()
        {
            listBoxTimA.DataSource = timAIgraci.Select(_ => _.KorisnickoIme).ToList();
        }

        private void OsvjeziPopisIgracaTimaB()
        {
            listBoxTimB.DataSource = timBIgraci.Select(_ => _.KorisnickoIme).ToList();
        }

        public void OnemoguciKontrole()
        {
            buttonKreiranjeTimova.Enabled = false;
            buttonNeutralniTimA.Enabled = false;
            buttonNeutralniTimB.Enabled = false;
            buttonTimANeutralni.Enabled = false;
            buttonTimBNeutralni.Enabled = false;
        }

        public List<Korisnik> DohvatiIgraceTima(int? timId)
        {
            List<Korisnik> igraci = new List<Korisnik>();

            string upit = "SELECT * FROM korisnik WHERE korisnik_id IN (SELECT korisnik FROM timovi_korisnici WHERE tim= '"+ timId + "');";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (dataReader.Read())
            {
                Korisnik igrac = new Korisnik();
                igrac.Id = (int)dataReader["korisnik_id"];
                igrac.Ime = dataReader["ime"].ToString();
                igrac.Prezime = dataReader["prezime"].ToString();
                igrac.KorisnickoIme = dataReader["korisnicko_ime"].ToString();
                igrac.Lozinka = dataReader["lozinka"].ToString();
                igrac.Email = dataReader["email"].ToString();

                igraci.Add(igrac);
            }
            dataReader.Close();

            return igraci;
        }
    }
}
