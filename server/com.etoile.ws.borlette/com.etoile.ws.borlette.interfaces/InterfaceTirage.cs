using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.etoile.ws.borlette.dll.domaine;

namespace com.etoile.ws.borlette.interfaces
{
    public interface InterfacesTirage
    {
        int sauvegarderTirage(string num1,string num2,string num3,string date);
        Tirage rechercherTirage(string date);
        List<string> tirerLoto();

    }
}
