namespace Nogometni_planer
{
    partial class Prijava
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
            this.labelKorIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textBoxKorIme = new System.Windows.Forms.TextBox();
            this.prijavaBtn = new System.Windows.Forms.Button();
            this.registrirajBtn = new System.Windows.Forms.Button();
            this.izlazBtn = new System.Windows.Forms.Button();
            this.labelPrijava = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKorIme
            // 
            this.labelKorIme.AutoSize = true;
            this.labelKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorIme.Location = new System.Drawing.Point(56, 137);
            this.labelKorIme.Name = "labelKorIme";
            this.labelKorIme.Size = new System.Drawing.Size(103, 17);
            this.labelKorIme.TabIndex = 0;
            this.labelKorIme.Text = "Korisničko ime:";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLozinka.Location = new System.Drawing.Point(98, 182);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(61, 17);
            this.labelLozinka.TabIndex = 0;
            this.labelLozinka.Text = "Lozinka:";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(200, 179);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.PasswordChar = '*';
            this.textBoxLozinka.Size = new System.Drawing.Size(177, 20);
            this.textBoxLozinka.TabIndex = 1;
            // 
            // textBoxKorIme
            // 
            this.textBoxKorIme.Location = new System.Drawing.Point(200, 134);
            this.textBoxKorIme.Name = "textBoxKorIme";
            this.textBoxKorIme.Size = new System.Drawing.Size(177, 20);
            this.textBoxKorIme.TabIndex = 1;
            // 
            // prijavaBtn
            // 
            this.prijavaBtn.Location = new System.Drawing.Point(283, 242);
            this.prijavaBtn.Name = "prijavaBtn";
            this.prijavaBtn.Size = new System.Drawing.Size(94, 28);
            this.prijavaBtn.TabIndex = 2;
            this.prijavaBtn.Text = "Prijava";
            this.prijavaBtn.UseVisualStyleBackColor = true;
            this.prijavaBtn.Click += new System.EventHandler(this.prijavaBtn_Click);
            // 
            // registrirajBtn
            // 
            this.registrirajBtn.Location = new System.Drawing.Point(131, 242);
            this.registrirajBtn.Name = "registrirajBtn";
            this.registrirajBtn.Size = new System.Drawing.Size(94, 28);
            this.registrirajBtn.TabIndex = 2;
            this.registrirajBtn.Text = "Registracija";
            this.registrirajBtn.UseVisualStyleBackColor = true;
            this.registrirajBtn.Click += new System.EventHandler(this.registracijaBtn_Click);
            // 
            // izlazBtn
            // 
            this.izlazBtn.Location = new System.Drawing.Point(387, 319);
            this.izlazBtn.Name = "izlazBtn";
            this.izlazBtn.Size = new System.Drawing.Size(94, 28);
            this.izlazBtn.TabIndex = 3;
            this.izlazBtn.Text = "Izlaz";
            this.izlazBtn.UseVisualStyleBackColor = true;
            this.izlazBtn.Click += new System.EventHandler(this.izlazBtn_Click);
            // 
            // labelPrijava
            // 
            this.labelPrijava.AutoSize = true;
            this.labelPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrijava.Location = new System.Drawing.Point(203, 31);
            this.labelPrijava.Name = "labelPrijava";
            this.labelPrijava.Size = new System.Drawing.Size(122, 39);
            this.labelPrijava.TabIndex = 4;
            this.labelPrijava.Text = "Prijava";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 361);
            this.Controls.Add(this.labelPrijava);
            this.Controls.Add(this.izlazBtn);
            this.Controls.Add(this.registrirajBtn);
            this.Controls.Add(this.prijavaBtn);
            this.Controls.Add(this.textBoxKorIme);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorIme);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nogometni planer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKorIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBoxKorIme;
        private System.Windows.Forms.Button prijavaBtn;
        private System.Windows.Forms.Button registrirajBtn;
        private System.Windows.Forms.Button izlazBtn;
        private System.Windows.Forms.Label labelPrijava;
    }
}

