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
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelSil personelSil = new personelSil();
            personelSil.Show();
            this.Hide();
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
                   // label2.Text += "\n"+satir + "\n";
                    if (satir == null) break;
                }
                reader.Close();
            }
            fileStream.Close();



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void persnlgoster_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            VeriGonder(textBox1.Text);
        }
        private void VeriGonder(string filePath)
        {
            DataTable dt = new DataTable();
            string[] satirlar = System.IO.File.ReadAllLines(filePath);
            if (satirlar.Length > 0)
            {
                //ilk satır başlık satırımız
                string ilkSatir = satirlar[0];
                string[] basliklar = ilkSatir.Split(',');
                foreach (string baslik in basliklar)
                {
                    dt.Columns.Add(new DataColumn(baslik));
                }
                //Veriler için kodlarımız
                for (int i = 1; i < satirlar.Length; i++)
                {
                    string[] veriler = satirlar[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string veri in basliklar)
                    {
                        dr[veri] = veriler[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}