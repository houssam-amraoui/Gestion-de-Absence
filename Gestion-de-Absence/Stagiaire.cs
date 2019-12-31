using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_Absence
{
    public partial class Stagiaire : Form
    {
        BindingSource bs;
        BindingSource bs2;
        int conteur = -1;
        int conteur2 = -1;
        string sql;
        private bool operation(string op)
        {
            if (op == "a")
            {
              string  sql = "insert into Stagiaire (numStagiaire, name, cin,idgroupe) values (";
                return true;
            }
            return false;
        }
        public Stagiaire()
        {
            InitializeComponent();
        }

        private void Stagiaire_Load(object sender, EventArgs e)
        {
            bs2 =model.BaseDonnee.RemplirListControl(cbGroupe, "Groupe", "nomgroupe", "idgroupe");
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
            sql = "insert into Groupe (nomgroupe) values ('";
            pnGModification.Visible = false;
            pnGValidation.Visible = true;
            pnGroupe.Enabled = true;
            pnSNavigation.Enabled = false;
            txtIDgroupe.Text =conteur+"";
           
        }

        private void btnGModifier_Click(object sender, EventArgs e)
        {
             pnGroupe.Enabled = true;
             pnGModification.Visible = false;
             pnGValidation.Visible = true;
             pnSNavigation.Enabled = false;
            //Correction de la recette
            sql = "Update  Groupe set nomgroupe = '";
        }

        private void btnGSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("voulez-vous supprimer ce groupe", "Supprission", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
               bs2.RemoveCurrent();
                model.BaseDonnee.syncroniser("Groupe");
               


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
               // MessageBox.Show(sql + txtGroupe.Text + "' where idgroupe=" + txtIDgroupe.Text);
                pnGModification.Visible = true;
                pnGroupe.Enabled = false;
                pnGValidation.Visible = false;
                conteur--;
               model.BaseDonnee.exec(sql + txtGroupe.Text +"' where idgroupe="+txtIDgroupe.Text);
                 sql = null;
                
                
            }
        }

        private void btnSAjouter_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            pnSZoneText.Enabled = true;
            pnSNavigation.Enabled = false;
            pnSModification.Visible = false;
            pnSValidation.Visible = true;
            txtIdStagiaire.Text = conteur2 + "";
           sql= "insert into Stagiaire (numStagiaire, name, cin,idgroupe) values (";
        }

        private void btnSSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous supprimer ce groupe", "Supprission", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bs.RemoveCurrent();
                model.BaseDonnee.syncroniser("Stagiaire");
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
            sql = "Update  Stagiaire set numStagiaire = ";
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
                pnSNavigation.Enabled = true;
                conteur2--;
                if (!operation("a"))
                {
                    model.BaseDonnee.exec(sql + txtNum.Text + ", name= '" + txtNom.Text.Replace("'", "''") + "', cin='" + txtCin.Text + "',idgroupe=" + txtIDgroupe.Text + " where idstagiaire=" + txtIdStagiaire.Text);
                    sql = null;
                }
                else
                   // MessageBox.Show(sql + txtNum.Text + ",'" + txtNom.Text + "','" + txtCin.Text + "'," + txtIDgroupe.Text + ")");
                   model.BaseDonnee.exec(sql + txtNum.Text + ",'" + txtNom.Text + "','" + txtCin.Text + "'," + txtIDgroupe.Text + ")");
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
