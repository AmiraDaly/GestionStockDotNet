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
    public partial class GestionProduit : Form
    {
        public GestionProduit()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(categorieText.Text);
            item.SubItems.Add(codeText.Text);
            item.SubItems.Add(nomText.Text);
            item.SubItems.Add(quantiteText.Text);
            item.SubItems.Add(descriptionText.Text);
            listViewProduit.Items.Add(item);
            clearData();
            MessageBox.Show("Produit ajouté avec succes ");
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            clearData();
        }
        private void clearData()
        {
            categorieText.Text = "";
            codeText.Text = "";
            nomText.Text = "";
            quantiteText.Text = "";
            descriptionText.Text = "";
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (listViewProduit.Items.Count > 0)
            {
                listViewProduit.Items.Remove(listViewProduit.SelectedItems[0]);
                MessageBox.Show("Produit supprimé avec succes ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionStock form = new GestionStock();
            form.Show();

        }
    }
}
