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
    public partial class User_Inscription : Form
    {
        int conteur = -1;
        public User_Inscription()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            txtId_Inscrire.Text = conteur + "";
            if(txtNameUsers.Text.Equals("") || txtMatiere.Text.Equals("") || txtLogin.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Vieullez remplir les champs de texte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BaseDonnee.exec("insert into users (nameusers,matiere,login,password,priorite) values('" + txtNameUsers.Text + "','" + txtMatiere.Text + "','" + txtLogin.Text + "','" + txtPassword.Text + "'," + (cbFonction.SelectedIndex+1) + ")");
                MessageBox.Show("Inscription Reussie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
