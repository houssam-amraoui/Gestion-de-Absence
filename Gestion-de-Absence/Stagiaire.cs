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
    }
    }
