using Gestion_de_Absence.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Gestion_de_Absence
{
    class BaseDonneeConnecter
    {
        static SqlConnection connection = new SqlConnection();
        static SqlCommand command = new SqlCommand();

        public static void ouvrirconnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["Absence"].ToString();
                connection.Open();
            }
        }
        public static List<Jour> getJourFromGroupe(string groupe)
        {
            List<Jour> j = new List<Jour>();
            ouvrirconnection();
            command.Connection = connection;
            command.CommandText = "SELECT jour, e.timestart,e.activite FROM Eregestrement e INNER JOIN jour j "
                +"ON e.idjour = j.idjour INNER JOIN Groupe g ON j.idgroupe = g.idgroupe WHERE g.nomgroupe = '"+groupe+ "'"
                +" order by jour,timestart";

            SqlDataReader dr = command.ExecuteReader();
            Jour jo = new Jour();
            while (dr.Read())
            {
                if (jo.jour == null)
                {
                    jo.jour = (string)dr["jour"];
                }
                  else if (jo.jour!= (string)dr["jour"])
                {
                    j.Add(jo);
                    jo = new Jour();

                    jo.jour = (string)dr["jour"];
                }
                TimeRegistre tm = new TimeRegistre();
                tm.text = (string)dr["activite"];
                tm.timestart =Convert.ToInt32( (string) dr["timestart"]);
                jo.tmr.Add(tm);

            }
            dr.Close();
            return j;
            
        }

        public static List<string> getGroupes()
        {
            List<string> j = new List<string>();
            ouvrirconnection();
            command.Connection = connection;
            command.CommandText = "select nomgroupe from groupe";
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                j.Add((string)dr["nomgroupe"]);
            }
            dr.Close();
            return j;
        }
    }
}
