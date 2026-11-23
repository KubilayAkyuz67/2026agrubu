using System.Drawing.Printing;

namespace _2026agrubu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvUrunler.Columns.Add("ad", "Ürün");
            dgvUrunler.Columns.Add("adet", "Adet");
            dgvUrunler.Columns.Add("fiyat", "Fiyat");
            dgvUrunler.Columns.Add("tutar", "Tutar");
            dgvUrunler.AllowUserToAddRows = false;

            btnEkle.Click -= btnEkle_Click;
            btnEkle.Click += btnEkle_Click;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(txtAdet.Text);
            decimal fiyat = decimal.Parse(txtFiyat.Text);


            dgvUrunler.Rows.Add(txtUrunAd.Text, adet, fiyat, adet * fiyat);
            /*
            txtUrunAd.Clear();
            txtAdet.Clear();
            txtFiyat.Clear();
            txtUrunAd.Focus();*/
        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            dgvUrunler.Rows.Clear();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font baslik = new Font("Arial", 22, FontStyle.Bold);
            Font yazi = new Font("Arial", 14);
            decimal toplam = 0;
            int y = 250;

            e.Graphics.DrawString("FATURA", baslik, Brushes.Black, 100, 100);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToShortDateString(), yazi, Brushes.Black, 100, 160);
            e.Graphics.DrawString("Müþteri: " + txtMusteri.Text, yazi, Brushes.Black, 100, 190);

            foreach (DataGridViewRow satir in dgvUrunler.Rows)
            {
                e.Graphics.DrawString(satir.Cells[0].Value.ToString(), yazi, Brushes.Black, 100, y);
                e.Graphics.DrawString(satir.Cells[1].Value.ToString(), yazi, Brushes.Black, 350, y);
                e.Graphics.DrawString(satir.Cells[2].Value + " TL", yazi, Brushes.Black, 450, y);
                e.Graphics.DrawString(satir.Cells[3].Value + " TL", yazi, Brushes.Black, 600, y);

                toplam += Convert.ToDecimal(satir.Cells[3].Value);
                y += 30;
            }

            e.Graphics.DrawString("Genel Toplam: " + toplam + " TL", baslik, Brushes.Black, 100, y + 20);
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {

        }
    }
}