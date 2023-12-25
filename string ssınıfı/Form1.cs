using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_ssınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnKucult_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToLower();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            string mesaj=$"toplama {lblMesaj.Text.Length}\nkarekter vardır";
            MessageBox.Show(mesaj);
        }

        private void btnBuyuk_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToUpper();
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            lblMesaj.Text=$"merhaba dunya ben,Ben\n{txtMesaj.Text}";
        }

        private void btnMetniBirlestir_Click(object sender, EventArgs e)
        {
            string mesaj1 = "merhaba Dunya";
            string mesaj2 = "ben ilayda";
            string yeniMesaj = string.Concat(mesaj1, mesaj2);
           lblMesaj.Text=yeniMesaj;
        }

        private void btnİstedigisıradakharf_Click(object sender, EventArgs e)
        {
            string mesaj=lblMesaj.Text;
            MessageBox.Show($"6.sıradaki harf{mesaj[5]}");
        }

        private void btnKacıs_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba ben \"ilayda;\"\rNasılsın";
            lblMesaj.Text = mesaj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim1 = "ilayda";
            string isim2 = "ilayda";
            string isim3 = "sema";

            bool durum1 = isim1.Equals(isim3);
            bool durum2 = isim1 == isim2;

            bool durum3 = isim3.Equals(isim1);
            bool durum4 = isim1 == isim2;




        }

        private void btnBicim_Click(object sender, EventArgs e)
        {
            int a = 20;
            int b = 20;
            int c = 100;
            string mesaj = $"{a}*{b}={c}";
            MessageBox.Show(mesaj);

        }

        private void btncompare_Click(object sender, EventArgs e)
        {
            string isim1 =  "Rabia";
            string isim2 =  "Rabia";
            string isim3 = "Ayse";
            string isim4=  "zeynep";
            string isim5 = "rabia";


            int sonuc1 = string.Compare(isim1, isim2);
            int sonuc2 = string.Compare(isim1, isim3);
            int sonuc3 = string.Compare(isim1, isim4);
            int sonuc4 = string.Compare(isim1, isim5);


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string mesaj1 = lblMesaj.Text.Remove(7);
            string mesaj2 = lblMesaj.Text.Remove(0, 4);

            MessageBox.Show(mesaj1);
            MessageBox.Show(mesaj2);
        }
    }
}
