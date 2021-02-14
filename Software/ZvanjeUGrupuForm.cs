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
    public partial class ZvanjeUGrupuForm : Form
    {
        public Korisnik pozivateljKorisnik;
        public Grupa grupaUKojuJePozvanKorisnik;
        public ZvanjeUGrupuForm(Korisnik korisnik, Grupa grupa)
        {
            InitializeComponent();
            pozivateljKorisnik = korisnik;
            grupaUKojuJePozvanKorisnik = grupa;
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pozoviBtn_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            bool postojeciKorisnik = false;
            bool korisnikVecUGrupi = true;
            postojeciKorisnik = ProvjeriPostojiLiKorisnik(username);
            int korisnikID = DohvatiIdentifikatorPozvanogKorisnika(username);
            korisnikVecUGrupi = ProvjeriNalaziLiSeKorisnikUGrupi(korisnikID, grupaUKojuJePozvanKorisnik);
            if (postojeciKorisnik && !korisnikVecUGrupi)
            {
                PošaljiPozivnicu(korisnikID, grupaUKojuJePozvanKorisnik.IDGrupe, pozivateljKorisnik.Id);
                labelNapomena.ForeColor = Color.Green;
                labelNapomena.Text = "Korisniku " + username + " je poslana pozivnica za grupu!";
                btnNatrag.Visible = true;
                odustaniBtn.Visible = false;
                pozoviBtn.Visible = false;
                noviPozivBtn.Visible = true;
            } else
            {
                if (postojeciKorisnik && korisnikVecUGrupi)
                {
                    labelNapomena.ForeColor = Color.Red;
                    labelNapomena.Text = "Korisnik " + username + " je već u grupi!";
                } else
                {
                    labelNapomena.ForeColor = Color.Red;
                    labelNapomena.Text = "Korisnik " + username + " ne postoji!";
                }
            }
        }

        private bool ProvjeriPostojiLiKorisnik(string user)
        {
            string upit = "SELECT * FROM [korisnik] WHERE [korisnicko_ime]='"+ user +"'";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            if (dataReader.Read())
            {
                dataReader.Close();
                return true;
            }
            dataReader.Close();
            return false;
        }

        private bool ProvjeriNalaziLiSeKorisnikUGrupi(int userID, Grupa g)
        {
            string upit = "SELECT * FROM [clanstvo] INNER JOIN [korisnik] on [korisnik].[korisnik_id]=[clanstvo].[korisnik] WHERE [clanstvo].[grupa]='" + g.IDGrupe + "' AND [korisnik].[korisnik_id]='" + userID + "'";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            if (dataReader.Read())
            {
                dataReader.Close();
                return true;
            }
            dataReader.Close();
            return false;
        }

        private int DohvatiIdentifikatorPozvanogKorisnika(string user)
        {
            string upit = "SELECT [korisnik_id] FROM [korisnik] WHERE [korisnicko_ime]='" + user + "'";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            int id = 0;
            while (dataReader.Read())
            {
                id = int.Parse(dataReader["korisnik_id"].ToString());
            }
            dataReader.Close();
            return id;
        }

        private void PošaljiPozivnicu(int userID, int grupa, int pozivatelj)
        {
            string upit = "INSERT INTO [grupa_pozivnice] ([korisnik],[grupa],[odgovorena], [pozivatelj]) VALUES ('" + userID+"','"+grupa+"','0','"+pozivatelj+"')";
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        private void ZvanjeUGrupuForm_Load(object sender, EventArgs e)
        {
            labelNapomena.Text = "";
            btnNatrag.Visible = false;
            noviPozivBtn.Visible = false;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void noviPozivBtn_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            labelNapomena.Text = "";
            btnNatrag.Visible = false;
            odustaniBtn.Visible = true;
            pozoviBtn.Visible = true;
            noviPozivBtn.Visible = false;
        }
    }
}
