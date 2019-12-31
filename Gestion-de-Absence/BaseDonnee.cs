using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Gestion_de_Absence.model
{
   static class BaseDonnee
    {
      public static SqlConnection connection = new SqlConnection();
        static DataSet dataset = new DataSet();

        public static void ouvrirConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["Absence"].ToString();
                connection.Open();
            }
        }
        public static void fermerConnectio()
        {
            connection.Close();
        }
        public static void remplirTable(string t)
        {
            ouvrirConnection();
            SqlDataAdapter dataAdapte = new SqlDataAdapter("select * from " + t, connection);
            if (!dataset.Tables.Contains(t)) dataAdapte.Fill(dataset,t);
            dataAdapte = null;
        }
        public static BindingSource RemplirListControl(ListControl l,string t,string dm,string vm)
        {
            BindingSource bs = new BindingSource();
            remplirTable(t);
            bs.DataSource = dataset;
            bs.DataMember = t;
            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;
            return bs;
        }
        static private void creerRelation(string tpk, string t, string pk, string fk)
        {
            string nomRel = "rel_" + tpk + "_" + t;
            DataColumn c1 = dataset.Tables[tpk].Columns[pk];
            DataColumn c2 = dataset.Tables[t].Columns[fk];

            DataRelation r = new DataRelation(nomRel, c1, c2);

            if (!dataset.Relations.Contains(nomRel))
                dataset.Relations.Add(r);

        }
        static public BindingSource remplirListeRel(ListControl l, string t, string dm, string vm, string tpk, string pk, string fk, BindingSource bsPk)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            creerRelation(tpk, t, pk, fk);

            bs.DataSource = bsPk;
            bs.DataMember = "rel_" + tpk + "_" + t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;



            return bs;

        }
        static public void syncroniser(string t)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dataset.Tables[t]);
            da = null;
            cb = null;
        }
      static public void exec(string sql)
        {
            model.BaseDonnee.ouvrirConnection();
            // MessageBox.Show(sql);
            SqlCommand com = new SqlCommand(sql, model.BaseDonnee.connection);
            com.ExecuteNonQuery();
            com = null;
            model.BaseDonnee.fermerConnectio();
        }
    }
}
