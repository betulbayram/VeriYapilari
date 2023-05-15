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

        private void sefrgözat_Click(object sender, EventArgs e)
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
    }
}
