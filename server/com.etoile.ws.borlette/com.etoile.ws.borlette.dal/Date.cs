using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.etoile.ws.borlette.dal
{
   public class Date
    {
        private int jour;
        private int mois;
        private int annee;

        public int Jour
        {
            get { return jour; }
            set { jour = value; }
        }
        public int Mois
        {
            get { return mois; }
            set { mois = value; }
        }
        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }
        public Date(int jour, int mois,int annee)
        {
            this.jour = jour;
            this.mois = mois;
            this.annee = annee;
        }
        public Date()
        {
            this.jour = 0;
            this.mois = 0;
            this.annee = 0;
        }
    }
}
