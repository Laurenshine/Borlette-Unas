using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using com.etoile.ws.borlette.dll.domaine;
namespace com.etoile.ws.borlette.dal
{
    public class Joueurdal
    {
        static string req = "";
        static SqlConnection scon = null;
        static SqlCommand cmd = null;
        static SqlDataReader rd = null;
        static int ver = 0;

        public static int ajouterJoueur(Joueur jr)
        {
            req = "insert into Joueur values('"+jr.Codejoueur+"','"+jr.Pseudo+"','"+jr.Montant+"','"+jr.Etat+"')";
            try
            {
                scon = new SqlConnection(Properties.Settings.Default.chaine);
                scon.Open();
                cmd = new SqlCommand(req, scon);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception xe)
            {
                throw new Exception("0x2: " + xe.Message);
            }
            finally
            {
                if (scon!=null)
                {
                    scon.Close();
                }
            }
            return ver;
        }
        public static Joueur afficherMontant(string code)
        {
            Joueur jr = null;
            req = "select Pseudo, Montant from Joueur where Code='" + code + "'";
            try
            {
                scon = new SqlConnection(Properties.Settings.Default.chaine);
                scon.Open();
                cmd = new SqlCommand(req, scon);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    jr = new Joueur(rd.GetString(0), float.Parse(rd[1].ToString()));
                }
            }
            catch (Exception me)
            {
                throw new Exception("0x2: " + me.Message);
            }
            finally 
            {
                if (scon!=null)
                {
                    scon.Close();
                }
            }
            return jr;
        }
        public static int Seconnecter(string code)
        {
            req = "update Joueur set Etat='1' where Code='" + code + "' and Etat ='0'";
            try
            {
                scon = new SqlConnection(Properties.Settings.Default.chaine);
                scon.Open();
                cmd = new SqlCommand(req, scon);
                ver=cmd.ExecuteNonQuery();
            }
            catch (Exception so)
            {
                throw new Exception("0x2: " + so.Message);
            }
            finally
            {
                if (scon!=null)
                {
                    scon.Close();
                }
            }
            return ver;
        }
        public static int Sedeconnecter(string code)
        {
            req = "update Joueur set Etat='0' where Code='" + code + "' and Etat ='1'";
            try
            {
                scon = new SqlConnection(Properties.Settings.Default.chaine);
                scon.Open();
                cmd = new SqlCommand(req, scon);
                ver=cmd.ExecuteNonQuery();
            }
            catch (Exception so)
            {
                throw new Exception("0x2: " + so.Message);
            }
            finally
            {
                if (scon != null)
                {
                    scon.Close();
                }
            }
            return ver;
        }
        public static void diminuerMontant(string newMontant, string code) 
        {
            req = "update Joueur set Montant='"+newMontant+"' where Code='"+code+"'";
            try
            {
                scon = new SqlConnection(Properties.Settings.Default.chaine);
                scon.Open();
                cmd = new SqlCommand(req, scon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception so)
            {
                throw new Exception("0x2: " + so.Message);
            }
            finally
            {
                if (scon != null)
                {
                    scon.Close();
                }
            }
        }
        public static void enleverJouer()
        {
            req = "Delete from Joueur where Montant='0'";
            try
            {
                scon = new SqlConnection(Properties.Settings.Default.chaine);
                scon.Open();
                cmd = new SqlCommand(req, scon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception so)
            {
                throw new Exception("0x2: " + so.Message);
            }
            finally
            {
                if (scon != null)
                {
                    scon.Close();
                }
            }
        }
    }
}
