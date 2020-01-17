﻿using Gestion_de_Absence.model;
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
            command.CommandText = "SELECT s.numjour, s.timestart ,s.activite FROM seance s INNER JOIN Groupe g ON s.idgroupe = g.idgroupe WHERE g.nomgroupe = '"+groupe+"' order by numjour,timestart";

            SqlDataReader dr = command.ExecuteReader();
            Jour jo = new Jour();
            while (dr.Read())
            {
                if (jo.jour == 0)
                {
                    jo.jour = (int)dr["numjour"];
                }
                  else if (jo.jour!= (int)dr["numjour"])
                {
                    j.Add(jo);
                    jo = new Jour();

                    jo.jour = (int)dr["numjour"];
                }
                TimeRegistre tm = new TimeRegistre();
                tm.text = (string)dr["activite"];
                tm.timestart =(int) dr["timestart"];
                jo.tmr.Add(tm);

            }
            dr.Close();
            j.Add(jo);
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

        public static void addSeance(string grope ,int numjour , int timepiriod , string activite,string nameuser,string numsalle) {
            ouvrirconnection();
            command.Connection = connection;
            command.CommandText = "insert into seance (timestart ,numjour,Activite ,salle ,idusers,idgroupe) values (" + timepiriod + "," + numjour + ",'" + activite + "','" + numsalle + "',(select idusers from users where nameusers = '" + nameuser + "') ,(select idgroupe from Groupe where nomgroupe = '" + grope + "'))";
            command.ExecuteNonQuery();

        }
        public static List<Users> getAllUsersinfo() {
            List<Users> us = new List<Users>();
            ouvrirconnection();
            command.Connection = connection;
            command.CommandText = "select idusers,nameusers,priorite from users";
            // add where priorite = 3 to get techer only
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                us.Add(new Users((int)dr["idusers"], (string)dr["nameusers"], (int)dr["priorite"]));
            }
            dr.Close();
            return us;

        }
       public static void deleteEnregestrempent(string grope, string numjour, string timepiriod)
        {
            ouvrirconnection();
            command.Connection = connection;
            command.CommandText = "delete s from seance s INNER JOIN Groupe g ON s.idgroupe = g.idgroupe WHERE  timestart = '" + timepiriod + "'  and numjour ='" + numjour + "' and  nomgroupe = '" + grope + "'";
            command.ExecuteNonQuery();
        }
    }
}
