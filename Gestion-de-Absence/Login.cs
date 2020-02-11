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
            string nameusers = "select nameusers from users";
            SqlCommand com2 = new SqlCommand(nameusers, BaseDonnee.connection);
            string priorite = "select priorite from users";
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
               nameusers=(string)dr2["nameusers"];
            }
            dr2.Close();

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
    }
}
