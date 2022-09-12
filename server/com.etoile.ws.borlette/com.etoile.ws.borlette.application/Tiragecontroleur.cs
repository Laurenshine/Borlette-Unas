using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using com.etoile.ws.borlette.dal;
using com.etoile.ws.borlette.dll.domaine;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace com.etoile.ws.borlette.application
{
    public class Tiragecontroleur:MarshalByRefObject, com.etoile.ws.borlette.interfaces.InterfacesTirage 
    {
        int resultat = 0;
        public List<string> tirerLoto() 
        {
            List<string> list = new List<string>();
            Tirage tr = new Tirage();
            try
            {
                tr = Tiragedal.tirerLoto();
                if (tr!=null)
                {
                    list.Add(tr.Numero1);
                    list.Add(tr.Numero2);
                    list.Add(tr.Numero3);
                    list.Add(tr.DateT);
                }
            }
            catch (Exception io)
            {
                throw new Exception("0x3: "+io.Message) ;
            }
            return list;
        }
        public int sauvegarderTirage(string num1,string num2,string num3,string date)
        {
            try
            {
                //List<string> lisnum
                //lisnum.ElementAt(0), lisnum.ElementAt(1), lisnum.ElementAt(2), lisnum.ElementAt(3)
                Tirage tir = new Tirage(  num1,  num2,  num3,  date);
                resultat = Tiragedal.sauvegarderTirage(tir);
            }
            catch (Exception ty)
            {
                throw new Exception("3: "+ty.Message);
            }
            return resultat;
        }
        public Tirage rechercherTirage(string date)
        {
            Tirage tr = new Tirage();
            try
            {
                 tr = Tiragedal.rechercherTirage(date);
            }
            catch (Exception de)
            {
                throw new Exception("0x3 :"+de.Message);
            }
            return tr;
        }
    }
}