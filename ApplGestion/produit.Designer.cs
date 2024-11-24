namespace ApplGestion
{
    partial class Produit
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produit));
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btNouveau = new System.Windows.Forms.Button();
            this.textIntitule = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduit
            // 
            this.dgvProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Location = new System.Drawing.Point(23, 61);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvProduit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.Size = new System.Drawing.Size(759, 238);
            this.dgvProduit.TabIndex = 0;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            this.dgvProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellContentClick);
            this.dgvProduit.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellContentDoubleClick);
            this.dgvProduit.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des produits";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btNouveau
            // 
            this.btNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNouveau.FlatAppearance.BorderSize = 0;
            this.btNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btNouveau.Image")));
            this.btNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNouveau.Location = new System.Drawing.Point(23, 298);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(184, 42);
            this.btNouveau.TabIndex = 3;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.UseVisualStyleBackColor = false;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // textIntitule
            // 
            this.textIntitule.Location = new System.Drawing.Point(402, 13);
            this.textIntitule.Name = "textIntitule";
            this.textIntitule.Size = new System.Drawing.Size(130, 26);
            this.textIntitule.TabIndex = 4;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecherche.FlatAppearance.BorderSize = 0;
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherche.Image = ((System.Drawing.Image)(resources.GetObject("btnRecherche.Image")));
            this.btnRecherche.Location = new System.Drawing.Point(558, 13);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(44, 30);
            this.btnRecherche.TabIndex = 5;
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click_1);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.textIntitule);
            this.Controls.Add(this.btNouveau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduit);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Produit";
            this.Size = new System.Drawing.Size(840, 340);
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.TextBox textIntitule;
        private System.Windows.Forms.Button btnRecherche;
    }
}
