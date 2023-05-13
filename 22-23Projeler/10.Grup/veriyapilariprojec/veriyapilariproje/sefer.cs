using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriyapilariproje
{
    public partial class sefer : Form
    {
        public sefer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void seferEkle_Click(object sender, EventArgs e)
        {
            seferEkle seferEkle = new seferEkle();
            seferEkle.Show();
        }

        private void seferSil_Click(object sender, EventArgs e)
        {
            seferSil seferSil = new seferSil();
            seferSil.Show();
        }
    }
}
