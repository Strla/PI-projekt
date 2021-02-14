using Baza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogometni_planer
{
    public partial class Termini : Form
    {
        private Korisnik korisnik;

        private Grupa grupa;

        private Termin ter;

        public Termini(Korisnik korisnik, Grupa grupa)
        {
            this.korisnik = korisnik;
            this.grupa = grupa;
            InitializeComponent();
        }

        private void Termini_Load(object sender, EventArgs e)
        {
            OsvjeziPopisTermina();
            if (ProvjeraAdmina() == null)
            {
                buttonKreiraj.Enabled = false;
            }
        }

        private void buttonKreiraj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                TimeSpan vrijeme = TimeSpan.Parse(textBoxVrijeme.Text);
                var datumIVrijeme = dateTimePickerDatum.Value.Date + vrijeme;
                Termin termin = new Termin
                {
                    DatumIVrijeme = datumIVrijeme.ToString("yyyy-MM-dd HH:mm:ss"),
                    Lokacija = textBoxLokacija.Text,
                    Grupa = grupa.IDGrupe,
                    Kreator = korisnik.Id
                };
                string upit = "INSERT INTO [termin] ([datum_vrijeme], [lokacija], [grupa], [kreator]) VALUES('" + termin.DatumIVrijeme + "', '" + termin.Lokacija + "', '" + termin.Grupa + "', '" + termin.Kreator + "');";
                BazaPodataka.Instanca.IzvrsiUpit(upit);
                string upit2 = "INSERT INTO [termini_korisnici] ([termin], [korisnik]) VALUES ((SELECT MAX([termin_id]) FROM [termin]), '" + korisnik.Id + "')";//korisnik koji je napravio termin se automatski nalazi na listi za taj termin
                BazaPodataka.Instanca.IzvrsiUpit(upit2);
                OcistiPolja();
                OsvjeziPopisTermina();
                MessageBox.Show("Termin je uspješno dodan");
            }
        }

        private bool Validiraj()
        {
            bool validno = true;
            DateTime datumIVrijeme = new DateTime();
            string vrijemeUzorak = @"[0-9]{1,2}:[0-9]{2}";
            Match match = Regex.Match(textBoxVrijeme.Text, vrijemeUzorak);
            if (match.Success)
            {
                try
                {
                    TimeSpan vrijeme = TimeSpan.Parse(textBoxVrijeme.Text);
                    datumIVrijeme = dateTimePickerDatum.Value.Date + vrijeme;
                }
                catch (Exception ex)
                {
                    if (ex is FormatException || ex is OverflowException)
                    {
                        MessageBox.Show("Krivo uneseno vrijeme. Vrijem je potrebno unijeti u formatu HH:mm");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Krivo uneseno vrijeme. Vrijem je potrebno unijeti u formatu HH:mm");
                return false;
            }
            if (datumIVrijeme <= DateTime.Now)
            {
                MessageBox.Show("Uneseni datum i vrijeme su prošli. Unesite datum i vrijeme u budućnosti.");
                validno = false;
            }
            if (String.IsNullOrEmpty(textBoxVrijeme.Text) || String.IsNullOrEmpty(textBoxLokacija.Text))
            {
                MessageBox.Show("Obavezno je popuniti polja 'Vrijeme' i 'Lokacija'.");
                validno = false;
            }

            return validno;
        }

        private bool AkoSamKreiraoTajTermin(Korisnik k, Grupa g, Termin t)
        {
            string upit = "SELECT * FROM [korisnik] INNER JOIN [termin] on [termin].[kreator]=[korisnik].[korisnik_id] WHERE [termin].[kreator]='" + k.Id + "' " +
                "AND [termin].[grupa]='" + g.IDGrupe + "' AND [termin].[termin_id]='" + t.Id + "'";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            if (dataReader.Read())
            {
                dataReader.Close();
                return true;
            }
            else
            {
                dataReader.Close();
                return false;
            }
        }

        private void OcistiPolja()
        {
            dateTimePickerDatum.ResetText();
            textBoxVrijeme.Clear();
            textBoxLokacija.Clear();
        }

        private void OsvjeziPopisTermina()
        {
            var termini = DohvatiTermineGrupe();
            dgvTermini.DataSource = termini;
            dgvTermini.Columns["Id"].Visible = false;
            dgvTermini.Columns["Grupa"].Visible = false;
            dgvTermini.Columns["Kreator"].Visible = false;
            dgvTermini.Columns["DatumIVrijeme"].HeaderText = "Datum i vrijeme";
            dgvTermini.Columns["DatumIVrijeme"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (termini.Count != 0)
            {
                dgvTermini.CurrentCell = dgvTermini.Rows[0].Cells[1];
            }
        }

        private List<Termin> DohvatiTermineGrupe()
        {
            string upit = "SELECT * FROM termin WHERE grupa= '" + grupa.IDGrupe + "'";
            SqlDataReader dataReader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            List<Termin> termini = new List<Termin>();
            while (dataReader.Read())
            {
                Termin termin = new Termin
                {
                    Id = int.Parse(dataReader["termin_id"].ToString()),
                    DatumIVrijeme = dataReader["datum_vrijeme"].ToString(),
                    Lokacija = dataReader["lokacija"].ToString(),
                    Grupa = int.Parse(dataReader["grupa"].ToString()),
                    Kreator = int.Parse(dataReader["kreator"].ToString())
                };
                termini.Add(termin);
            }
            dataReader.Close();

            return termini;
        }

        private void dgvTermini_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var klik = dgvTermini.HitTest(e.X, e.Y);

                if (klik.RowIndex != -1)
                {
                    dgvTermini.ClearSelection();
                    dgvTermini.Rows[klik.RowIndex].Selected = true;
                    dgvTermini.CurrentCell = dgvTermini.Rows[klik.RowIndex].Cells[1];
                    ter = dgvTermini.CurrentRow.DataBoundItem as Termin;
                }

                ContextMenuStrip menu = new ContextMenuStrip();
                if (AkoSamKreiraoTajTermin(korisnik, grupa, ter))
                {
                    menu.Items.Add("Pozovi korisnika").Name = "Pozovi korisnika";
                    menu.Items.Add("Obriši termin").Name = "Obriši termin";
                }
                menu.Items.Add("Timovi").Name = "Timovi";

                menu.Show(dgvTermini, new Point(e.X, e.Y));

                menu.ItemClicked += new ToolStripItemClickedEventHandler(IzvrsiNaredbu);
            }
        }

        private void IzvrsiNaredbu(Object sender, ToolStripItemClickedEventArgs e)
        {
            Termin termin = dgvTermini.CurrentRow.DataBoundItem as Termin;

            if (e.ClickedItem.Name == "Obriši termin")
            {
                string upit = "DELETE FROM termin WHERE termin_id = '"+ termin.Id +"';";
                BazaPodataka.Instanca.IzvrsiUpit(upit);
                OsvjeziPopisTermina();
            }
            if (e.ClickedItem.Name == "Pozovi korisnika")
            {
                FormaZaPozivanjeNaTermin form = new FormaZaPozivanjeNaTermin(termin, grupa, korisnik);
                form.ShowDialog();
            }
            if (e.ClickedItem.Name == "Timovi")
            {
                Timovi timoviForma = new Timovi(termin, AkoSamKreiraoTajTermin(korisnik, grupa, ter));
                timoviForma.ShowDialog();
            }
        }

        private int? ProvjeraAdmina()
        { 
            string upit = "SELECT administracija_id FROM administracija WHERE admin= '"+ korisnik.Id +"' AND grupa= '"+ grupa.IDGrupe +"';";
            return (int?)BazaPodataka.Instanca.DohvatiVrijednost(upit);
        }
    }
}
