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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Profilim");
            comboBox1.Items.Add("Bildirimler");
            comboBox1.Items.Add("Yardım\nDestek");
            comboBox1.Items.Add("Ayarlar");
            comboBox1.Items.Add("Çıkış");
        }
    }
}
