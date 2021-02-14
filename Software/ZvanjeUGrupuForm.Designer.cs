namespace Nogometni_planer
{
    partial class ZvanjeUGrupuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.pozoviBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.labelNapomena = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.noviPozivBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi korisničko ime korisnika";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(78, 75);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(224, 20);
            this.txtBoxUsername.TabIndex = 1;
            // 
            // pozoviBtn
            // 
            this.pozoviBtn.Location = new System.Drawing.Point(78, 113);
            this.pozoviBtn.Name = "pozoviBtn";
            this.pozoviBtn.Size = new System.Drawing.Size(69, 23);
            this.pozoviBtn.TabIndex = 2;
            this.pozoviBtn.Text = "Pozovi";
            this.pozoviBtn.UseVisualStyleBackColor = true;
            this.pozoviBtn.Click += new System.EventHandler(this.pozoviBtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.Location = new System.Drawing.Point(233, 113);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(69, 23);
            this.odustaniBtn.TabIndex = 3;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = true;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // labelNapomena
            // 
            this.labelNapomena.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNapomena.ForeColor = System.Drawing.Color.Black;
            this.labelNapomena.Location = new System.Drawing.Point(0, 98);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(389, 107);
            this.labelNapomena.TabIndex = 4;
            this.labelNapomena.Text = "Napomena";
            this.labelNapomena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(153, 113);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(74, 23);
            this.btnNatrag.TabIndex = 5;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "D:\\Apps\\Visual studio repos\\PI projekt\\Software\\Nogometni planer.chm";
            // 
            // noviPozivBtn
            // 
            this.noviPozivBtn.Location = new System.Drawing.Point(78, 113);
            this.noviPozivBtn.Name = "noviPozivBtn";
            this.noviPozivBtn.Size = new System.Drawing.Size(69, 23);
            this.noviPozivBtn.TabIndex = 6;
            this.noviPozivBtn.Text = "Novi poziv";
            this.noviPozivBtn.UseVisualStyleBackColor = true;
            this.noviPozivBtn.Click += new System.EventHandler(this.noviPozivBtn_Click);
            // 
            // ZvanjeUGrupuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 205);
            this.Controls.Add(this.noviPozivBtn);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.pozoviBtn);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNapomena);
            this.helpProvider.SetHelpKeyword(this, "Clanovi grupe");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "ZvanjeUGrupuForm";
            this.helpProvider.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Poziv u grupu";
            this.Load += new System.EventHandler(this.ZvanjeUGrupuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Button pozoviBtn;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.Button btnNatrag;
        public System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button noviPozivBtn;
    }
}