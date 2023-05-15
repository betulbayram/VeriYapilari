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
    public partial class seferSil : Form
    {
        public seferSil()
        {
            InitializeComponent();
        }

        private void seferSil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AVLTree aVLTree = new AVLTree();
            aVLTree.Delete(Convert.ToInt32(seferid.Text));
            aVLTree.SaveTourInformation();

            sefer s = new sefer();
            this.Hide();
            s.Show();
        }
    }
}
