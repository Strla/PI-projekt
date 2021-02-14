using Baza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogometni_planer
{
    public partial class Registracija : Form
    {
        private Prijava _prijavaForm;

        public Registracija(Prijava prijavaForm)
        {
            InitializeComponent();
            _prijavaForm = prijavaForm;
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            if (ValidirajUnesenePodatake())
            {
                Korisnik korisnik = new Korisnik
                {
                    Ime = textBoxIme.Text,
                    Prezime = textBoxPrezime.Text,
                    KorisnickoIme = textBoxKorIme.Text,
                    Lozinka = textBoxLozinka.Text,
                    Email = textBoxEmail.Text
                };
                string upit = "INSERT INTO korisnik VALUES('" + korisnik.KorisnickoIme + "', '" + korisnik.Lozinka + "', '" + korisnik.Email + "', '" + korisnik.Ime + "', '" + korisnik.Prezime + "');";
                BazaPodataka.Instanca.IzvrsiUpit(upit);
                MessageBox.Show("Uspješno ste obavili registraciju.");
                OcistiPolja();
            }
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            this.Close();
            _prijavaForm.Show();
        }

        private bool ValidirajUnesenePodatake()
        {
            bool validno = true;
            textBoxIme.BackColor = Color.White;
            textBoxPrezime.BackColor = Color.White;
            textBoxKorIme.BackColor = Color.White;
            textBoxLozinka.BackColor = Color.White;
            textBoxEmail.BackColor = Color.White;
            textBoxPonLozinka.BackColor = Color.White;

            if (String.IsNullOrEmpty(textBoxIme.Text))
            {
                textBoxIme.BackColor = Color.Red;
                validno = false;
            }
            if (String.IsNullOrEmpty(textBoxPrezime.Text))
            {
                textBoxPrezime.BackColor = Color.Red;
                validno = false;
            }
            if (String.IsNullOrEmpty(textBoxKorIme.Text))
            {
                textBoxKorIme.BackColor = Color.Red;
                validno = false;
            }
            else
            {
                string upit = "SELECT korisnik_id FROM korisnik WHERE korisnicko_ime='" + textBoxKorIme.Text + "';";
                int? korisnikId = (int?)BazaPodataka.Instanca.DohvatiVrijednost(upit);
                if (korisnikId != null)
                {
                    MessageBox.Show("Korisničko ime zauzeto. Unesite drugo korisničko ime.");
                    return false;
                }
            }
            if (String.IsNullOrEmpty(textBoxLozinka.Text))
            {
                textBoxLozinka.BackColor = Color.Red;
                validno = false;
            }
            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                textBoxEmail.BackColor = Color.Red;
                validno = false;
            }
            if (String.IsNullOrEmpty(textBoxPonLozinka.Text))
            {
                textBoxPonLozinka.BackColor = Color.Red;
                validno = false;
            }
            if (!validno)
            {
                MessageBox.Show("Potrebno je popuniti sva polja s podacima!");
            }
            else if (textBoxLozinka.Text != textBoxPonLozinka.Text)
            {
                textBoxPonLozinka.BackColor = Color.Red;
                MessageBox.Show("Krivo unesena ponovljena lozinka!");
                validno = false;
            }

            return validno;
        }

        private void OcistiPolja()
        {
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxKorIme.Clear();
            textBoxLozinka.Clear();
            textBoxPonLozinka.Clear();
            textBoxEmail.Clear();
        }
    }
}
