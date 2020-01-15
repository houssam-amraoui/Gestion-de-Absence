using Gestion_de_Absence.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_Absence
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text =DateTime.Today.ToString("d");
            foreach (string ss in BaseDonneeConnecter.getGroupes())
            {
                cbGroupe.Items.Add(ss);
            }
            cbGroupe.SelectedIndex = 0;
            

        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.ShowDialog();
        }

        private void cbGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.rempli_liste(cbGroupe);
            Utils.show_liste(dgvEmploiGroupe);        
        }
    }
}