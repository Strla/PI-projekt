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
    public partial class Pozivnice : Form
    {
        Korisnik korisnik;

        List<GrupaPozivnica> pozivniceGrupe = new List<GrupaPozivnica>();

        List<TerminPozivnica> pozivniceTermini = new List<TerminPozivnica>();

        List<PrijateljstvoPozivnica> zahtjeviPrijateljstvo = new List<PrijateljstvoPozivnica>();

        public Pozivnice(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void MojePozivniceZaGrupuForm_Load(object sender, EventArgs e)
        {
            PrimjeniOsnovnePostavkeNaDatagridview();
            OsvjeziDatagridview();
        }

        private List<GrupaPozivnica> DohvatiMojePozivniceZaGrupu()
        {
            List<GrupaPozivnica> pozivniceGrupa = new List<GrupaPozivnica>();
            string upit = "SELECT [grupa_pozivnice].[poziv_id], [grupa_pozivnice].[grupa], [grupa].[naziv], [korisnik].[korisnicko_ime] " +
                "FROM [grupa] INNER JOIN [grupa_pozivnice] on [grupa_pozivnice].[grupa]=[grupa].[grupa_id] " +
                "INNER JOIN [korisnik] on [korisnik].[korisnik_id]=[grupa_pozivnice].[pozivatelj] " +
                "WHERE [grupa_pozivnice].[korisnik]='" + korisnik.Id + "' AND [grupa_pozivnice].[odgovorena]='0'";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (dataReader.Read())
            {
                GrupaPozivnica poziv = new GrupaPozivnica();
                poziv.GrupaID = int.Parse(dataReader["grupa"].ToString());
                poziv.PozivnicaID= int.Parse(dataReader["poziv_id"].ToString());
                poziv.GrupaNaziv = dataReader["naziv"].ToString();
                poziv.Pozivatelj = dataReader["korisnicko_ime"].ToString();
                pozivniceGrupa.Add(poziv);
            }
            dataReader.Close();
            return pozivniceGrupa;
        }

        private List<TerminPozivnica> DohvatiMojePozivniceZaTermin()
        {
            List<TerminPozivnica> pozivniceTermini = new List<TerminPozivnica>();
            string upit = "SELECT termin_pozivnice.poziv_termin_id, termin.termin_id, termin.datum_vrijeme, termin.lokacija, korisnik.korisnicko_ime, grupa.naziv " +
                "FROM termin_pozivnice INNER JOIN termin ON termin.termin_id=termin_pozivnice.termin INNER JOIN grupa ON grupa.grupa_id=termin.grupa " +
                "INNER JOIN korisnik ON korisnik.korisnik_id=termin.kreator WHERE termin_pozivnice.korisnik='" + korisnik.Id + "' AND termin_pozivnice.odgovorena='0'";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (dataReader.Read())
            {
                TerminPozivnica poziv = new TerminPozivnica();
                poziv.TerminPozivnicaId = int.Parse(dataReader["poziv_termin_id"].ToString());
                poziv.TerminId = int.Parse(dataReader["termin_id"].ToString());
                poziv.VrijemeIDatum = dataReader["datum_vrijeme"].ToString();
                poziv.Lokacija = dataReader["lokacija"].ToString();
                poziv.KreatorTermina = dataReader["korisnicko_ime"].ToString();
                poziv.NazivGrupe = dataReader["naziv"].ToString();
                pozivniceTermini.Add(poziv);
            }
            dataReader.Close();
            return pozivniceTermini;
        }

        private List<PrijateljstvoPozivnica> DohvatiMojeZahtjeveZaPrijateljstvo()
        {
            List<PrijateljstvoPozivnica> prijateljstvoZahtjevi = new List<PrijateljstvoPozivnica>();
            string upit = "SELECT prijateljstvo_pozivnice.Id, prijateljstvo_pozivnice.pozivatelj, prijateljstvo_pozivnice.primatelj, prijateljstvo_pozivnice.odgovorena, korisnik.korisnicko_ime " +
                "FROM prijateljstvo_pozivnice INNER JOIN korisnik ON korisnik.korisnik_id=prijateljstvo_pozivnice.pozivatelj " +
                "WHERE prijateljstvo_pozivnice.primatelj= '" + korisnik.Id + "' AND prijateljstvo_pozivnice.odgovorena= 0;";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (dataReader.Read())
            {
                PrijateljstvoPozivnica zahtjev = new PrijateljstvoPozivnica();

                zahtjev.Id = int.Parse(dataReader["Id"].ToString());
                zahtjev.Pozivatelj = int.Parse(dataReader["pozivatelj"].ToString());
                zahtjev.Primatelj = int.Parse(dataReader["primatelj"].ToString());
                zahtjev.Odgovorena = int.Parse(dataReader["odgovorena"].ToString());
                zahtjev.KorImePozivatelj = dataReader["korisnicko_ime"].ToString();

                prijateljstvoZahtjevi.Add(zahtjev);
            }
            dataReader.Close();

            return prijateljstvoZahtjevi.Where(_ => _.Odgovorena == 0).ToList();
        }

        private void OsvjeziDatagridview()
        {
            pozivniceGrupe = DohvatiMojePozivniceZaGrupu();
            pozivniceTermini = DohvatiMojePozivniceZaTermin();
            zahtjeviPrijateljstvo = DohvatiMojeZahtjeveZaPrijateljstvo();
            dgvGrupePozivnice.DataSource = null;
            dgvGrupePozivnice.DataSource = pozivniceGrupe;
            dgvTerminiPozivnice.DataSource = null;
            dgvTerminiPozivnice.DataSource = pozivniceTermini;
            dgvPrijateljiPozivnice.DataSource = null;
            dgvPrijateljiPozivnice.DataSource = zahtjeviPrijateljstvo;
        }

        private void PrimjeniOsnovnePostavkeNaDatagridview()
        {
            dgvGrupePozivnice.RowHeadersVisible = false;
            dgvGrupePozivnice.AllowUserToResizeColumns = false;
            dgvGrupePozivnice.AllowUserToOrderColumns = false;

            dgvTerminiPozivnice.RowHeadersVisible = false;
            dgvTerminiPozivnice.AllowUserToResizeColumns = false;
            dgvTerminiPozivnice.AllowUserToOrderColumns = false;

            dgvPrijateljiPozivnice.RowHeadersVisible = false;
            dgvPrijateljiPozivnice.AllowUserToResizeColumns = false;
            dgvPrijateljiPozivnice.AllowUserToOrderColumns = false;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPozivnice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvGrupePozivnice.Columns[e.ColumnIndex].Name== "prihvatiBtn")
            {
                GrupaPozivnica poziv = dgvGrupePozivnice.CurrentRow.DataBoundItem as GrupaPozivnica;
                PrihvatiPozivGrupa(poziv);
            }
            else if (dgvGrupePozivnice.Columns[e.ColumnIndex].Name == "odbijBtn")
            {
                GrupaPozivnica poziv = dgvGrupePozivnice.CurrentRow.DataBoundItem as GrupaPozivnica;
                OdbijPozivGrupa(poziv);
            }
        }

        private void PrihvatiPozivGrupa(GrupaPozivnica pozivnica)
        {
            string upit_pozivnicaOdgovorena = "UPDATE [grupa_pozivnice] SET [odgovorena]='1' WHERE [grupa_pozivnice].[poziv_id]='" + pozivnica.PozivnicaID + "'";
            BazaPodataka.Instanca.IzvrsiUpit(upit_pozivnicaOdgovorena);
            string uclanjivanje = "INSERT INTO [clanstvo] ([grupa], [korisnik]) VALUES ('" + pozivnica.GrupaID + "','" + korisnik.Id + "')";
            BazaPodataka.Instanca.IzvrsiUpit(uclanjivanje);
            MessageBox.Show("Prihvatili ste poziv! Sada ste član grupe " + pozivnica.GrupaNaziv + "!", "Poziv prihvaćen" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            OsvjeziDatagridview();

        }

        private void OdbijPozivGrupa(GrupaPozivnica pozivnica)
        {
            string upit_pozivnicaOdgovorena = "UPDATE [grupa_pozivnice] SET [odgovorena]='1' WHERE [grupa_pozivnice].[poziv_id]='" + pozivnica.PozivnicaID + "'";
            BazaPodataka.Instanca.IzvrsiUpit(upit_pozivnicaOdgovorena);
            MessageBox.Show("Odbili ste poziv!" , "Poziv odbijen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OsvjeziDatagridview();

        }

        private void dgvTerminiPozivnice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTerminiPozivnice.Columns[e.ColumnIndex].Name == "Prihvati")
            {
                TerminPozivnica poziv = dgvTerminiPozivnice.CurrentRow.DataBoundItem as TerminPozivnica;
                PrihvatiPozivNaTermin(poziv);
            }
            else if (dgvTerminiPozivnice.Columns[e.ColumnIndex].Name == "Odbij")
            {
                TerminPozivnica poziv = dgvTerminiPozivnice.CurrentRow.DataBoundItem as TerminPozivnica;
                OdbijPozivNaTermin(poziv);
            }
        }

        private void PrihvatiPozivNaTermin(TerminPozivnica pozivnica)
        {
            string upitPozivnica = "UPDATE [termin_pozivnice] SET [odgovorena]='1' WHERE [termin_pozivnice].[poziv_termin_id]='" + pozivnica.TerminPozivnicaId + "'";
            BazaPodataka.Instanca.IzvrsiUpit(upitPozivnica);
            string upitPridruzba = "INSERT INTO [termini_korisnici] ([termin], [korisnik]) VALUES ('" + pozivnica.TerminId + "','" + korisnik.Id + "')";
            BazaPodataka.Instanca.IzvrsiUpit(upitPridruzba);
            MessageBox.Show("Prihvatili ste poziv! Sada ste zabilježeni za termin u vrijeme " + pozivnica.VrijemeIDatum + " na lokaciji " + pozivnica.Lokacija + "!", "Poziv prihvaćen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OsvjeziDatagridview();
        }

        private void OdbijPozivNaTermin(TerminPozivnica pozivnica)
        {
            string upitPozivnica = "UPDATE [termin_pozivnice] SET [odgovorena]='1' WHERE [termin_pozivnice].[poziv_termin_id]='" + pozivnica.TerminPozivnicaId + "'";
            BazaPodataka.Instanca.IzvrsiUpit(upitPozivnica);
            MessageBox.Show("Odbili ste poziv!", "Poziv odbijen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OsvjeziDatagridview();
        }

        private void dgvPrijateljiPozivnice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrijateljiPozivnice.Columns[e.ColumnIndex].Name == "btnprihvati")
            {
                PrijateljstvoPozivnica zahtjev = dgvPrijateljiPozivnice.CurrentRow.DataBoundItem as PrijateljstvoPozivnica;
                PrihvatiZahtjevPrijateljstvo(zahtjev);
            }
            else if (dgvPrijateljiPozivnice.Columns[e.ColumnIndex].Name == "btnodbij")
            {
                PrijateljstvoPozivnica zahtjev = dgvPrijateljiPozivnice.CurrentRow.DataBoundItem as PrijateljstvoPozivnica;
                OdbijZahtjevPrijateljstvo(zahtjev);
            }
        }

        private void PrihvatiZahtjevPrijateljstvo(PrijateljstvoPozivnica zahtjev)
        {
            string upit = "UPDATE prijateljstvo_pozivnice SET odgovorena= '1' WHERE Id='" + zahtjev.Id + "'";
            BazaPodataka.Instanca.IzvrsiUpit(upit);
            string prijateljiUpit = "INSERT INTO prijatelji VALUES('"+ korisnik.Id +"', '"+ zahtjev.Pozivatelj +"')";
            BazaPodataka.Instanca.IzvrsiUpit(prijateljiUpit);
            OsvjeziDatagridview();
        }

        private void OdbijZahtjevPrijateljstvo(PrijateljstvoPozivnica zahtjev)
        {
            string upit= "UPDATE prijateljstvo_pozivnice SET odgovorena= '2' WHERE Id='" + zahtjev.Id + "'";
            BazaPodataka.Instanca.IzvrsiUpit(upit);
            MessageBox.Show("Odbili ste Zahtjev!", "Zahtjev odbijen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OsvjeziDatagridview();
        }
    }
}
