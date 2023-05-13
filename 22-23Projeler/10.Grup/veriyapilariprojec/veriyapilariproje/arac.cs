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
    public partial class arac : Form
    {
        public arac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracEkle aracEkle = new aracEkle();
            aracEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracSil aracSil = new AracSil();
            aracSil.Show();
        }
    }
}
