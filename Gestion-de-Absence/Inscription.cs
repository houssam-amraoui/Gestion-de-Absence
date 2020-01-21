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
        }
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (txtAnneScholaire.Text.Equals(""))
            {
                txtAnneScholaire.Text = DateTime.Today.Year + "";
                Utils.activecom2(true, cbGroupe, pnModification, pnValidation, pnNouveautie, pnNavigation);
            }
            else
                Utils.activecom2(true, cbGroupe, pnModification, pnValidation, pnNouveautie, pnNavigation);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bsInscription.CancelEdit();
            Utils.activecom2(false, cbGroupe, pnModification, pnValidation, pnNouveautie, pnNavigation);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous supprimer cette Insription ?","Supprission",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            bsInscription.RemoveCurrent();
            
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if (cbGroupe.SelectedIndex == -1)
                MessageBox.Show("Vieullez remplir les champs", "Invertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bsInscription.EndEdit();
            Utils.activecom2(false, cbGroupe, pnModification, pnValidation, pnNouveautie, pnNavigation);
        }
        string sql;
        private void Inscription_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Enregestrez les modification ?", "Enregestrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (cbGroupe.Text.Equals(""))
                {
                    sql = "insert into incription (idstagiaire,idgroupe,annee) values(" + txtidStagiaire.Text + "," + cbGroupe.SelectedValue + "," + txtAnneScholaire.Text + ")";
                    //MessageBox.Show(sql);
                    BaseDonnee.exec(sql);
                }
                else
                {
                    sql = "update incription set idstagiaire=" + txtidStagiaire.Text + ",idgroupe=" + cbGroupe.SelectedValue + ",annee=" + txtAnneScholaire.Text + "";
                   // MessageBox.Show(sql);
                    BaseDonnee.exec(sql);
                }
        }
    }
}
