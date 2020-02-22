using Gestion_de_Absence;
using Gestion_de_Absence.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_de_Absence
{
    public partial class Home : Form
    {
        public static string nameusers;
        public static int priorite;
        bool isjust;

        DateTime usingDate;
        int usingTimeStart;
        int usingNumjour;

        public Home(string name,int prio)
        {
            InitializeComponent();
            nameusers = name;
           priorite = prio;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            refreachTime();
            label1.Text =DateTime.Today.ToString("d");
            label3.Text = nameusers;
            foreach (string ss in BaseDonneeConnecter.getGroupes())
            {
                cbGroupe.Items.Add(ss);
            }
            cbGroupe.SelectedIndex = 0;
 

        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (priorite == 2 || priorite == 0)
            {
                isjust = true;
                Inscription s = new Inscription();
                s.ShowDialog();
                update();
            }
            else
            {
                isjust = false;
                MessageBox.Show("Cette action est reservie au d'autre fonction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void cbGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();

        }
        private void loadAbsense() {
            lsAbsence.Items.Clear();
            List<string> aa = BaseDonneeConnecter.getAbsenseInRealeTime(usingDate, usingNumjour.ToString(), cbGroupe.SelectedItem.ToString(),usingTimeStart.ToString()); 
            foreach (string ss in aa) {
                lsAbsence.Items.Add(ss);
            } 
        }
        private void loadNotAbsense()
        {
            lsPresence.Items.Clear();
            List<string> aa = BaseDonneeConnecter.getNotAbsenseInRealeTime(usingDate, usingNumjour.ToString(), cbGroupe.SelectedItem.ToString(), usingTimeStart.ToString());
            foreach (string ss in aa)
            {
                lsPresence.Items.Add(ss);
            }
        }

        private void empt_Click(object sender, EventArgs e)
        {
            if (priorite == 1 || priorite == 0)
            {
                isjust = true;
                GestionEmploi s = new GestionEmploi();
                s.ShowDialog();
                update();
            }
            else
            {
                isjust = false;
                MessageBox.Show("Cette action est reservie au d'autre fonction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(lsPresence.SelectedItem != null) { 
            BaseDonneeConnecter.addAbsenseInRealeTime(lsPresence.SelectedItem.ToString(),usingDate, usingNumjour.ToString(), cbGroupe.SelectedItem.ToString(), usingTimeStart.ToString());
            loadAbsense();
            loadNotAbsense();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lsAbsence.SelectedItem != null) { 
                BaseDonneeConnecter.remouveAbsenseInRealeTime(lsAbsence.SelectedItem.ToString(), usingDate, usingNumjour.ToString(), cbGroupe.SelectedItem.ToString(), usingTimeStart.ToString());
                loadAbsense();
                loadNotAbsense();
            }
        }

        private void update() {
            Utils.rempli_liste(cbGroupe);
            Utils.show_liste(dgvEmploiGroupe);
             dgvEmploiGroupe.Rows[usingNumjour - 1].Cells[usingTimeStart].Style.BackColor = System.Drawing.Color.Gold;
            if (Utils.isVide(usingNumjour - 1, usingTimeStart - 1, dgvEmploiGroupe))
                panelabs.Enabled = false;
            else
                panelabs.Enabled = true;
            loadAbsense();
            loadNotAbsense();

        }
        private void refreachTime()
        {
            usingDate= DateTime.Now;
            usingNumjour = Utils.getnumjour(usingDate);
            usingTimeStart = Utils.getTimeStart(usingDate);
        }

       

        private void cb1_date_Changed(object sender, EventArgs e)
        {
            usingDate = Picker1.Value;
            usingNumjour = Utils.getnumjour(usingDate);
            usingTimeStart = cb1.SelectedIndex+1;
            update();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (priorite == 2 || priorite == 0)
            {
                panel1.Enabled = checkBox1.Checked;
                cb1.SelectedIndex = 0;
            }
            else
            {

                MessageBox.Show("Cette action est reservie au d'autre fonction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ref1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            refreachTime();
            update();

        }
    }
}