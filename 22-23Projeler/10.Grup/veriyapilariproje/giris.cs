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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string mail = textBox1.Text;
            string sifre = textBox2.Text;

            if(mail.Equals("a") && sifre.Equals("aa")) {
                islem islem = new islem();
                islem.Show(); 
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                this.Close();
            }
            this.Hide();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiUnuttum sifremiUnuttum = new sifremiUnuttum();

            sifremiUnuttum.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
