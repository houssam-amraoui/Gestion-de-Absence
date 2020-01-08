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
        
        
        List<Jour> j = new List<Jour>();
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
            /* dgvEmploiTemps.Rows.Add("Lundi");
             dgvEmploiTemps.Rows.Add("Mardi");
             dgvEmploiTemps.Rows.Add("Mercredi");
             dgvEmploiTemps.Rows.Add("Jeudi");
             dgvEmploiTemps.Rows.Add("Vendredi");
             dgvEmploiTemps.Rows.Add("Samedi");*/



        }

        private void btnEmAjouter_Click(object sender, EventArgs e)
        {
         //  dgvEmploiTemps.
        }

       

        private void rempli_liste()
        {
            j = BaseDonneeConnecter.getJourFromGroupe(grop.SelectedItem.ToString());
        }

        public void show_liste()
        {
            for(int i=0;i<j.Count;i++)
            {
                Jour jo = j[i];
                dgvEmploiTemps.Rows.Insert(i,jo.jour);
                foreach (TimeRegistre tm in jo.tmr) {
                    dgvEmploiTemps.Rows[i].Cells[tm.timestart].Value = tm.text;
                        }
            }

        }

        private void grop_SelectedIndexChanged(object sender, EventArgs e)
        {
            rempli_liste();
            show_liste();
        }

      
    }
}
