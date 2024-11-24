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
using System.Data.SqlTypes;

namespace ApplGestion
{
    public partial class formProduitEdit : Form
    {
        private Produit Produit;
        private int Refproduit;
        public formProduitEdit()
        {
            InitializeComponent();
        }
        public formProduitEdit(Produit produit)
        {
            InitializeComponent();
            this.Produit= produit;
        }
        public formProduitEdit(int Refproduit, Produit produit)
        {
            InitializeComponent();
            this.Refproduit = Refproduit;
            this.Produit = produit;
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

    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            using (GestionCommande db = new GestionCommande())
            {
                if (this.Refproduit != 0)

                {
                    ApplGestion.Models.Produit pd = db.Produit.FirstOrDefault(x => x.Refproduit == this.Refproduit);
                    //ApplGestion.Models.Produit produit = new ApplGestion.Models.Produit
                    {
                        //RefProduit = textRefProduit.Text,
                        pd.Intitule = textIntitule.Text;
                        pd.Categorie = textCategorie.Text;
                        pd.PrixVente = decimal.Parse(textPrixVente.Text);
                    };
                    try
                    {
                        //db.Produit.Add(pd);
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

        private void formProduitEdit_Load(object sender, EventArgs e)
        {
            
                GestionCommande db = new GestionCommande();
                ApplGestion.Models.Produit pd = db.Produit.FirstOrDefault(x => x.Refproduit == this.Refproduit);
                if (pd != null)
                {
                    textIntitule.Text = pd.Intitule;
                    textCategorie.Text = pd.Categorie;
                    textPrixVente.Text = pd.PrixVente.ToString();
                }
                else
                {
                    MessageBox.Show("Produit introuvable.");
                }
            
        }
    }
}
