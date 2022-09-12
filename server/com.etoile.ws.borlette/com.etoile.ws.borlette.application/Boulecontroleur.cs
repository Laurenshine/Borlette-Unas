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
    public class Boulecontroleur:MarshalByRefObject,com.etoile.ws.borlette.interfaces.InterfaceBoule
    {
        int ver = 0;
        public int insererVente(string code, List<Boule> listeboule) 
        {
            try
            {
                ver = Bouledal.insererVente(code, listeboule);
            }
            catch (Exception er)
            {
                throw new Exception("0x3: " + er.Message + "   "+ listeboule.ElementAt(0).Prix);
            }
            return ver;
        }
    }
}