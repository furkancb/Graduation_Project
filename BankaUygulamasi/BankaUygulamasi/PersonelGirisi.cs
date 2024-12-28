using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaUygulamasi
{
    public partial class PersonelGirisi : Form
    {
        public PersonelGirisi()
        {
            InitializeComponent();
        }

        private string RastgeleKarakterOlustur(int uzunluk)
        {
            const string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random rnd = new Random();
            char[] dizi = new char[uzunluk];

            for (int i = 0; i < uzunluk; i++)
            {
                dizi[i] = karakterler[rnd.Next(karakterler.Length)];
            }

            return new string(dizi);
        }
        private void PersonelGirisi_Load(object sender, EventArgs e)
        {
            lblKontrol.Text = RastgeleKarakterOlustur(5);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var eslesme = txtKontrol.Text;

            if (txtKontrol.Text == lblKontrol.Text)
            {

            }
        }
    }
}
