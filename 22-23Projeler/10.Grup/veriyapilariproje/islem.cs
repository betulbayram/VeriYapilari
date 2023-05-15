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
    public partial class islem : Form
    {
        public islem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arac arac = new arac();
            arac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sefer sefer = new sefer();
            sefer.Show();
        }

        private void CikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
