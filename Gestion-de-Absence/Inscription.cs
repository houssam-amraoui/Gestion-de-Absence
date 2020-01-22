using Gestion_de_Absence.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Gestion_de_Absence
{
    public partial class Inscription : Form
    {
        string sql = null;

        DataSet ds = new DataSet();
        SqlCommand comStagiaire = new SqlCommand();
        SqlCommand comGroupe = new SqlCommand();
        SqlCommand comInscription = new SqlCommand();

        SqlDataAdapter daStagiaire;
        SqlDataAdapter daGroupe;
        SqlDataAdapter daInscription;

        BindingSource bsStagiaire = new BindingSource();
        BindingSource bsGroupe = new BindingSource();
        BindingSource bsInscription = new BindingSource();

        SqlCommandBuilder cb;
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            BaseDonnee.ouvrirConnection();
            comStagiaire.CommandText = "select * from Stagiaire";
            comGroupe.CommandText = "select * from Groupe";
            comInscription.CommandText = "select * from incription";

            comStagiaire.Connection = BaseDonnee.connection;
            comGroupe.Connection = BaseDonnee.connection;
            comInscription.Connection = BaseDonnee.connection;


            daStagiaire = new SqlDataAdapter(comStagiaire);
            daGroupe = new SqlDataAdapter(comGroupe);
            daInscription = new SqlDataAdapter(comInscription);


            daStagiaire.Fill(ds, "Stagiaire");
            daGroupe.Fill(ds, "Groupe");
            daInscription.Fill(ds, "incription");

            cb = new SqlCommandBuilder(daInscription);

            DataColumn c1 = ds.Tables["Groupe"].Columns["idgroupe"];
            DataColumn c2 = ds.Tables["incription"].Columns["idgroupe"];


            DataColumn c3 = ds.Tables["Stagiaire"].Columns["idstagiaire"];
            DataColumn c4 = ds.Tables["incription"].Columns["idstagiaire"];


            DataRelation r1 = new DataRelation("fk_Groupe_incription", c1, c2);
            DataRelation r2 = new DataRelation("fk_Stagiaire_incription", c3, c4);


            ds.Relations.Add(r1);
            ds.Relations.Add(r2);


            bsGroupe.DataSource = ds;
            bsGroupe.DataMember = "Groupe";

            bsStagiaire.DataSource = ds;
            bsStagiaire.DataMember = "Stagiaire";

            bsInscription.DataSource = bsStagiaire;
            bsInscription.DataMember = "fk_Stagiaire_incription";



            lsStagiaire.DataSource = bsStagiaire;
            lsStagiaire.DisplayMember = "name";
            lsStagiaire.ValueMember = "idstagiaire";

            cbGroupe.DataSource = bsGroupe;
            cbGroupe.DisplayMember = "nomgroupe";
            cbGroupe.ValueMember = "idgroupe";

            txtidStagiaire.DataBindings.Add("text", bsStagiaire, "idstagiaire");
            txtName.DataBindings.Add("text", bsStagiaire, "name");
            cbGroupe.DataBindings.Add("selectedvalue", bsInscription, "idgroupe");
            txtAnneScholaire.DataBindings.Add("text", bsInscription, "annee");

        }

        private void btnStagiaire_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.ShowDialog();
            Application.Restart();


        }

        private void btnGroupe_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.ShowDialog();
            Application.Restart();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (cbGroupe.Text.Equals("") || txtAnneScholaire.Text.Equals(""))
            {
                bsInscription.AddNew();
                txtAnneScholaire.Text = DateTime.Today.Year + "";
                Utils.activecom2(true, cbGroupe, pnModification, pnValidation, pnNouveautie, pnNavigation);
                sql = "insert into incription (idstagiaire,idgroupe,annee) values(";

            }
            else
            {
                MessageBox.Show("Si Vous voulez Modifier vieullez clicker sur le button modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Utils.activecom2(true, cbGroupe, pnModification, pnValidation, pnNouveautie, pnNavigation);
            sql = "update incription set idstagiaire=";

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bsInscription.CancelEdit();
            Utils.activecom2(false, cbGroupe, pnModification, pnValidation, pnNouveautie, pnNavigation);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous supprimer cette Insription ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                bsInscription.RemoveCurrent();
            sql = "delete from incription where idstagiaire =" + txtidStagiaire.Text + "";
            MessageBox.Show(sql);

        }
        private void btnvalider_Click(object sender, EventArgs e)
        {
            if (cbGroupe.SelectedIndex == -1)
            {
                MessageBox.Show("Vieullez remplir les champs", "Invertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bsInscription.EndEdit();
                Utils.activecom2(false, cbGroupe, pnModification, pnValidation, pnNouveautie, pnNavigation);
            }

                if (!Utils.operation("a"))
                {
                MessageBox.Show(sql + txtidStagiaire.Text + " ,idgroupe =" + cbGroupe.SelectedValue + " ,annee =" + txtAnneScholaire.Text + " where idstagiaire=" + txtidStagiaire.Text);
                sql = null;
            }
                MessageBox.Show(sql + txtidStagiaire.Text + "," + cbGroupe.SelectedValue + "," + txtAnneScholaire.Text + ")");
                sql = null;
            

        }
    }
}
