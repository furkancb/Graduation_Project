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
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            YoneticiGirisi yntc = new YoneticiGirisi();
            yntc.Show();
            this.Hide();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            PersonelGirisi yntc = new PersonelGirisi();
            yntc.Show();
            this.Hide();
        }

        private void girisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
