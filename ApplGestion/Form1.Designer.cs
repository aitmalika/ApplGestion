namespace ApplGestion
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttAfficher = new System.Windows.Forms.Button();
            this.buttajouter = new System.Windows.Forms.Button();
            this.textCIN = new System.Windows.Forms.TextBox();
            this.textNOM = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textVILLE = new System.Windows.Forms.TextBox();
            this.textTELE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttModifier = new System.Windows.Forms.Button();
            this.buttSupp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttAfficher
            // 
            this.buttAfficher.Location = new System.Drawing.Point(598, 17);
            this.buttAfficher.Name = "buttAfficher";
            this.buttAfficher.Size = new System.Drawing.Size(89, 36);
            this.buttAfficher.TabIndex = 1;
            this.buttAfficher.Text = "Afficher";
            this.buttAfficher.UseVisualStyleBackColor = true;
            this.buttAfficher.Click += new System.EventHandler(this.buttAfficher_Click);
            // 
            // buttajouter
            // 
            this.buttajouter.Location = new System.Drawing.Point(598, 68);
            this.buttajouter.Name = "buttajouter";
            this.buttajouter.Size = new System.Drawing.Size(89, 36);
            this.buttajouter.TabIndex = 2;
            this.buttajouter.Text = "Ajouter";
            this.buttajouter.UseVisualStyleBackColor = true;
            this.buttajouter.Click += new System.EventHandler(this.buttajouter_Click);
            // 
            // textCIN
            // 
            this.textCIN.Location = new System.Drawing.Point(191, 22);
            this.textCIN.Name = "textCIN";
            this.textCIN.Size = new System.Drawing.Size(307, 20);
            this.textCIN.TabIndex = 3;
            // 
            // textNOM
            // 
            this.textNOM.Location = new System.Drawing.Point(191, 65);
            this.textNOM.Name = "textNOM";
            this.textNOM.Size = new System.Drawing.Size(307, 20);
            this.textNOM.TabIndex = 4;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(191, 99);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(307, 20);
            this.textPrenom.TabIndex = 5;
            // 
            // textVILLE
            // 
            this.textVILLE.Location = new System.Drawing.Point(191, 144);
            this.textVILLE.Name = "textVILLE";
            this.textVILLE.Size = new System.Drawing.Size(307, 20);
            this.textVILLE.TabIndex = 6;
            // 
            // textTELE
            // 
            this.textTELE.Location = new System.Drawing.Point(191, 184);
            this.textTELE.Name = "textTELE";
            this.textTELE.Size = new System.Drawing.Size(307, 20);
            this.textTELE.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "PRENOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "VILLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "TELEPHONE";
            // 
            // buttModifier
            // 
            this.buttModifier.Location = new System.Drawing.Point(598, 124);
            this.buttModifier.Name = "buttModifier";
            this.buttModifier.Size = new System.Drawing.Size(89, 36);
            this.buttModifier.TabIndex = 13;
            this.buttModifier.Text = "Modifier";
            this.buttModifier.UseVisualStyleBackColor = true;
            this.buttModifier.Click += new System.EventHandler(this.buttModifier_Click);
            // 
            // buttSupp
            // 
            this.buttSupp.Location = new System.Drawing.Point(598, 175);
            this.buttSupp.Name = "buttSupp";
            this.buttSupp.Size = new System.Drawing.Size(89, 36);
            this.buttSupp.TabIndex = 14;
            this.buttSupp.Text = "Supprimer";
            this.buttSupp.UseVisualStyleBackColor = true;
            this.buttSupp.Click += new System.EventHandler(this.buttSupp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttSupp);
            this.Controls.Add(this.buttModifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTELE);
            this.Controls.Add(this.textVILLE);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNOM);
            this.Controls.Add(this.textCIN);
            this.Controls.Add(this.buttajouter);
            this.Controls.Add(this.buttAfficher);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttAfficher;
        private System.Windows.Forms.Button buttajouter;
        private System.Windows.Forms.TextBox textCIN;
        private System.Windows.Forms.TextBox textNOM;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textVILLE;
        private System.Windows.Forms.TextBox textTELE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttModifier;
        private System.Windows.Forms.Button buttSupp;
    }
}

