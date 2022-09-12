using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.etoile.ws.borlette.domaine
{
    public class Joueur
    {
        private string pseudo;

        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }
        private float montant;

        public float Montant
        {
            get { return montant; }
            set { montant = value; }
        }
        private string codejoueur;

        public string Codejoueur
        {
            get { return codejoueur; }
            set { codejoueur = value; }
        }
        private int etat;

        public int Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        public Joueur()
        {
            this.pseudo = string.Empty;
            this.montant = 0;
            this.codejoueur = string.Empty;
            this.etat = 0;
        }
        
        public Joueur(string codejoueur, string pseudo, float montant, int etat)
        {
            this.pseudo = pseudo;
            this.montant = montant;
            this.codejoueur = codejoueur;
            this.etat = etat;
        }
        public Joueur(string pseudo, float montant)
        {
            this.pseudo = pseudo;
            this.montant = montant;
        }

    }
}
