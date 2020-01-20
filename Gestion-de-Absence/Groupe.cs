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
    public partial class Groupe : Form
    {
        BindingSource bs;
        int conteur2 = -1;
        public Groupe()
        {
            InitializeComponent();
        }

        private void Groupe_Load(object sender, EventArgs e)
        {
            bs = BaseDonnee.RemplirListControl(cbGroupe, "Groupe", "nomgroupe", "idgroupe");
            txtIdgroupe.DataBindings.Add("text", bs, "idgroupe");
            txtGroupe.DataBindings.Add("text", bs, "nomgroupe");
        }

        private void btnGAjouter_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            Utils.activecom(false, pnGModification, pnGValidation, pnGNavigation, pnGZoneTexte);
            txtIdgroupe.Text = conteur2 + "";
        }

        private void btnGModifier_Click(object sender, EventArgs e)
        {
            Utils.activecom(false, pnGModification, pnGValidation, pnGNavigation, pnGZoneTexte);
        }

        private void btnGSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraimment supprimer ce Groupe ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bs.RemoveCurrent();
        }

        private void btnGValider_Click(object sender, EventArgs e)
        {
            if (txtGroupe.Text.Equals(""))
                MessageBox.Show("vieullez remplir les champs de texte svp !!", "Invertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bs.EndEdit();
                Utils.activecom(true, pnGModification, pnGValidation, pnGNavigation, pnGZoneTexte);
               conteur2--;
            }
        }

        private void btnGAnnuler_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            Utils.activecom(true, pnGModification, pnGValidation, pnGNavigation, pnGZoneTexte);
        }

        private void Groupe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("voulez-vous enregestrez les Modifiction ?", "Eregestrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                BaseDonnee.syncroniser("Groupe");
        }
    }
}
