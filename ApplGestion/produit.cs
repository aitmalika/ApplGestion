using ApplGestion.Models;
using ApplGestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplGestion
{
    public partial class Produit : UserControl
    {
        internal string intitule;

        public int RefProduit { get; internal set; }
        public string Intitule { get; internal set; }
        public string Categorie { get; internal set; }
        public decimal PrixVente { get; internal set; }

        public Produit()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            using (GestionCommande db = new GestionCommande())
            {
                var list = db.Produit.Select(p => new
                {
                    Reference = p.Refproduit,
                    Intitule = p.Intitule,
                    categorie = p.Categorie,
                    prixvente = p.PrixVente
                }).ToList();
                if (!string.IsNullOrEmpty(textIntitule.Text))
                {
                    list = list.Where(x => x.Intitule.ToLower().Contains(textIntitule.Text.ToLower())).ToList();
                }
                dgvProduit.DataSource = list;
            }
            dgvProduit.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduit.AllowUserToOrderColumns = true;
            dgvProduit.AllowUserToResizeColumns = true;
        }
        private void Produit_Load(object sender, EventArgs e)
        {
            loadData();
            DataGridViewImageColumn btnEdit=new DataGridViewImageColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            btnEdit.Image = Properties.Resources.Edit;
            dgvProduit.Columns.Add(btnEdit);
            DataGridViewImageColumn btnDelete=new DataGridViewImageColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "";
            btnDelete.Image = Properties.Resources.Delete;
            dgvProduit.Columns.Add(btnDelete);
            dgvProduit.RowTemplate.Height = 30;
        }

        private void btNouveau_Click(object sender, EventArgs e)
        {
            formProduit fp = new formProduit(this);
            fp.ShowDialog();
        }
        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dgvProduit.Rows[index];
                row.Selected = true;
            }
        }

        private void dgvProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow rom = dgvProduit.Rows[index];
                int Refproduit = Convert.ToInt32(rom.Cells["Reference"].Value.ToString());
                formProduitEdit frmedit = new formProduitEdit(Refproduit, this);
                frmedit.ShowDialog();
            }
        }

        private void dgvProduit_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvProduit.Columns[e.ColumnIndex].Name;
            if(ColName != "btnEdit" && ColName != "btnDelete")
            {
                dgvProduit.Cursor = Cursors.Default;
            }
            else
            {
                dgvProduit.Cursor = Cursors.Hand;
            }
        }

        private void dgvProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvProduit.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvProduit.Rows[e.RowIndex];
            row.Selected = true;
            int Reference = Convert.ToInt32(row.Cells["Reference"].Value);
            string Categorie = row.Cells["Categorie"].Value.ToString();
            if (ColName == "btnEdit")
            {
                dgvProduit_CellContentDoubleClick(sender, e);
            }
            if (ColName == "btnDelete")
            {
                DialogResult dr = MessageBox.Show("voulez vous vraiement supprimer ce produit" + Categorie,
                    "confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if(dr==DialogResult.Yes)
                {
                    using(GestionCommande db=new GestionCommande())
                    {
                        ApplGestion.Models.Produit pd = db.Produit.FirstOrDefault(x => x.Refproduit == Reference);
                        db.Produit.Remove(pd);
                        db.SaveChanges();
                        loadData();
                    }
                }
            }
            
        }
        private void btnRecherche_Click_1(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
