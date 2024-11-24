﻿using System;
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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void btnquiter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bnproduit_Click(sender, e);
        }

        private void btncommande_Click(object sender, EventArgs e)
        {

        }

        private void bnproduit_Click(object sender, EventArgs e)
        {
            Produit frmproduit = new Produit();
            frmproduit.Dock=DockStyle.Fill;
            pcontinuer.Controls.Clear();
            pcontinuer.Controls.Add(frmproduit);
        }
    }
}
