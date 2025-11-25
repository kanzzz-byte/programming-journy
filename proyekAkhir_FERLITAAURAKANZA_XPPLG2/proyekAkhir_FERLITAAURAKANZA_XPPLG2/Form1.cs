namespace proyekAkhir_FERLITAAURAKANZA_XPPLG2
{
    public partial class Form1 : Form
    {
        private readonly object lblTota;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (cbBanna.Checked) total += 26000;
            if (cbBelgi.Checked) total += 20000;
            if (cbChoco.Checked) total += 3000;
            if (cbCoff.Checked) total += 15000;
            if (cbCookies.Checked) total += 13000;
            if (cbKacang.Checked) total += 2000;
            if (cbLatt.Checked) total += 15000;
            if (cbMacci.Checked) total += 19000;
            if (cbMarsh.Checked) total += 3000;
            if (cbMilk.Checked) total += 23000;
            if (cbMint.Checked) total += 18000;
            if (cbOreo.Checked) total += 4000;
            if (cbRainbow.Checked) total += 27000;
            if (cbRain.Checked) total += 5000;
            if (cbSoda.Checked) total += 16000;
            if (cbTaro.Checked) total += 16000;
            if (cbTea.Checked) total += 13000;
            if (cbTripel.Checked) total += 30000;
            if (cbVanilla.Checked) total += 10000;
            if (cbWa.Checked) total += 28000;
            if (cbWffle.Checked) total += 26000;

            lblTotal.Text = $"{total}";
        }

        private void btnBatalkan_Click(object sender, EventArgs e)
        {
            // membatalkan semua pilihan
            cbBanna.Checked = false;
            cbBelgi.Checked = false;
            cbChoco.Checked = false;
            cbCoff.Checked = false;
            cbCookies.Checked = false;
            cbKacang.Checked = false;
            cbLatt.Checked = false;
            cbMacci.Checked = false;
            cbMarsh.Checked = false;
            cbMilk.Checked = false;
            cbMint.Checked = false;
            cbOreo.Checked = false;
            cbRainbow.Checked = false;
            cbRain.Checked = false;
            cbSoda.Checked = false;
            cbTaro.Checked = false;
            cbTea.Checked = false;
            cbTripel.Checked = false;
            cbVanilla.Checked = false;
            cbWa.Checked = false;
            cbWffle.Checked = false;
            lblTotal.Text = "0";
            Bayar.Text = "0";
            txtKembalian.Text = "0";








        }

        private void label6_Click(object sender, EventArgs e)
        {
            // menghitung kembalian
            //if (!string.IsNullOrEmpty(lblTotal.Text) && !string.IsNullOrEmpty(tbTotalPembayaran.Text))
            //{
            // int bayar = Convert.ToInt32(tbTotalPembayaran.Text);
            //  int Total = Convert.ToInt32(lblTotal.Text);
            //  int kembalian = bayar - Total;
            //  MessageBox.Show("Kembalian Anda : Rp." + kembalian.ToString());
            // }


        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void tbTotalPembayaran_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {







        }

        private void Bayar_TextChanged(object sender, EventArgs e)
        {
            // mmasukkan unag pembayaran dan menghitung kembalian
            if (!string.IsNullOrEmpty(lblTotal.Text) && !string.IsNullOrEmpty(tbTotalPembayaran.Text) && !string.IsNullOrEmpty(Bayar.Text))
            {
                int bayar = Convert.ToInt32(Bayar.Text);
                //int Total = Convert.ToInt32(lblTotal.Text);
                int kembalian = bayar - Convert.ToInt32(lblTotal.Text);
                // MessageBox.Show("Kembalian Anda: Rp." + kembalian.ToString());
                txtKembalian.Text = $"{kembalian}";
                // menampilkan kembalian pada txtKembalian





            }


        }

        private void btBayar_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari TextBox
            double btnHitung = double.Parse(lblTotal.Text);
            double tbTotalPembayaran = double.Parse(Bayar.Text);

            // Hitung kembalian
            double kembalian = tbTotalPembayaran - btnHitung;

            if (kembalian < 0)
            {
                MessageBox.Show("Uang Anda kurang, tidak bisa dibayar!!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Biar makin chill, balik lagi ya !! Thank you for visiting !!\nkembalian:Rp " + kembalian,
                        "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }
    }
}
