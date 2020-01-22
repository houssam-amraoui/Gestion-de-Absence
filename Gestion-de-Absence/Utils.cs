﻿using Gestion_de_Absence.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Gestion_de_Absence
{
     class Utils
    {
       static List<Jour> j = new List<Jour>();
        static string[] tabjour = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };

        public static void rempli_liste(ComboBox l)
        {
            j = BaseDonneeConnecter.getJourFromGroupe(l.SelectedItem.ToString());
        }

        public  static void show_liste(DataGridView g)
        {

            claer(g);
            for (int i = 0; i < j.Count; i++)
            {
                Jour jo = j[i];
                //dgvEmploiTemps.Rows.Insert(i,tabjour[Convert.ToInt32(jo.jour)-1]);
                foreach (TimeRegistre tm in jo.tmr)
                {
                    g.Rows[jo.jour - 1].Cells[tm.timestart].Value = tm.text;
                }
            }
        }
        public static void claer( DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Rows.Add("Lundi");
            dgv.Rows.Add("Mardi");
            dgv.Rows.Add("Mercredi");
            dgv.Rows.Add("Jeudi");
            dgv.Rows.Add("Vendredi");
            dgv.Rows.Add("Samedi");
        }
        public static Boolean isVide(int numjour, int jourpreriod,DataGridView g)
        {
            try
            {
                return g.Rows[numjour].Cells[jourpreriod + 1].Value + "" == "";
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public static void activecom(bool v,Panel p1, Panel p2, Panel p3,Panel p4)
        {
            p1.Visible = v;
            p2.Visible = !v;
            p3.Enabled = v;
            p4.Enabled = !v;
        }

        public static void activecom2(bool l,ComboBox b, Panel p1, Panel p2, Panel p3, Panel p4)
        {
            b.Enabled = l;
            p1.Visible = !l;
            p2.Visible = l;
            p3.Visible = !l;
            p4.Enabled = !l;
        }
        public static bool operation(string op)
        {
            if (op == "a")
            {

                return true;
            }

            return false;
        }

    }
}
