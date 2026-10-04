namespace AplikasiCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblOperasi = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperasi
            // 
            this.lblOperasi.AutoSize = true;
            this.lblOperasi.Location = new System.Drawing.Point(20, 25);
            this.lblOperasi.Name = "lblOperasi";
            this.lblOperasi.Text = "Operasi";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 75);
            this.lblA.Name = "lblA";
            this.lblA.Text = "Nilai A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 110);
            this.lblB.Name = "lblB";
            this.lblB.Text = "Nilai B";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(20, 145);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Text = "Hasil";
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbOperasi.Location = new System.Drawing.Point(85, 22);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(135, 21);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(85, 72);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(135, 20);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(85, 107);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(135, 20);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(85, 142);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.ReadOnly = true;
            this.txtHasil.Size = new System.Drawing.Size(135, 20);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(110, 175);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(100, 25);
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnHitung;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 215);
            this.Controls.Add(this.lblOperasi);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnHitung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblOperasi;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.ComboBox cmbOperasi;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}