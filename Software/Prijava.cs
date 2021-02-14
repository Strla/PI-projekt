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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxKorIme.Text) && !String.IsNullOrEmpty(textBoxLozinka.Text))
            {
                string upit = "SELECT * FROM korisnik WHERE korisnicko_ime='" + textBoxKorIme.Text + "' and lozinka='" + textBoxLozinka.Text +"';";
                SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
                Korisnik korisnik = new Korisnik();
                while (dataReader.Read())
                {
                    korisnik.Id = (int)dataReader["korisnik_id"];
                    korisnik.Ime = dataReader["ime"].ToString();
                    korisnik.Prezime = dataReader["prezime"].ToString();
                    korisnik.KorisnickoIme = dataReader["korisnicko_ime"].ToString();
                    korisnik.Lozinka = dataReader["lozinka"].ToString();
                    korisnik.Email = dataReader["email"].ToString();
                }

                dataReader.Close();

                if (korisnik.Id == 0)
                {
                    MessageBox.Show("Korisnik s unesenim podacima ne postoji!");
                }
                else
                {
                    GrupeForm grupaForm = new GrupeForm(korisnik);
                    this.Hide();
                    grupaForm.ShowDialog();
                    this.Show();
                    textBoxKorIme.Clear();
                    textBoxLozinka.Clear();
                }
            }
            else
            {
                MessageBox.Show("Obavezno je unijeti korisničko ime i lozinku!");
            }
        }

        private void registracijaBtn_Click(object sender, EventArgs e)
        {
            Registracija registracijaForma = new Registracija(this);
            this.Hide();
            registracijaForma.ShowDialog();
            this.Show();
        }

        private void izlazBtn_Click(object sender, EventArgs e)
       {
            this.Close();
        }
    }
}
