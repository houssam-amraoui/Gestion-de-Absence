﻿using Gestion_de_Absence.model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Absence
{
    public partial class GestionEmploi : Form
    {

        public GestionEmploi()
        {
            InitializeComponent();
            // BaseDonnee.RemplirListControl(grop, "Groupe", "nomgroupe", "idgroupe");
         }

        private void GestionEmploi_Load(object sender, EventArgs e)
        {

            foreach (string ss in BaseDonneeConnecter.getGroupes())
            {
                grop.Items.Add(ss);
            }
            grop.SelectedIndex = 0;
            foreach (Users ss in BaseDonneeConnecter.getAllUsersinfo())
            {
                cbusers.Items.Add(ss.nameusers);
            }
            clearfild();

        }

        private void btnEmAjouter_Click(object sender, EventArgs e)
        {
            if (cbJour.SelectedIndex == -1 || cbtime.SelectedIndex == -1 || txtactivite.Text == "")
            {
                label3.Text = "Vieullez remplir les champs !!";
                label3.ForeColor = Color.Red;

            }
            else if (Utils.isVide(cbJour.SelectedIndex, cbtime.SelectedIndex, dgvEmploiTemps))
            {

                BaseDonneeConnecter.addSeance(grop.SelectedItem.ToString(), (cbJour.SelectedIndex + 1) , (cbtime.SelectedIndex + 1), txtactivite.Text,cbusers.SelectedItem.ToString(),txtsalle.Text);
                grop_SelectedIndexChanged(null, null);
                txtactivite.Clear();
                label3.Text = "Ajoutation reussite";
                label3.ForeColor = Color.Green;
                clearfild();
            }
            else {
                label3.Text = "Cette periode est Occupez vieullez selectionez une periode vide ou vider une preriode !!";
                label3.ForeColor = Color.Red;
                }
        }


        private void grop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.rempli_liste(grop);
            Utils.show_liste(dgvEmploiTemps);
        }

        private void btn_supr_Click(object sender, EventArgs e)
        {
            if (Utils.isVide(cbJour.SelectedIndex, cbtime.SelectedIndex,dgvEmploiTemps))
            {
                label3.Text = "Cette Eregestrement est Deja vide !!";
                label3.ForeColor = Color.Red;
            }
            else
            {
                BaseDonneeConnecter.deleteEnregestrempent(grop.SelectedItem.ToString(), (cbJour.SelectedIndex + 1) + "", (cbtime.SelectedIndex + 1) + "");
                grop_SelectedIndexChanged(null, null);
                label3.Text = "Supprission reussite";
                label3.ForeColor = Color.Green;
                clearfild();
            }
        }

        private void clearfild() {
            cbusers.SelectedIndex = -1;
            cbJour.SelectedIndex = -1;
            cbtime.SelectedIndex = -1;
            txtactivite.Clear();
            txtsalle.Clear();

        }
    }
}
