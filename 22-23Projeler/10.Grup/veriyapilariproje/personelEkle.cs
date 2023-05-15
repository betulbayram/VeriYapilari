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
    public partial class personelEkle : Form
    {
        public personelEkle()
        {
            InitializeComponent();
        }

        private void personelEklebtn_Click(object sender, EventArgs e)
        {
            
            personel p = new personel();/*
            Personeller.HashTable table = new Personeller.HashTable();

            Personeller.MyObject hash1 = new Personeller.MyObject((Convert.ToInt32(idtxt.Text), isimtxt.Text, soyisim.Text, Convert.ToInt32(yas.Text), teltxt.Text, gorevtxt));
            table.Add(hash1);*/
            PersonelTablosu personel = new PersonelTablosu();
            personel.PersonelEkle((Convert.ToInt32(idtxt.Text), isimtxt.Text, soyisim.Text, Convert.ToInt32(yas.Text), teltxt.Text, gorevtxt.Text));
            this.Hide();
            p.Show();
            
        }

        private void personelEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
