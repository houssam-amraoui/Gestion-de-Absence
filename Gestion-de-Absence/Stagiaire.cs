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
    public partial class Stagiaire : Form
    {
        BindingSource bs;
        BindingSource bs2;
        public Stagiaire()
        {
            InitializeComponent();
        }

        private void Stagiaire_Load(object sender, EventArgs e)
        {
            bs2 = model.BaseDonnee.RemplirListControl(cbGroupe, "Groupe", "nomgroupe", "idgroupe");
           bs = model.BaseDonnee.remplirListeRel(lsStagiaire, "Stagiaire", "name", "idstagiaire", "Groupe", "idgroupe", "idgroupe",bs2);
           txtIdStagiaire.DataBindings.Add("text", bs, "idstagiaire");
           txtNum.DataBindings.Add("text", bs, "numStagiaire");
            txtNom.DataBindings.Add("text", bs, "name");
            txtCin.DataBindings.Add("text", bs, "cin");
            txtIDgroupe.DataBindings.Add("text", bs2, "idgroupe");
            txtGroupe.DataBindings.Add("text", bs2, "nomgroupe");
        }

        private void btnGAjouter_Click(object sender, EventArgs e)
        {
            bs2.AddNew();
            pnGModification.Visible = false;
            pnGValidation.Visible = true;
            pnGroupe.Visible = true;
            pnSNavigation.Enabled = false;
        }

        private void btnGModifier_Click(object sender, EventArgs e)
        {
            pnGroupe.Visible = true;
            pnGModification.Visible = false;
            pnGValidation.Visible = true;
            pnSNavigation.Enabled = false;
        }

        private void btnGSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("voulez-vous supprimer ce groupe", "Supprission", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bs2.RemoveCurrent();
            }
        }

        private void btnGAnnuler_Click(object sender, EventArgs e)
        {
            bs2.CancelEdit();
            pnGModification.Visible = true;
            pnGroupe.Visible = false;
            pnGValidation.Visible = false;
            pnSNavigation.Enabled = true;
        }

        private void btnGValider_Click(object sender, EventArgs e)
        {
            if(txtIDgroupe.Text.Equals("") || txtGroupe.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir les champs", "Champ vide", MessageBoxButtons.OK);
            }
            else
            {
                bs2.EndEdit();
                pnGModification.Visible = true;
                pnGroupe.Visible = false;
                pnGValidation.Visible = false;
            }
        }

        private void btnSAjouter_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            pnSZoneText.Enabled = true;
            pnSNavigation.Enabled = false;
            pnSModification.Visible = false;
            pnSValidation.Visible = true;
        }

        private void btnSSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous supprimer ce groupe", "Supprission", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bs.RemoveCurrent();
            }
        }

        private void btnSAnnuler_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            pnSModification.Visible = true;
            pnSZoneText.Enabled = false;
            pnSValidation.Visible = false;
            pnSNavigation.Enabled = true;
        }

        private void btnSModifier_Click(object sender, EventArgs e)
        {
            pnSZoneText.Enabled = true;
            pnSModification.Visible = false;
            pnSValidation.Visible = true;
            pnSNavigation.Enabled = false;
        }

        private void btnSValider_Click(object sender, EventArgs e)
        {
            if (txtIdStagiaire.Text.Equals("") || txtNum.Text.Equals("") || txtNom.Text.Equals("") || txtCin.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir les champs", "Champ vide", MessageBoxButtons.OK);
            }
            else
            {
                bs.EndEdit();
                pnSModification.Visible = true;
                pnSZoneText.Enabled = false;
                pnSValidation.Visible = false;
            }
        }

        private void btnSLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btnSPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnSNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnSFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnSChercher_Click(object sender, EventArgs e)
        {
            bs.Filter = "name like '%" + txtChercher.Text + "%'";
        }

        private void txtChercher_TextChanged(object sender, EventArgs e)
        {
            btnSChercher.PerformClick();
        }
    }
    }
