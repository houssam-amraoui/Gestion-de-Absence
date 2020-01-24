using Gestion_de_Absence.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Gestion_de_Absence
{
     class Utils
    {
       static List<Jour> jours = new List<Jour>();
        static string[] tabjour = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };

        public static void rempli_liste(ComboBox l)
        {
            jours = BaseDonneeConnecter.getJourFromGroupe(l.SelectedItem.ToString());
        }
        public  static void show_liste(DataGridView g)
        {

            clear(g);
            for (int i = 0; i < jours.Count; i++)
            {
                Jour jo = jours[i];
                //dgvEmploiTemps.Rows.Insert(i,tabjour[Convert.ToInt32(jo.jour)-1]);
                foreach (TimeRegistre tm in jo.tmr)
                {
                    g.Rows[jo.jour - 1].Cells[tm.timestart].Value = tm.text;
                }
            }
        }
        public static void clear( DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach(string a in tabjour)
            dgv.Rows.Add(a);
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

        public static int getTimeStart() {
           // Jour j = jours[getnumjour()];
            int aa=int.Parse( DateTime.Now.ToString("hhmm"));
            if (aa > 0830 && aa < 1100)
                return 1;
            if (aa > 1100 && aa < 1330)
                return 2;
            if (aa > 1330 && aa < 1600)
                return 3;
            if (aa > 1600 && aa < 1830)
                return 4;

            return -1;
        }
        public static int getnumjour()
        {
            DayOfWeek a= DateTime.Now.DayOfWeek;
            int ss =(int)a;
            return ss;
        }

    }
}
