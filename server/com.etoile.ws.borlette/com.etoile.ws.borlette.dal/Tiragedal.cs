using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using com.etoile.ws.borlette.dll.domaine;
using System.Net.Sockets;

namespace com.etoile.ws.borlette.dal
{
    public class Tiragedal
    {
        static SqlConnection con = null;
        static SqlCommand cmm = null;
        static SqlDataReader red = null;
        static string requete = "";
        static int ver = 0;
        public static Tirage tirerLoto()
        {
            Tirage tr = new Tirage();
            Random bouleSortant=new Random ();
            List<string> bouleTirer = new List<string>();
            string loto = string.Empty;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    loto = bouleSortant.Next(0, 99).ToString();
                    if (int.Parse(loto)<10)
                    {
                        bouleTirer.Add("0"+loto);
                    }
                    else
                    {
                        bouleTirer.Add(loto);
                    }
                }
                tr = new Tirage(bouleTirer.ElementAt(0), bouleTirer.ElementAt(1), bouleTirer.ElementAt(2), DateTime.Now.ToString());
            }
            catch (Exception uy)
            {
                throw new Exception("0x2: "+uy.Message);
            }
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return tr;
        }
        public static int sauvegarderTirage(Tirage ti)
        {
            requete = "insert into Tirage values('"+ti.Numero1 +"','"+ti.Numero2+"','"+ti.Numero3+"','"+ti.DateT+"')";
            try
            {
                con = new SqlConnection(Properties.Settings.Default.chaine);
                con.Open();
                cmm = new SqlCommand(requete, con);
                ver = cmm.ExecuteNonQuery();
            }
            catch (Exception we)
            {
                throw new Exception("2: "+we.Message );
            }
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return ver;   
        }
        public static Tirage rechercherTirage(string date)
        {
            Tirage tr = null;
            requete = "select * from Tirage where Datetirage='"+date+"'";
            try
            {
                con = new SqlConnection(Properties.Settings.Default.chaine);
                con.Open();
                cmm = new SqlCommand(requete, con);
                red = cmm.ExecuteReader();
                if (red.Read())
                {
                    tr = new Tirage(red.GetString(0), red.GetString(1), red.GetString(2), red.GetDateTime(3).ToShortDateString());
                }
            }
            catch (Exception xd)
            {
                throw new Exception("2: "+xd.Message);
            }
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return tr;
        }
    }
}