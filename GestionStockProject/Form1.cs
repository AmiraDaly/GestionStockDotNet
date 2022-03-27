using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionStockProject
{
    public partial class GestionStock : Form
    {
        public GestionStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void catégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDesCatégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionCategories gc = new gestionCategories();
            gc.Show();
        }

        private void gestionDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionProduit gp = new GestionProduit();
            gp.Show();
        }
    }
}
