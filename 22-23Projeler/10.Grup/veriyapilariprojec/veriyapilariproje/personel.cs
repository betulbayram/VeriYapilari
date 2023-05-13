using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace veriyapilariproje
{
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelEkle personelEkle = new personelEkle();
            personelEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelSil personelSil = new personelSil();
            personelSil.Show();
        }

        string dosyayol;

        private void personel_Load(object sender, EventArgs e)
        {

      
        }

        private void label2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            dosyayol = "C:/Users/isog1/Downloads/test.csv";
            FileStream fileStream = new FileStream(dosyayol, FileMode.OpenOrCreate, FileAccess.Read);
            //dosyadan satır satır okuyup textBox içine yazıdırıyoruz
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (true)
                {
                    string satir = reader.ReadLine();
                    label2.Text += "\n"+satir + "\n";
                    if (satir == null) break;
                }
                reader.Close();
            }
            fileStream.Close();



        }
    }
}