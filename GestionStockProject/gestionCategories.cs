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
    public partial class gestionCategories : Form
    {
        
        public gestionCategories()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(nomText.Text);
            item.SubItems.Add(codeText.Text);
            item.SubItems.Add(descriptionText.Text);
            listView1.Items.Add(item);
            clearData();
            MessageBox.Show("Catégorie ajoutée avec succes ");


        }
        private void clearData()
        {
           nomText.Text="";
           codeText.Text = "";
           descriptionText.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show("Catégorie supprimée avec succes ");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GestionStock form = new GestionStock();
            form.Show();
        }

    }
}
