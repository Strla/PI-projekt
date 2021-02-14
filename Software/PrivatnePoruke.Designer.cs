namespace Nogometni_planer
{
    partial class PrivatnePoruke
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
            this.textBoxPoruka = new System.Windows.Forms.TextBox();
            this.labelTikajPoruku = new System.Windows.Forms.Label();
            this.buttonPosalji = new System.Windows.Forms.Button();
            this.txtBoxPoruke = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxPoruka
            // 
            this.textBoxPoruka.Location = new System.Drawing.Point(47, 323);
            this.textBoxPoruka.Multiline = true;
            this.textBoxPoruka.Name = "textBoxPoruka";
            this.textBoxPoruka.Size = new System.Drawing.Size(548, 68);
            this.textBoxPoruka.TabIndex = 0;
            // 
            // labelTikajPoruku
            // 
            this.labelTikajPoruku.AutoSize = true;
            this.labelTikajPoruku.Location = new System.Drawing.Point(44, 307);
            this.labelTikajPoruku.Name = "labelTikajPoruku";
            this.labelTikajPoruku.Size = new System.Drawing.Size(107, 13);
            this.labelTikajPoruku.TabIndex = 1;
            this.labelTikajPoruku.Text = "Tipkaj poruku ovdje..";
            // 
            // buttonPosalji
            // 
            this.buttonPosalji.Location = new System.Drawing.Point(501, 410);
            this.buttonPosalji.Name = "buttonPosalji";
            this.buttonPosalji.Size = new System.Drawing.Size(94, 28);
            this.buttonPosalji.TabIndex = 2;
            this.buttonPosalji.Text = "Pošalji";
            this.buttonPosalji.UseVisualStyleBackColor = true;
            this.buttonPosalji.Click += new System.EventHandler(this.buttonPosalji_Click);
            // 
            // txtBoxPoruke
            // 
            this.txtBoxPoruke.Location = new System.Drawing.Point(47, 36);
            this.txtBoxPoruke.Name = "txtBoxPoruke";
            this.txtBoxPoruke.ReadOnly = true;
            this.txtBoxPoruke.Size = new System.Drawing.Size(548, 251);
            this.txtBoxPoruke.TabIndex = 3;
            this.txtBoxPoruke.Text = "";
            // 
            // PrivatnePoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.txtBoxPoruke);
            this.Controls.Add(this.buttonPosalji);
            this.Controls.Add(this.labelTikajPoruku);
            this.Controls.Add(this.textBoxPoruka);
            this.Name = "PrivatnePoruke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Privatne poruke";
            this.Load += new System.EventHandler(this.PrivatnePoruke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPoruka;
        private System.Windows.Forms.Label labelTikajPoruku;
        private System.Windows.Forms.Button buttonPosalji;
        private System.Windows.Forms.RichTextBox txtBoxPoruke;
    }
}