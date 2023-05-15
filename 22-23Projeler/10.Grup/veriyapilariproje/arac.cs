using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracSil aracSil = new AracSil();
            aracSil.Show();
            this.Hide();
        }

        private void arac_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void yuklemebtn_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gozatbtn_Click(object sender, EventArgs e)
        {
            dosyaacici.ShowDialog();
            csvLink.Text = dosyaacici.FileName;
            VeriGonder(csvLink.Text);
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
