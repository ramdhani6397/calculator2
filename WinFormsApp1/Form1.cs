using System;
using System.Windows.Forms;

namespace AplikasiCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbOperasi.Text))
            {
                MessageBox.Show("Pilih operasi terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b))
            {
                MessageBox.Show("Nilai A dan Nilai B harus berupa angka.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double hasil;
            switch (cmbOperasi.Text)
            {
                case "Penambahan":
                    hasil = a + b;
                    break;
                case "Pengurangan":
                    hasil = a - b;
                    break;
                case "Perkalian":
                    hasil = a * b;
                    break;
                case "Pembagian":
                    if (b == 0)
                    {
                        MessageBox.Show("Pembagian dengan nol tidak diperbolehkan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    hasil = a / b;
                    break;
                default:
                    MessageBox.Show("Operasi tidak dikenal.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            txtHasil.Text = hasil.ToString();
        }
    }
}