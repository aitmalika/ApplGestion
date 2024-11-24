using ApplGestion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplGestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttAfficher_Click(object sender, EventArgs e)
        {
            GestionCommande db = new GestionCommande();
            dataGridView1.DataSource = db.client.ToList();
            
        }

        private void buttajouter_Click(object sender, EventArgs e)
        {
            GestionCommande db = new GestionCommande();
            client c = new client()
            {
                CIN = textCIN.Text,
                Nom = textNOM.Text,
                Prenom = textPrenom.Text,
                Ville = textVILLE.Text,
                Telephone = textTELE.Text
            };
            db.client.Add(c);
            db.SaveChanges();
            MessageBox.Show("client ajouté avec succés");
        }
        private void buttModifier_Click(object sender, EventArgs e)
        {
            GestionCommande db = new GestionCommande();
            client c = db.client.FirstOrDefault(x => x.CIN == textCIN.Text);
            if (c != null)
            {

                c.Nom = textNOM.Text;
                c.Prenom = textPrenom.Text;
                c.Ville = textVILLE.Text;
                c.Telephone = textTELE.Text;
                db.SaveChanges();
                MessageBox.Show("le client a été modifié avec succés");

            }
            else
            {
                MessageBox.Show("client non trouvé");
            }
            


        }

        private void buttSupp_Click(object sender, EventArgs e)
        {
            GestionCommande db = new GestionCommande();
            client c = db.client.FirstOrDefault(x => x.CIN == textCIN.Text);
            if (c != null)
            {
                db.client.Remove(c);
                db.SaveChanges();
                MessageBox.Show("le client a été supprimé avec succés");
            }
            else
            {
                MessageBox.Show("client non trouvé");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
