namespace ApplGestion
{
    partial class formProduitEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProduitEdit));
            this.btnfermer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRefProduit = new System.Windows.Forms.TextBox();
            this.textIntitule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCategorie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrixVente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Enregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnfermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfermer
            // 
            this.btnfermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfermer.Image = ((System.Drawing.Image)(resources.GetObject("btnfermer.Image")));
            this.btnfermer.Location = new System.Drawing.Point(432, 0);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(33, 33);
            this.btnfermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfermer.TabIndex = 0;
            this.btnfermer.TabStop = false;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nouveau produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Refproduit";
            // 
            // textRefProduit
            // 
            this.textRefProduit.Location = new System.Drawing.Point(115, 79);
            this.textRefProduit.Name = "textRefProduit";
            this.textRefProduit.Size = new System.Drawing.Size(160, 26);
            this.textRefProduit.TabIndex = 6;
            // 
            // textIntitule
            // 
            this.textIntitule.Location = new System.Drawing.Point(115, 125);
            this.textIntitule.Name = "textIntitule";
            this.textIntitule.Size = new System.Drawing.Size(160, 26);
            this.textIntitule.TabIndex = 8;
            this.textIntitule.TextChanged += new System.EventHandler(this.textIntitule_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Intitule";
            // 
            // textCategorie
            // 
            this.textCategorie.Location = new System.Drawing.Point(115, 177);
            this.textCategorie.Name = "textCategorie";
            this.textCategorie.Size = new System.Drawing.Size(160, 26);
            this.textCategorie.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categorie";
            // 
            // textPrixVente
            // 
            this.textPrixVente.Location = new System.Drawing.Point(115, 222);
            this.textPrixVente.Name = "textPrixVente";
            this.textPrixVente.Size = new System.Drawing.Size(160, 26);
            this.textPrixVente.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "PrixVente";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 209);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enregistrer.FlatAppearance.BorderSize = 0;
            this.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enregistrer.Image = ((System.Drawing.Image)(resources.GetObject("Enregistrer.Image")));
            this.Enregistrer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Enregistrer.Location = new System.Drawing.Point(139, 272);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(195, 50);
            this.Enregistrer.TabIndex = 14;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // formProduitEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 334);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.textPrixVente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textIntitule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRefProduit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formProduitEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProduit";
            this.Load += new System.EventHandler(this.formProduitEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnfermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnfermer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRefProduit;
        private System.Windows.Forms.TextBox textIntitule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrixVente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Enregistrer;
    }
}