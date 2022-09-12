using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using com.etoile.ws.borlette.dll.domaine;

namespace com.etoile.ws.borlette.dal
{
    public class Bouledal
    {
        static SqlConnection scon = null;
        static SqlCommand cmd = null;
        static SqlDataReader rd = null;
        static string req = "";
        static int verif = 0;
        public static int insererVente(string code, List<Boule> liste)
        {
            try
            {
                scon = new SqlConnection(Properties.Settings.Default.chaine);
                scon.Open();
                foreach (Boule bo in liste)
                {
                    req = "insert into Vente values('" + code + "','" + bo.Numero + "','" + bo.Prix + "')";
                    cmd = new SqlCommand(req, scon);
                    verif = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ve)
            {
                throw new Exception("0x2: " + ve.Message);
            }
            finally
            {
                if (scon != null)
                {
                    scon.Close();
                }
            }
            {
                if (scon != null)
                {
                    scon.Close();
                }
            }
            return verif;
        }

    }
}