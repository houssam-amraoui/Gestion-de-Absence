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
        bool op;
        string sql;
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
            sql = "insert into Groupe (nomgroupe) values('";
            op = true;
        }

        private void btnGModifier_Click(object sender, EventArgs e)
        {
            Utils.activecom(false, pnGModification, pnGValidation, pnGNavigation, pnGZoneTexte);
            sql = "update Groupe set nomgroupe='";
            op = false;
        }

        private void btnGSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraimment supprimer ce Groupe ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bs.RemoveCurrent();
            sql = "delete from Groupe where idgroupe=" + txtIdgroupe.Text + "";
            BaseDonnee.exec(sql);
        }

        private void btnGValider_Click(object sender, EventArgs e)
        {
            if (txtGroupe.Text.Equals(""))
                MessageBox.Show("vieullez remplir les champs de texte svp !!", "Invertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                bs.EndEdit();
                Utils.activecom(true, pnGModification, pnGValidation, pnGNavigation, pnGZoneTexte);
                if (op == true)
                {
                    BaseDonnee.exec(sql + txtGroupe.Text + "')");
                }
                else
                {
                    BaseDonnee.exec(sql + txtGroupe.Text + "'");
                }

                conteur2--;
            }
        }

        private void btnGAnnuler_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            Utils.activecom(true, pnGModification, pnGValidation, pnGNavigation, pnGZoneTexte);
        }
    }
}
