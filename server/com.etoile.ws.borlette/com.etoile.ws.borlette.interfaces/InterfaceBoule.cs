using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.etoile.ws.borlette.dll.domaine;

namespace com.etoile.ws.borlette.interfaces
{
    public interface InterfaceBoule
    {
        int insererVente(string code, List<Boule> listeboule);

    }
}