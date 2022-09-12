using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using com.etoile.ws.borlette.dll.domaine;

namespace com.etoile.ws.borlette.interfaces
{
    public interface InterfaceJoueur
    {
        List<string> afficherMontant(string code);
        int Seconnecter(string code);
        int Sedeconnecter(string code);
        void diminuerMontant(string montant, string code);
        void enleverJoueur();
    }
}
