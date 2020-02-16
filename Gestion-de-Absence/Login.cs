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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCnx_Click(object sender, EventArgs e)
        {
            BaseDonnee.ouvrirConnection();
            //nameusers and priorite
            string nameusers = "select nameusers from users where login ='" + txtLogin.Text + "' and password ='" + txtPassword.Text + "'";
            SqlCommand com2 = new SqlCommand(nameusers, BaseDonnee.connection);
            int priorite = 0;
            SqlCommand com3 = new SqlCommand("select priorite from users where login ='" + txtLogin.Text + "' and password ='" + txtPassword.Text + "'", BaseDonnee.connection);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
               nameusers=(string)dr2["nameusers"];
            }
            dr2.Close();
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                priorite = (int)dr3["priorite"];
            }
            dr3.Close();

            //Login
            string sql = "select * from users where login ='" + txtLogin.Text + "' and password ='" + txtPassword.Text + "'";
            SqlCommand com = new SqlCommand(sql, BaseDonnee.connection);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                
                Home h = new Home(nameusers,priorite);
                h.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login ou le mot de passe sont Incorrect !!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Inscription u = new User_Inscription();
            u.Show();
        }
    }
}
