using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.etoile.ws.borlette.domaine
{
    public class Boule
    {
        private string numero;
        private float prix;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public float Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public Boule()
        {
            this.numero = string.Empty;
            this.prix = 0;
        }
        public Boule(string numero, float prix)
        {
            this.numero = numero;
            this.prix = prix;
        }
    }
}
