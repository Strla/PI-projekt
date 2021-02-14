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
    public partial class Prijatelji : Form
    {
        private Korisnik pozivatelj;

        private List<Korisnik> prijatelji;

        public Prijatelji(Korisnik korisnik)
        {
            pozivatelj = korisnik;
            InitializeComponent();
        }

        private void Prijatelji_Load(object sender, EventArgs e)
        {
            prijatelji = DohvatiPrijatelje();
            PrikaziPrijatelje();
        }

        private void buttonDodajPrijatelja_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxKorIme.Text))
            {
                string upit = "SELECT * FROM korisnik WHERE korisnicko_ime= '" + textBoxKorIme.Text + "';";
                SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
                Korisnik primatelj = new Korisnik(); ;
                while (dataReader.Read())
                {
                    primatelj.Id = (int)dataReader["korisnik_id"];
                    primatelj.Ime = dataReader["ime"].ToString();
                    primatelj.Prezime = dataReader["prezime"].ToString();
                    primatelj.KorisnickoIme = dataReader["korisnicko_ime"].ToString();
                    primatelj.Lozinka = dataReader["lozinka"].ToString();
                    primatelj.Email = dataReader["email"].ToString();
                }
                dataReader.Close();
                if (primatelj.Id == 0)
                {
                    MessageBox.Show("Upisani korisnik ne postoji.");
                }
                else
                {
                    if (!GrupeForm.ProvjeraPostojecegZahtjeva(primatelj, pozivatelj))
                    {
                        KreirajPozivnicu(primatelj);
                        MessageBox.Show("Uspješno ste poslali zahtjev za prijateljstvo korisniku " + primatelj.KorisnickoIme);
                    }
                    else
                    {
                        MessageBox.Show("Upisanom korisniku je poslan zhtjev ili ste već prijatelji.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Obavezno unesite korisničko ime.");
            }
        }

        private void KreirajPozivnicu(Korisnik primatelj)
        {
            string upit = "INSERT INTO prijateljstvo_pozivnice VALUES('" + pozivatelj.Id + "', '" + primatelj.Id + "', " + '0' + ");";
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        private List<Korisnik> DohvatiPrijatelje()
        {
            string upit = "SELECT * FROM prijatelji WHERE korisnik1= '" + pozivatelj.Id + "' OR korisnik2= '"+ pozivatelj.Id +"';";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            List<int> prijateljiId = new List<int>();
            while (dataReader.Read())
            {
                if (int.Parse(dataReader["korisnik1"].ToString()) != pozivatelj.Id)
                {
                    prijateljiId.Add(int.Parse(dataReader["korisnik1"].ToString()));
                }
                else
                {
                    prijateljiId.Add(int.Parse(dataReader["korisnik2"].ToString()));
                }
                
            }
            dataReader.Close();


            List<Korisnik> prijatelji = new List<Korisnik>();
            if (prijateljiId.Count > 0)
            {
                string idPrijatelja = string.Join(", ", prijateljiId);
                string upitPrijatelji = "SELECT * FROM korisnik WHERE korisnik_id IN (" + idPrijatelja + ");";
                dataReader = BazaPodataka.Instanca.DohvatiDataReader(upitPrijatelji);
                while (dataReader.Read())
                {
                    Korisnik prijatelj = new Korisnik();
                    prijatelj.Id = (int)dataReader["korisnik_id"];
                    prijatelj.Ime = dataReader["ime"].ToString();
                    prijatelj.Prezime = dataReader["prezime"].ToString();
                    prijatelj.KorisnickoIme = dataReader["korisnicko_ime"].ToString();
                    prijatelj.Lozinka = dataReader["lozinka"].ToString();
                    prijatelj.Email = dataReader["email"].ToString();
                    prijatelji.Add(prijatelj);
                }
                dataReader.Close();
            }

            return prijatelji;
        }

        private void listBoxPrijatelji_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Obriši prijatelja").Name = "Obriši prijatelja";
                menu.Items.Add("Pošalji poruku").Name = "Pošalji poruku";

                menu.Show(listBoxPrijatelji, new Point(e.X, e.Y));

                menu.ItemClicked += new ToolStripItemClickedEventHandler(PokreniAkciju);
            }
        }

        private void PokreniAkciju(Object sender, ToolStripItemClickedEventArgs e)
        {
            var prijatelj = prijatelji.Where(_ => _.KorisnickoIme == listBoxPrijatelji.SelectedItem.ToString()).FirstOrDefault();

            if (e.ClickedItem.Name == "Obriši prijatelja")
            {
                string upit = "DELETE FROM prijateljstvo_pozivnice WHERE (pozivatelj = '" + pozivatelj.Id + "' AND primatelj = '"+ prijatelj.Id +"') OR (pozivatelj = '"+ prijatelj.Id +"' AND primatelj = '"+pozivatelj.Id+"');";
                BazaPodataka.Instanca.IzvrsiUpit(upit);

                string upit2 = "DELETE FROM prijatelji WHERE (korisnik1 = '" + pozivatelj.Id + "' AND korisnik2 = '" + prijatelj.Id + "') OR (korisnik1 = '" + prijatelj.Id + "' AND korisnik2 = '" + pozivatelj.Id + "');";
                BazaPodataka.Instanca.IzvrsiUpit(upit2);

                prijatelji.Remove(prijatelj);
                PrikaziPrijatelje();
            }
            if (e.ClickedItem.Name == "Pošalji poruku")
            {
                PrivatnePoruke privatnePorukeForm = new PrivatnePoruke(pozivatelj, prijatelj);
                privatnePorukeForm.ShowDialog();
            }
        }

        private void PrikaziPrijatelje()
        {
            listBoxPrijatelji.DataSource = prijatelji.Select(_ => _.KorisnickoIme).ToList();
        }
    }
}
