using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.etoile.ws.borlette.dll.domaine;
using com.etoile.ws.borlette.dal;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace com.etoile.ws.borlette.application
{
    public class Joueurcontroleur:MarshalByRefObject,com.etoile.ws.borlette.interfaces.InterfaceJoueur
    {
        public List<string> afficherMontant(string code)
        {
            Joueur jr = null;
            List<string> jor = new List<string>();
            try
            {
                jr=Joueurdal.afficherMontant(code);
                if (jr!=null)
                {
                    jor.Add(jr.Pseudo);
                    jor.Add("" + jr.Montant);
                    return jor;
                }
                return null;
            }
            catch (Exception ext)
            {
                throw new Exception("0x3: "+ext.Message);
            }
        }
        public int Session(Joueur jr)
        {
            try
            {
                return Joueurdal.ajouterJoueur(jr);
            }
            catch (Exception oo)
            {
                throw new Exception("0x3: "+oo.Message);
            }
        }
        public int Seconnecter(string code)
        {
            try
            {
               return Joueurdal.Seconnecter(code);
            }
            catch (Exception me)
            {
                throw new Exception("0x3: "+me.Message);
            }
        }
        public int Sedeconnecter(string code)
        {
            try
            {
               return Joueurdal.Sedeconnecter(code);
            }
            catch (Exception me)
            {
                throw new Exception("0x3: " + me.Message);
            }
        }
        public void diminuerMontant(string montant, string code)
        {
            try
            {
                Joueurdal.diminuerMontant(montant ,code);
            }
            catch (Exception me)
            {
                throw new Exception("0x3: " + me.Message);
            }
        }
        public void enleverJoueur()
        {
            try
            {
                Joueurdal.enleverJouer();
            }
            catch (Exception me)
            {
                throw new Exception("0x3: " + me.Message);
            }
        }
    }
}
