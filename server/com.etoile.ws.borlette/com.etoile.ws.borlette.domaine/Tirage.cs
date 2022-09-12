using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.etoile.ws.borlette.domaine
{
    public class Tirage
    {
        private string numero1;
        private string numero2;
        private string numero3;
        private string datet;

        public string Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }

        public string Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        public string Numero3
        {
            get { return numero3; }
            set { numero3 = value; }
        }

        public string  DateT
        {
            get { return datet; }
            set { datet = value; }
        }
        
        public Tirage()
        {
            numero1 = string.Empty;
            numero2 = string.Empty;
            numero3 = string.Empty;
            datet = string.Empty;
        }
        public Tirage(string p1, string p2, string p3, string date)
        {
            numero1 = p1;
            numero2 = p2;
            numero3 = p3;
            datet = date;
        }
    }
}
