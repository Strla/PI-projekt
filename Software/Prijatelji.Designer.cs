namespace Nogometni_planer
{
    partial class Prijatelji
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
            this.listBoxPrijatelji = new System.Windows.Forms.ListBox();
            this.labelPrijatelji = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKorIme = new System.Windows.Forms.TextBox();
            this.buttonDodajPrijatelja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPrijatelji
            // 
            this.listBoxPrijatelji.FormattingEnabled = true;
            this.listBoxPrijatelji.Location = new System.Drawing.Point(109, 191);
            this.listBoxPrijatelji.Name = "listBoxPrijatelji";
            this.listBoxPrijatelji.Size = new System.Drawing.Size(173, 251);
            this.listBoxPrijatelji.TabIndex = 0;
            this.listBoxPrijatelji.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxPrijatelji_MouseDown);
            // 
            // labelPrijatelji
            // 
            this.labelPrijatelji.AutoSize = true;
            this.labelPrijatelji.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrijatelji.Location = new System.Drawing.Point(118, 20);
            this.labelPrijatelji.Name = "labelPrijatelji";
            this.labelPrijatelji.Size = new System.Drawing.Size(138, 39);
            this.labelPrijatelji.TabIndex = 1;
            this.labelPrijatelji.Text = "Prijatelji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime:";
            // 
            // textBoxKorIme
            // 
            this.textBoxKorIme.Location = new System.Drawing.Point(157, 87);
            this.textBoxKorIme.Name = "textBoxKorIme";
            this.textBoxKorIme.Size = new System.Drawing.Size(125, 20);
            this.textBoxKorIme.TabIndex = 3;
            // 
            // buttonDodajPrijatelja
            // 
            this.buttonDodajPrijatelja.Location = new System.Drawing.Point(191, 141);
            this.buttonDodajPrijatelja.Name = "buttonDodajPrijatelja";
            this.buttonDodajPrijatelja.Size = new System.Drawing.Size(91, 23);
            this.buttonDodajPrijatelja.TabIndex = 4;
            this.buttonDodajPrijatelja.Text = "Dodaj prijatelja";
            this.buttonDodajPrijatelja.UseVisualStyleBackColor = true;
            this.buttonDodajPrijatelja.Click += new System.EventHandler(this.buttonDodajPrijatelja_Click);
            // 
            // Prijatelji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 479);
            this.Controls.Add(this.buttonDodajPrijatelja);
            this.Controls.Add(this.textBoxKorIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrijatelji);
            this.Controls.Add(this.listBoxPrijatelji);
            this.Name = "Prijatelji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prijatelji";
            this.Load += new System.EventHandler(this.Prijatelji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPrijatelji;
        private System.Windows.Forms.Label labelPrijatelji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKorIme;
        private System.Windows.Forms.Button buttonDodajPrijatelja;
    }
}