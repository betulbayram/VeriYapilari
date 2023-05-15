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
    public partial class AracSil : Form
    {
        



        public AracSil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            
             Araclar.AracProgram aracProgram = new Araclar.AracProgram();
             Araclar.İkiYönlüListe listeee = new Araclar.İkiYönlüListe();
             Araclar.AracProgram.ReadCsvFile(listeee);
             listeee.Sil(listeee, Convert.ToInt32(idtxtsil.Text));
             Araclar.AracProgram.WriteCsvFile(listeee);
             Araclar.AracProgram.ReadCsvFile(listeee);

            arac arac = new arac();
            arac.Show();
            this.Hide();
        }

        private void idtxtsil_TextChanged(object sender, EventArgs e)
        {

        }

        private void AracSil_Load(object sender, EventArgs e)
        {

        }
    }
}
