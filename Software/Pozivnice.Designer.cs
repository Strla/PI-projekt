namespace Nogometni_planer
{
    partial class Pozivnice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvGrupePozivnice = new System.Windows.Forms.DataGridView();
            this.grupaNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozvao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prihvatiBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.odbijBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.dgvTerminiPozivnice = new System.Windows.Forms.DataGridView();
            this.vrijemeIDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivGrupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kreatorTerminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prihvati = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Odbij = new System.Windows.Forms.DataGridViewButtonColumn();
            this.terminPozivnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPrijateljiPozivnice = new System.Windows.Forms.DataGridView();
            this.korImePozivateljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnprihvati = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnodbij = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prijateljstvoPozivnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPrijateljstvo = new System.Windows.Forms.Label();
            this.pozivnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupePozivnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminiPozivnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminPozivnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijateljiPozivnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prijateljstvoPozivnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozivnicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupePozivnice
            // 
            this.dgvGrupePozivnice.AutoGenerateColumns = false;
            this.dgvGrupePozivnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupePozivnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupaNazivDataGridViewTextBoxColumn,
            this.Pozvao,
            this.prihvatiBtn,
            this.odbijBtn});
            this.dgvGrupePozivnice.DataSource = this.pozivnicaBindingSource;
            this.dgvGrupePozivnice.Location = new System.Drawing.Point(17, 66);
            this.dgvGrupePozivnice.Name = "dgvGrupePozivnice";
            this.dgvGrupePozivnice.ReadOnly = true;
            this.dgvGrupePozivnice.Size = new System.Drawing.Size(526, 211);
            this.dgvGrupePozivnice.TabIndex = 0;
            this.dgvGrupePozivnice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPozivnice_CellContentClick);
            // 
            // grupaNazivDataGridViewTextBoxColumn
            // 
            this.grupaNazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grupaNazivDataGridViewTextBoxColumn.DataPropertyName = "GrupaNaziv";
            this.grupaNazivDataGridViewTextBoxColumn.HeaderText = "Grupa";
            this.grupaNazivDataGridViewTextBoxColumn.Name = "grupaNazivDataGridViewTextBoxColumn";
            this.grupaNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pozvao
            // 
            this.Pozvao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pozvao.DataPropertyName = "Pozivatelj";
            this.Pozvao.HeaderText = "Pozvao";
            this.Pozvao.Name = "Pozvao";
            this.Pozvao.ReadOnly = true;
            this.Pozvao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prihvatiBtn
            // 
            this.prihvatiBtn.HeaderText = "";
            this.prihvatiBtn.Name = "prihvatiBtn";
            this.prihvatiBtn.ReadOnly = true;
            this.prihvatiBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prihvatiBtn.Text = "Prihvati";
            this.prihvatiBtn.UseColumnTextForButtonValue = true;
            this.prihvatiBtn.Width = 90;
            // 
            // odbijBtn
            // 
            this.odbijBtn.HeaderText = "";
            this.odbijBtn.Name = "odbijBtn";
            this.odbijBtn.ReadOnly = true;
            this.odbijBtn.Text = "Odbij";
            this.odbijBtn.UseColumnTextForButtonValue = true;
            this.odbijBtn.Width = 90;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 608);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "D:\\Apps\\Visual studio repos\\PI projekt\\Software\\Nogometni planer.chm";
            // 
            // dgvTerminiPozivnice
            // 
            this.dgvTerminiPozivnice.AutoGenerateColumns = false;
            this.dgvTerminiPozivnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminiPozivnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vrijemeIDatumDataGridViewTextBoxColumn,
            this.lokacijaDataGridViewTextBoxColumn,
            this.nazivGrupeDataGridViewTextBoxColumn,
            this.kreatorTerminaDataGridViewTextBoxColumn,
            this.Prihvati,
            this.Odbij});
            this.dgvTerminiPozivnice.DataSource = this.terminPozivnicaBindingSource;
            this.dgvTerminiPozivnice.Location = new System.Drawing.Point(185, 332);
            this.dgvTerminiPozivnice.Name = "dgvTerminiPozivnice";
            this.dgvTerminiPozivnice.ReadOnly = true;
            this.dgvTerminiPozivnice.Size = new System.Drawing.Size(643, 253);
            this.dgvTerminiPozivnice.TabIndex = 0;
            this.dgvTerminiPozivnice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTerminiPozivnice_CellContentClick);
            // 
            // vrijemeIDatumDataGridViewTextBoxColumn
            // 
            this.vrijemeIDatumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrijemeIDatumDataGridViewTextBoxColumn.DataPropertyName = "VrijemeIDatum";
            this.vrijemeIDatumDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeIDatumDataGridViewTextBoxColumn.Name = "vrijemeIDatumDataGridViewTextBoxColumn";
            this.vrijemeIDatumDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemeIDatumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lokacijaDataGridViewTextBoxColumn
            // 
            this.lokacijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lokacijaDataGridViewTextBoxColumn.DataPropertyName = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.HeaderText = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.Name = "lokacijaDataGridViewTextBoxColumn";
            this.lokacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacijaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nazivGrupeDataGridViewTextBoxColumn
            // 
            this.nazivGrupeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivGrupeDataGridViewTextBoxColumn.DataPropertyName = "NazivGrupe";
            this.nazivGrupeDataGridViewTextBoxColumn.HeaderText = "Grupa";
            this.nazivGrupeDataGridViewTextBoxColumn.Name = "nazivGrupeDataGridViewTextBoxColumn";
            this.nazivGrupeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivGrupeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kreatorTerminaDataGridViewTextBoxColumn
            // 
            this.kreatorTerminaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kreatorTerminaDataGridViewTextBoxColumn.DataPropertyName = "KreatorTermina";
            this.kreatorTerminaDataGridViewTextBoxColumn.HeaderText = "Pozvao";
            this.kreatorTerminaDataGridViewTextBoxColumn.Name = "kreatorTerminaDataGridViewTextBoxColumn";
            this.kreatorTerminaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kreatorTerminaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Prihvati
            // 
            this.Prihvati.DataPropertyName = "Prihvati";
            this.Prihvati.HeaderText = "";
            this.Prihvati.Name = "Prihvati";
            this.Prihvati.ReadOnly = true;
            this.Prihvati.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prihvati.Text = "Prihvati";
            this.Prihvati.UseColumnTextForButtonValue = true;
            // 
            // Odbij
            // 
            this.Odbij.DataPropertyName = "Odbij";
            this.Odbij.HeaderText = "";
            this.Odbij.Name = "Odbij";
            this.Odbij.ReadOnly = true;
            this.Odbij.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Odbij.Text = "Odbij";
            this.Odbij.UseColumnTextForButtonValue = true;
            // 
            // terminPozivnicaBindingSource
            // 
            this.terminPozivnicaBindingSource.DataSource = typeof(Nogometni_planer.TerminPozivnica);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pozivnice za grupe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pozivnice za termine";
            // 
            // dgvPrijateljiPozivnice
            // 
            this.dgvPrijateljiPozivnice.AutoGenerateColumns = false;
            this.dgvPrijateljiPozivnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijateljiPozivnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korImePozivateljDataGridViewTextBoxColumn,
            this.btnprihvati,
            this.btnodbij});
            this.dgvPrijateljiPozivnice.DataSource = this.prijateljstvoPozivnicaBindingSource;
            this.dgvPrijateljiPozivnice.Location = new System.Drawing.Point(578, 66);
            this.dgvPrijateljiPozivnice.Name = "dgvPrijateljiPozivnice";
            this.dgvPrijateljiPozivnice.ReadOnly = true;
            this.dgvPrijateljiPozivnice.Size = new System.Drawing.Size(370, 211);
            this.dgvPrijateljiPozivnice.TabIndex = 0;
            this.dgvPrijateljiPozivnice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrijateljiPozivnice_CellContentClick);
            // 
            // korImePozivateljDataGridViewTextBoxColumn
            // 
            this.korImePozivateljDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.korImePozivateljDataGridViewTextBoxColumn.DataPropertyName = "KorImePozivatelj";
            this.korImePozivateljDataGridViewTextBoxColumn.HeaderText = "Pozivatelj";
            this.korImePozivateljDataGridViewTextBoxColumn.Name = "korImePozivateljDataGridViewTextBoxColumn";
            this.korImePozivateljDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnprihvati
            // 
            this.btnprihvati.DataPropertyName = "Prihvati";
            this.btnprihvati.HeaderText = "";
            this.btnprihvati.Name = "btnprihvati";
            this.btnprihvati.ReadOnly = true;
            this.btnprihvati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnprihvati.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnprihvati.Text = "Prihvati";
            this.btnprihvati.UseColumnTextForButtonValue = true;
            // 
            // btnodbij
            // 
            this.btnodbij.DataPropertyName = "Odbij";
            this.btnodbij.HeaderText = "";
            this.btnodbij.Name = "btnodbij";
            this.btnodbij.ReadOnly = true;
            this.btnodbij.Text = "Odbij";
            this.btnodbij.UseColumnTextForButtonValue = true;
            // 
            // prijateljstvoPozivnicaBindingSource
            // 
            this.prijateljstvoPozivnicaBindingSource.DataSource = typeof(Nogometni_planer.PrijateljstvoPozivnica);
            // 
            // labelPrijateljstvo
            // 
            this.labelPrijateljstvo.AutoSize = true;
            this.labelPrijateljstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrijateljstvo.Location = new System.Drawing.Point(574, 37);
            this.labelPrijateljstvo.Name = "labelPrijateljstvo";
            this.labelPrijateljstvo.Size = new System.Drawing.Size(196, 20);
            this.labelPrijateljstvo.TabIndex = 4;
            this.labelPrijateljstvo.Text = "Zahtjevi za prijateljistvo";
            // 
            // pozivnicaBindingSource
            // 
            this.pozivnicaBindingSource.DataSource = typeof(Nogometni_planer.GrupaPozivnica);
            // 
            // Pozivnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 641);
            this.Controls.Add(this.labelPrijateljstvo);
            this.Controls.Add(this.dgvPrijateljiPozivnice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTerminiPozivnice);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dgvGrupePozivnice);
            this.helpProvider.SetHelpKeyword(this, "Pozivnice");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "Pozivnice";
            this.helpProvider.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pozivnice";
            this.Load += new System.EventHandler(this.MojePozivniceZaGrupuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupePozivnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminiPozivnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminPozivnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijateljiPozivnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prijateljstvoPozivnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozivnicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupePozivnice;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozivateljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozvao;
        private System.Windows.Forms.DataGridViewButtonColumn prihvatiBtn;
        private System.Windows.Forms.DataGridViewButtonColumn odbijBtn;
        public System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.DataGridView dgvTerminiPozivnice;
        private System.Windows.Forms.BindingSource terminPozivnicaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Prihvati;
        private System.Windows.Forms.DataGridViewButtonColumn Odbij;
        private System.Windows.Forms.DataGridView dgvPrijateljiPozivnice;
        private System.Windows.Forms.Label labelPrijateljstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupaNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pozivnicaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeIDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivGrupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kreatorTerminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prijateljstvoPozivnicaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn korImePozivateljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnprihvati;
        private System.Windows.Forms.DataGridViewButtonColumn btnodbij;
    }
}