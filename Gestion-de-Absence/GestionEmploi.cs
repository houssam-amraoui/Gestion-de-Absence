using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gestion_de_Absence.model;
using System.Configuration;

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
        }

        private void btnEmAjouter_Click(object sender, EventArgs e)
        {
            if (cbJour.SelectedIndex == -1 || comboBox1.SelectedIndex == -1 || txtActivite.Text == "")
            {
                label3.Text = "Vieullez remplir les champs !!";
                label3.ForeColor = Color.Red;

            }
            else if (Utils.isVide(cbJour.SelectedIndex, comboBox1.SelectedIndex, dgvEmploiTemps))
            {

                BaseDonneeConnecter.addEnregistremment(grop.SelectedItem.ToString(), (cbJour.SelectedIndex + 1) + "", (comboBox1.SelectedIndex + 1) + "", txtActivite.Text);
                grop_SelectedIndexChanged(null, null);
                txtActivite.Clear();
                label3.Text = "Ajoutation reussite";
                label3.ForeColor = Color.Green;
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
            if (Utils.isVide(cbJour.SelectedIndex, comboBox1.SelectedIndex,dgvEmploiTemps))
            {
                label3.Text = "Cette Eregestrement est Deja vide !!";
                label3.ForeColor = Color.Red;
            }
            else
            {
                BaseDonneeConnecter.deleteEnregestrempent(grop.SelectedItem.ToString(), (cbJour.SelectedIndex + 1) + "", (comboBox1.SelectedIndex + 1) + "");
                grop_SelectedIndexChanged(null, null);
                label3.Text = "Supprission reussite";
                label3.ForeColor = Color.Green;
            }
        }
    }
}
