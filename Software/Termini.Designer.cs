namespace Nogometni_planer
{
    partial class Termini
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
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelVrijeme = new System.Windows.Forms.Label();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxVrijeme = new System.Windows.Forms.TextBox();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.buttonKreiraj = new System.Windows.Forms.Button();
            this.labelLokacija = new System.Windows.Forms.Label();
            this.textBoxLokacija = new System.Windows.Forms.TextBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.labelTermini = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "D:\\Apps\\Visual studio repos\\PI projekt\\Software\\Nogometni planer.chm";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatum.Location = new System.Drawing.Point(116, 130);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(53, 17);
            this.labelDatum.TabIndex = 0;
            this.labelDatum.Text = "Datum:";
            // 
            // labelVrijeme
            // 
            this.labelVrijeme.AutoSize = true;
            this.labelVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVrijeme.Location = new System.Drawing.Point(110, 184);
            this.labelVrijeme.Name = "labelVrijeme";
            this.labelVrijeme.Size = new System.Drawing.Size(59, 17);
            this.labelVrijeme.TabIndex = 1;
            this.labelVrijeme.Text = "Vrijeme:";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(249, 127);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerDatum.TabIndex = 2;
            // 
            // textBoxVrijeme
            // 
            this.textBoxVrijeme.Location = new System.Drawing.Point(249, 181);
            this.textBoxVrijeme.Name = "textBoxVrijeme";
            this.textBoxVrijeme.Size = new System.Drawing.Size(136, 20);
            this.textBoxVrijeme.TabIndex = 3;
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslov.Location = new System.Drawing.Point(275, 32);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(131, 39);
            this.labelNaslov.TabIndex = 4;
            this.labelNaslov.Text = "Termini";
            // 
            // buttonKreiraj
            // 
            this.buttonKreiraj.Location = new System.Drawing.Point(291, 314);
            this.buttonKreiraj.Name = "buttonKreiraj";
            this.buttonKreiraj.Size = new System.Drawing.Size(94, 28);
            this.buttonKreiraj.TabIndex = 5;
            this.buttonKreiraj.Text = "Kreiraj termin";
            this.buttonKreiraj.UseVisualStyleBackColor = true;
            this.buttonKreiraj.Click += new System.EventHandler(this.buttonKreiraj_Click);
            // 
            // labelLokacija
            // 
            this.labelLokacija.AutoSize = true;
            this.labelLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLokacija.Location = new System.Drawing.Point(105, 237);
            this.labelLokacija.Name = "labelLokacija";
            this.labelLokacija.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLokacija.Size = new System.Drawing.Size(64, 17);
            this.labelLokacija.TabIndex = 6;
            this.labelLokacija.Text = "Lokacija:";
            // 
            // textBoxLokacija
            // 
            this.textBoxLokacija.Location = new System.Drawing.Point(249, 234);
            this.textBoxLokacija.Name = "textBoxLokacija";
            this.textBoxLokacija.Size = new System.Drawing.Size(136, 20);
            this.textBoxLokacija.TabIndex = 7;
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(467, 107);
            this.dgvTermini.MultiSelect = false;
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(292, 322);
            this.dgvTermini.TabIndex = 8;
            this.dgvTermini.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTermini_MouseDown);
            // 
            // labelTermini
            // 
            this.labelTermini.AutoSize = true;
            this.labelTermini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTermini.Location = new System.Drawing.Point(464, 86);
            this.labelTermini.Name = "labelTermini";
            this.labelTermini.Size = new System.Drawing.Size(59, 17);
            this.labelTermini.TabIndex = 9;
            this.labelTermini.Text = "Termini:";
            // 
            // Termini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 475);
            this.Controls.Add(this.labelTermini);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.textBoxLokacija);
            this.Controls.Add(this.labelLokacija);
            this.Controls.Add(this.buttonKreiraj);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.textBoxVrijeme);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.labelVrijeme);
            this.Controls.Add(this.labelDatum);
            this.helpProvider.SetHelpKeyword(this, "Termin");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "Termini";
            this.helpProvider.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Termin";
            this.Load += new System.EventHandler(this.Termini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelVrijeme;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox textBoxVrijeme;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Button buttonKreiraj;
        private System.Windows.Forms.Label labelLokacija;
        private System.Windows.Forms.TextBox textBoxLokacija;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Label labelTermini;
    }
}