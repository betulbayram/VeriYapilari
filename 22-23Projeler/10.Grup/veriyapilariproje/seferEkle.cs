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
    public partial class seferEkle : Form
    {
        public seferEkle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AVLTree aVLTree = new AVLTree();
            Tour tour = new Tour();
            
            tour.ID = Convert.ToInt32(idtxt.Text);
            tour.dt = Convert.ToDateTime(dttxt.Text);
            tour.placeOfDeparture =kalkis.Text;
            tour.placeOfArrival = varis.Text;
            tour.cost = Convert.ToDouble(ucrettxt.Text);
            aVLTree.Add(tour);
            aVLTree.SaveTourInformation();
            

            sefer p = new sefer();
            this.Hide();
            p.Show();
        }

        private void seferEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
