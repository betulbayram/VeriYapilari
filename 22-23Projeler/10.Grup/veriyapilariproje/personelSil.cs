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
    public partial class personelSil : Form
    {
        public personelSil()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel p = new personel();

            personeller.HashTable hash = new personeller.HashTable();

            hash.Remove (Convert.ToInt32(siltextbx.Text));

            this.Hide();
            p.Show();

        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void personelSil_Load(object sender, EventArgs e)
        {

        }
    }
}
