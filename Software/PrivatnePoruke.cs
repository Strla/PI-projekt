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
    public partial class PrivatnePoruke : Form
    {
        private Korisnik posiljatelj;

        private Korisnik primatelj;

        public PrivatnePoruke(Korisnik posiljatelj, Korisnik primatelj)
        {
            this.posiljatelj = posiljatelj;
            this.primatelj = primatelj;
            InitializeComponent();
        }

        private void PrivatnePoruke_Load(object sender, EventArgs e)
        {
            OsvjeziPoruke();
            OznaciKaoProcitano(primatelj, posiljatelj);
        }

        private void buttonPosalji_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPoruka.Text))
            {
                PosaljiPoruku();
                textBoxPoruka.Clear();
                txtBoxPoruke.Clear();
                OsvjeziPoruke();
            }
            else
            {
                MessageBox.Show("Obavezno upišite tekst poruke.");
            }
        }

        private void PosaljiPoruku()
        {
            string vrijeme = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string upit = "INSERT INTO privatne_poruke VALUES('"+ posiljatelj.Id +"', '"+ primatelj.Id + "', '" + textBoxPoruka.Text + "', '"+ vrijeme +"', '"+ 0 +"');";
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        private List<PrivatnaPoruka> DohvatiSvePoruke()
        {
            string upit = "SELECT Id, korisnik.korisnicko_ime, primatelj, vrijeme, poruka, procitano FROM privatne_poruke " +
                "INNER JOIN korisnik on korisnik.korisnik_id=privatne_poruke.posiljatelj " +
                "WHERE (posiljatelj= '" + posiljatelj.Id + "' AND primatelj= '"+ primatelj.Id + "') " +
                "OR (posiljatelj= '" + primatelj.Id + "' AND primatelj= '" + posiljatelj.Id + "');";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            List<PrivatnaPoruka> poruke = new List<PrivatnaPoruka>();
            while (dataReader.Read())
            {
                PrivatnaPoruka poruka = new PrivatnaPoruka();
                poruka.Id = int.Parse(dataReader["Id"].ToString());
                poruka.Posiljatelj = dataReader["korisnicko_ime"].ToString();
                poruka.Tekst = dataReader["poruka"].ToString();
                poruka.Vrijeme = dataReader["vrijeme"].ToString();
                poruka.Procitano = bool.Parse(dataReader["procitano"].ToString());
                poruke.Add(poruka);
            }
            dataReader.Close();

            return poruke;
        }

        private void OsvjeziPoruke()
        {
            var privatnePoruke = DohvatiSvePoruke();

            foreach (PrivatnaPoruka p in privatnePoruke)
            {
                string poruka = "[" + p.Vrijeme + "]   " + p.Posiljatelj + ":  " + p.Tekst + "\n";
                txtBoxPoruke.Text += poruka;
            }
        }

        public static void OznaciKaoProcitano(Korisnik primatelj, Korisnik posiljatelj)
        {
            string upit = "UPDATE privatne_poruke SET procitano = '1' WHERE primatelj= '" + posiljatelj.Id + "' AND posiljatelj= '"+ primatelj.Id +"';";
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }
    }
}
