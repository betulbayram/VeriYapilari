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
    public partial class aracEkle : Form
    {
        public aracEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araclar.AracProgram aracProgram = new Araclar.AracProgram();
            Araclar.İkiYönlüListe listeee = new Araclar.İkiYönlüListe();
            Araclar.AracProgram.ReadCsvFile(listeee);
            listeee.Ekle(Convert.ToInt32( idtxt.Text),plakatxt.Text, markatxt.Text, modeltxt.Text, aturutxt.Text, Convert.ToInt32(uyilitxt.Text), Convert.ToInt32(ksayisitxt.Text), klimabox.CheckState == CheckState.Checked, wifibox.CheckState == CheckState.Checked);
            Araclar.AracProgram.WriteCsvFile(listeee);
            Araclar.AracProgram.ReadCsvFile(listeee);
            arac arac = new arac();
            arac.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void klimabox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void wifibox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aracEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
