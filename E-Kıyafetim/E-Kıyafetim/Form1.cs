using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Kıyafetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Bedenler = { "S", "M", "L", "XL" };
        string[] Markalar = { "LWC", "Koton", "Zara", "Mavi", "Nike", "Adidas", "Sarar", "Levis", "Puma", "Ramsey" };
        string[] Turler = { "Pantolon", "Etek", "Gömlek", "Elbise", "Takım Elbise", "Ayakkabı", "Kazak", "T-Shirt" };
        private void Form1_Load(object sender, EventArgs e)
        {

            cmbBeden.Items.AddRange(Bedenler);
            cmbBeden.Items.Insert(0, "Beden Seçiniz");
            cmbMarka.Items.AddRange(Markalar);
            cmbMarka.Items.Insert(0, "Marka Seçiniz");
            cmbTur.Items.AddRange(Turler);
            cmbTur.Items.Insert(0, "Tür Seçiniz");

            cmbBeden.SelectedIndex = cmbMarka.SelectedIndex = cmbTur.SelectedIndex = 0;

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            yeniSiparis = new Siparis();
            yeniSiparis.Beden = cmbBeden.SelectedItem.ToString();
            yeniSiparis.Marka = cmbMarka.SelectedItem.ToString();
            yeniSiparis.Tur = cmbTur.SelectedItem.ToString();

            yeniSiparis.Sezon = rbYazlik.Checked == true ? "Yazlık" : "Kışlık";

            string _renkler = "";

            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    _renkler += item.Text + ",";

                }
            }
            yeniSiparis.Renkler = _renkler.Substring(0, _renkler.Length - 1);

            yeniSiparis.Adet = Convert.ToInt32(nudAdet.Value);

            lblTutar.Text = string.Format("Tutar: {0} TL", yeniSiparis.AraToplam);

        }
        Siparis yeniSiparis = null;
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (yeniSiparis == null)
            {
                MessageBox.Show("Önce Bir Sipariş Oluşturunuz Ve Hesaplatınız!");
                return;
            }
            listBox1.Items.Add(yeniSiparis);
            yeniSiparis = null;
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            decimal toplamsiparistutari = 0;
            foreach (Siparis item in listBox1.Items)
            {
                toplamsiparistutari += item.AraToplam;
            }
            lblToplamTutar.Text = "Toplam Tutar: " + toplamsiparistutari.ToString("C2");
        }
    }
}
