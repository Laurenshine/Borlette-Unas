using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.etoile.ws.borlette.application;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Data.SqlClient;
using com.etoile.ws.borlette.dll.domaine;

namespace com.etoile.ws.borlette.server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                TcpChannel canal = new TcpChannel(1804);
                ChannelServices.RegisterChannel(canal);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Boulecontroleur), "Boule", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Tiragecontroleur), "Tirage", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Joueurcontroleur), "Joueur", WellKnownObjectMode.Singleton);
            }
            catch (Exception mo)
            {
                MessageBox.Show(mo.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Joueurcontroleur es = new Joueurcontroleur();
            Joueur ti = null ;
            try
            {
                //ti = es.afficherMontant("AU-123");
                //if (ti!=null)
                //{
                //    MessageBox.Show(ti.Pseudo + "  "+ ti.Montant );
                //}
                //bool blan = es.Seconnecter("38170756");
                //if (blan == true)
                //{
                //    MessageBox.Show("konekte");
                //}
                //else
                //{
                //    MessageBox.Show("E pa ti kras. Nan tcm lan?");
                //}
            }
            catch (Exception ry)
            {
                MessageBox.Show("0x4: "+ry.Message);
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            txtMontant.Text = "";
            txtPseudo.Text = "";
        }

        private void btSession_Click(object sender, EventArgs e)
        {
            Joueurcontroleur  jor = new Joueurcontroleur();
            Joueur j = null;
            int ve = 0;
            try
            {
                Random co = new Random();
                string code = string.Format("{0}{1}{2}{3}", co.Next(0,9), co.Next(0,9), co.Next(1, 999), DateTime.Now.Millisecond);
                string pseudo = txtPseudo.Text;
                float montant = float.Parse(txtMontant.Text);
                if (pseudo!="" && montant>0)
                {
                    j = new Joueur(code, pseudo, montant, 0);
                    ve = jor.Session(j);
                    if (ve!=0)
                    {
                        MessageBox.Show(pseudo+"! vous avez une session cree, utilisez le code "+code+" pour connecter");
                    }
                }
            }
            catch (Exception ae)
            {
                throw new Exception("0x4: "+ae.Message);
            }
        }

        private void btntirage_Click(object sender, EventArgs e)
        {
            Tiragecontroleur tr = new Tiragecontroleur();
             Tirage tir = new Tirage ();
            List<string> lot=new List<string> ();
            try
            {
                lot = tr.tirerLoto();
                txtboule1.Text = lot.ElementAt(0);
                txtboule2.Text = lot.ElementAt(1);
                txtboule3.Text = lot.ElementAt(2);

                 
                 

            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            Tiragecontroleur tr = new Tiragecontroleur();
            int verif=0;
            string date=DateTime.Now.ToString();

            try
            {

                verif =tr.sauvegarderTirage(txtboule1.Text, txtboule2.Text, txtboule3.Text, date);

                if (verif!=0)
                {
                    MessageBox.Show("votre tirage a ete bien reussie");  
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}