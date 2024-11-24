using ApplGestion.Models;
using ApplGestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApplGestion
{
    public partial class formProduit : Form
    {
        private Produit Produit;
        public formProduit()
        {
            InitializeComponent();
        }
        public formProduit(Produit produit)
        {
            InitializeComponent();
            this.Produit= produit;
        }
        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.TextBox GetTextPrixVente()
        {
            return textPrixVente;
        }

        
        private void textIntitule_TextChanged(object sender, EventArgs e)
        {

        }

        private void formProduit_Load(object sender, EventArgs e)
        {
            GestionCommande db = new GestionCommande();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            using (GestionCommande db = new GestionCommande())
            {
                ApplGestion.Models.Produit produit = new ApplGestion.Models.Produit
                {
                    //Refproduit = textRefProduit.Text,
                    Intitule = textIntitule.Text,
                    Categorie = textCategorie.Text,
                    PrixVente = decimal.Parse(textPrixVente.Text),
                };
                try
                {
                    db.Produit.Add(produit);
                    db.SaveChanges();
                    MessageBox.Show("produit ajouté avec succès");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                }

            }
        }
    }
}
