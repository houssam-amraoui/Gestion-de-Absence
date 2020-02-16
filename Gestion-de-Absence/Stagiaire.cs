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

namespace Gestion_de_Absence
{
    public partial class Stagiaire : Form
    {
        BindingSource bs;
        int conteur = -1;
        bool op;
        string sql;

        public Stagiaire()
        {
            InitializeComponent();
        }

        private void Stagiaire_Load(object sender, EventArgs e)
        {
          
            bs = BaseDonnee.RemplirListControl(lsStagiaire, "Stagiaire", "name", "idstagiaire");
            txtIdStagiaire.DataBindings.Add("text", bs, "idstagiaire");
            txtNum.DataBindings.Add("text", bs, "numstagiaire");
            txtNom.DataBindings.Add("text", bs, "name");
            txtCin.DataBindings.Add("text", bs, "cin");
        }

        private void btnSAjouter_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            txtIdStagiaire.Text = conteur + "";
            Utils.activecom(false, pnSModification, pnSValidation, pnSNavigation, pnSZoneText);
            sql = "insert into stagiaire(numStagiaire,name,cin) values (";
            op = true;
        }

        private void btnSModifier_Click(object sender, EventArgs e)
        {
            Utils.activecom(false, pnSModification, pnSValidation, pnSNavigation, pnSZoneText);
            sql = "update Stagiaire set numStagiaire =";
            op = false;
        }

        private void btnSValider_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Equals("") || txtNom.Text.Equals("") || txtCin.Text.Equals(""))
            {
                MessageBox.Show("Vieullez remplir les champs de texte svp !!", "Invertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                if (op == true)
                {
                  BaseDonnee.exec(sql + txtNum.Text + ",'" + txtNom.Text + "','" + txtCin.Text + "')");
                    
                }
                else
                {
                    BaseDonnee.exec(sql + txtNum.Text + " name ='" + txtNom.Text + "',cin='" + txtCin.Text + "' where idstagiaire="+txtIdStagiaire.Text);
                    
                }
                bs.EndEdit();
                BaseDonnee.remplirTable("Stagiaire");
                Utils.activecom(true, pnSModification, pnSValidation, pnSNavigation, pnSZoneText);
                    
                conteur--;
               

            }
        }

        private void btnSAnnuler_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            Utils.activecom(true, pnSModification, pnSValidation, pnSNavigation, pnSZoneText);
        }

        private void btnSChercher_Click(object sender, EventArgs e)
        {
            bs.Filter = "name like '%" + txtChercher.Text + "%'";
        }

        private void txtChercher_TextChanged(object sender, EventArgs e)
        {
            btnSChercher.PerformClick();
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

        private void btnSSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer se Stagiaire ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                sql = "delete from Stagiaire where idstagiaire=" + txtIdStagiaire.Text;
                BaseDonnee.exec(sql);
                bs.RemoveCurrent();

            }

        }
    }
}
