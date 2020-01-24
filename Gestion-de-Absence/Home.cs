﻿using Gestion_de_Absence;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_de_Absence
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text =DateTime.Today.ToString("d");
            foreach (string ss in BaseDonneeConnecter.getGroupes())
            {
                cbGroupe.Items.Add(ss);
            }
            cbGroupe.SelectedIndex = 0;
            

        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.ShowDialog();
        }

        private void cbGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.rempli_liste(cbGroupe);
            Utils.show_liste(dgvEmploiGroupe);
            loadAbsense();
            loadNotAbsense();

        }
        private void loadAbsense() {
            lsAbsence.Items.Clear();
            List<string> aa = BaseDonneeConnecter.getAbsenseInRealeTime(DateTime.Now, Utils.getnumjour().ToString(), cbGroupe.SelectedItem.ToString(),Utils.getTimeStart().ToString()); 
            foreach (string ss in aa) {
                lsAbsence.Items.Add(ss);
            } 
        }
        private void loadNotAbsense()
        {
            lsPresence.Items.Clear();
            List<string> aa = BaseDonneeConnecter.getNotAbsenseInRealeTime(DateTime.Now, Utils.getnumjour().ToString(), cbGroupe.SelectedItem.ToString(), Utils.getTimeStart().ToString());
            foreach (string ss in aa)
            {
                lsPresence.Items.Add(ss);
            }
        }

        private void empt_Click(object sender, EventArgs e)
        {
            GestionEmploi s = new GestionEmploi();
            s.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(lsPresence.SelectedItem != null) { 
            BaseDonneeConnecter.addAbsenseInRealeTime(lsPresence.SelectedItem.ToString(),DateTime.Today, Utils.getnumjour().ToString(), cbGroupe.SelectedItem.ToString(), Utils.getTimeStart().ToString());
            loadAbsense();
            loadNotAbsense();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lsAbsence.SelectedItem != null) { 
                BaseDonneeConnecter.remouveAbsenseInRealeTime(lsAbsence.SelectedItem.ToString(), DateTime.Today, Utils.getnumjour().ToString(), cbGroupe.SelectedItem.ToString(), Utils.getTimeStart().ToString());
                loadAbsense();
                loadNotAbsense();
            }
        }
    }
}