namespace GestionStockProject
{
    partial class GestionProduit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProduit));
            this.label2 = new System.Windows.Forms.Label();
            this.Supprimer = new System.Windows.Forms.Button();
            this.listViewProduit = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ajouter = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.nomText = new System.Windows.Forms.TextBox();
            this.quantiteText = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.categorieText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codeText = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, -27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 27;
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(676, 46);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(109, 23);
            this.Supprimer.TabIndex = 26;
            this.Supprimer.TabStop = false;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // listViewProduit
            // 
            this.listViewProduit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewProduit.FullRowSelect = true;
            this.listViewProduit.GridLines = true;
            this.listViewProduit.Location = new System.Drawing.Point(275, 72);
            this.listViewProduit.Name = "listViewProduit";
            this.listViewProduit.Size = new System.Drawing.Size(484, 151);
            this.listViewProduit.TabIndex = 25;
            this.listViewProduit.UseCompatibleStateImageBehavior = false;
            this.listViewProduit.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Catégorie";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nom";
            this.columnHeader3.Width = 137;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(157, 223);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 24;
            this.Ajouter.TabStop = false;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(60, 223);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(75, 23);
            this.Annuler.TabIndex = 23;
            this.Annuler.TabStop = false;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(106, 129);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(100, 20);
            this.nomText.TabIndex = 22;
            // 
            // quantiteText
            // 
            this.quantiteText.Location = new System.Drawing.Point(132, 159);
            this.quantiteText.Name = "quantiteText";
            this.quantiteText.Size = new System.Drawing.Size(100, 20);
            this.quantiteText.TabIndex = 20;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(28, 162);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(55, 13);
            this.description.TabIndex = 19;
            this.description.Text = "Quantité";
            // 
            // categorieText
            // 
            this.categorieText.Location = new System.Drawing.Point(106, 72);
            this.categorieText.Name = "categorieText";
            this.categorieText.Size = new System.Drawing.Size(100, 20);
            this.categorieText.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Catégorie";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.descriptionText);
            this.groupBox1.Controls.Add(this.listViewProduit);
            this.groupBox1.Controls.Add(this.codeText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nomText);
            this.groupBox1.Controls.Add(this.Code);
            this.groupBox1.Controls.Add(this.categorieText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 283);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des Produits";
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(106, 103);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(100, 20);
            this.codeText.TabIndex = 30;
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(31, 110);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(36, 13);
            this.Code.TabIndex = 21;
            this.Code.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Description";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(106, 181);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(100, 20);
            this.descriptionText.TabIndex = 32;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qantité";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 142;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.quantiteText);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionProduit";
            this.Text = "GestionProduit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.ListView listViewProduit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.TextBox quantiteText;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox categorieText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
    }
}