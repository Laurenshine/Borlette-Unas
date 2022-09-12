using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.etoile.ws.borlette.dll.domaine;
using System.Threading;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using com.etoile.ws.borlette.interfaces;
using System.Text.RegularExpressions;

namespace com.etoile.ws.borlette.presentetion
{
    public partial class Form1 : Form
    {
        public int i = 0;
        public string co;
        public string speudoj;
        public TcpChannel canal0;

        //InterfaceBoule boule;
        public InterfaceJoueur Jower;
        public InterfacesTirage ti;
        public bool mytest;
        public int ve=0;
        public Form1()
        {
            InitializeComponent();
            canal0 = new TcpChannel();
        }
        public void placeHolder() 
        {
            txtnumero.GotFocus += new EventHandler(this.ouiN);
            txtnumero.LostFocus += new EventHandler(this.nonN);
            txtprix.GotFocus += new EventHandler(this.ouiP);
            txtprix.LostFocus += new EventHandler(this.nonP);
            txtnumero.Focus();
        }
        private void btInstantane_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            txtCodejoueur.Focus();
        }
        private void btRetour_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            ChannelServices.RegisterChannel(canal0);
            Jower = (InterfaceJoueur)Activator.GetObject(typeof(InterfaceJoueur), "tcp://127.0.0.1:1804/Joueur");
            tabControl1.SelectTab(tabPage1);
            Jower.Sedeconnecter(co);
            txtCodejoueur.Text = "";
            lboul = new BindingList<Boule>();
            dataGridView1.DataSource = lboul;
            txtmontantdepose.Text = "$$";
            txtboul1.Text = "$$";
            txtboul2.Text = "$$";
            txtboul3.Text = "$$";
            txtnumero.Text = "Boule";
            txtnumero.ForeColor = Color.DarkGray;
            txtprix.Text = "Prix";
            txtprix.ForeColor = Color.DarkGray;
            placeHolder();
            ChannelServices.UnregisterChannel(canal0);
        }
        BindingList<Boule> lboul = new BindingList<Boule>();
        // Boutton Valider
        private void btnvalider_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            List<string> boul=new List<string>();
            try
            {
                if (lboul.Count()>0 && mytest == true)
                {
                        lboul = new BindingList<Boule>();
                        dataGridView1.DataSource = lboul;
                        mytest = false;
                        txtboul1.Text = "$$";
                        txtboul2.Text = "$$";
                        txtboul3.Text = "$$";
                }
                if (!(txtmontantdepose.Text == "$$" | txtmontantdepose.Text.Contains("^[-a-zA-Z-èêàëçâïôæœ@',# ]{1})$")))
                {
                    if (float.Parse(txtmontantdepose.Text) >= 0)
                    {
                        boul.Add(txtnumero.Text);
                        boul.Add(txtprix.Text);
                        if (float.Parse(boul.ElementAt(1)) > 0)
                        {
                            if (float.Parse(boul.ElementAt(1)) <= float.Parse(txtmontantdepose.Text))
                            {
                                Boule bou = new Boule();
                                bou.Numero = boul.ElementAt(0);
                                bou.Prix = float.Parse(boul.ElementAt(1));
                                lboul.Add(bou);
                                txtmontantdepose.Text = "" + (float.Parse(txtmontantdepose.Text) - bou.Prix);
                                txtnumero.Text = "Boule";
                                txtnumero.ForeColor = Color.DarkGray;
                                txtprix.Text = "Prix";
                                txtprix.ForeColor = Color.DarkGray;
                                placeHolder();
                                btJouer.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Oups! Votre montant est insuffisant!");
                                txtnumero.Text = "Boule";
                                txtnumero.ForeColor = Color.DarkGray;
                                txtprix.Text = "Prix";
                                txtprix.ForeColor = Color.DarkGray;
                                placeHolder();
                                btJouer.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oh! voila qui essaie de tricher dans notre Jeu. La prochaine fois, ton compte sera vidé");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez saisir votre code de jeu pour la session");
                    placeHolder();
                    //txtmontantdepose.Text = "50";
                }
            }
            catch (Exception uj)
            {
                MessageBox.Show(uj.Message);
            }
        }

        private void btParheure_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }
        public void ouiN(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((tb.Text=="Boule"))
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        public void ouiP(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((tb.Text == "Prix"))
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        public void nonN(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Boule";
                tb.ForeColor = Color.DarkGray;
            }
        }
        public void nonP(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "Prix";
                tb.ForeColor = Color.DarkGray;
            }
        }
        // Form Load 
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            labelspeudojoeur.Visible = false;
            placeHolder();
            btJouer.Enabled = false;
            ChannelServices.RegisterChannel(canal0);
            Jower = (InterfaceJoueur)Activator.GetObject(typeof(InterfaceJoueur), "tcp://127.0.0.1:1804/Joueur");
            Jower.enleverJoueur();
            ChannelServices.UnregisterChannel(canal0);
            dataGridView1.DataSource = lboul;
            int i = 0;
            while (i < 950)
            {
                i++;
                lbl_texteDefile.Location = new Point(lbl_texteDefile.Location.X + 1, lbl_texteDefile.Location.Y);
                Thread.Sleep(20);
                Application.DoEvents();
                if (i == 950)
                {
                    i = 1;
                    lbl_texteDefile.SetBounds(-40, 15, 110, 21);
                }
            }
        }

        List<string> jb = null;
        // Boutton Valider Codejoeur 
        private void btValidercodejoueur_Click(object sender, EventArgs e)
        {
            ChannelServices.RegisterChannel(canal0);
            Jower = (InterfaceJoueur)Activator.GetObject(typeof(InterfaceJoueur), "tcp://127.0.0.1:1804/Joueur");
            if(txtCodejoueur.Text == "" && txtmontantdepose.Text!= "$$")
            {
                MessageBox.Show("Vous avez deja une session en cours");
            }
            else if (txtCodejoueur.Text=="")
            {
                MessageBox.Show("Veuillez entrer votre code pour ouvrir la Session !!");
            } 
            else
            {
                try
                {
                    jb = Jower.afficherMontant(txtCodejoueur.Text);
                    if (jb != null)
                    {
                        ve=Jower.Seconnecter(txtCodejoueur.Text);
                        if (ve!=0)
                        {
                            txtmontantdepose.Text = jb.ElementAt(1);
                            labelspeudojoeur.Visible = true;
                            labelspeudojoeur.Text = "Bienvenue "+jb.ElementAt(0);
                            co = txtCodejoueur.Text;
                            
                            txtnumero.Focus();
                            placeHolder();
                            txtCodejoueur.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Une personne est deja connectee avec ce code!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce code n'est pas dans la base. assurez-vous que vous avez bien saisi tous les caracteres.");
                        txtCodejoueur.Focus();
                        txtCodejoueur.Text = "";
                    }
                }
                catch (Exception ed)
                {
                    MessageBox.Show(""+ ed.Message);
                }
            }
            ChannelServices.UnregisterChannel(canal0);
        }

        private void ovalShape3_Click(object sender, EventArgs e)
        {

        }
        // Boutton Jouer Boutton Jouer Boutton Jouer
        List<string> tir = new List<string>();
        private void btJouer_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "Boule";
            txtprix.Text = "Prix";
            txtnumero.ForeColor = Color.DarkGray;
            txtprix.ForeColor = Color.DarkGray;
            placeHolder();
            ChannelServices.RegisterChannel(canal0);
            ti = (InterfacesTirage)Activator.GetObject(typeof(InterfacesTirage), "tcp://127.0.0.1:1804/Tirage");
            try
            {
                int j = 0;
                if (lboul.Count()>0)
                {
                    tir=ti.tirerLoto();
                    txtboul1.Text = tir.ElementAt(0);
                    txtboul2.Text = tir.ElementAt(1);
                    txtboul3.Text = tir.ElementAt(2);

                    foreach (Boule bou in lboul)
                    {
                        if (bou.Numero == tir.ElementAt(0) && bou.Numero == tir.ElementAt(1) && bou.Numero == tir.ElementAt(2))
                        {
                            label1.Visible = true;
                            label1.Text = "Vous avez fait le jackPot: tu as gagné les 3 lots";
                            i = 0;
                            j = 1;
                            label2.Visible = true;
                            label2.Text = "Montant gagné: " + ((60 * bou.Prix) + (20 * bou.Prix) + (10 * bou.Prix)) + "Gourdes";
                        }
                        else if (bou.Numero == tir.ElementAt(0) && bou.Numero == tir.ElementAt(1))
                        {
                            label1.Visible = true;
                            label1.Text = "Vous avez gagné le premier et le deuxième lots";
                            i = 0;
                            j = 1;
                            label2.Visible = true;
                            label2.Text = "Montant gagné: " + ((60 * bou.Prix) + (20 * bou.Prix)) + "Gourdes";
                        }
                        else if (bou.Numero == tir.ElementAt(0) && bou.Numero == tir.ElementAt(2))
                        {
                            label1.Visible = true;
                            label1.Text = "Vous avez gagné le premier et le troisième lots";
                            i = 0;
                            j = 1;
                            label2.Visible = true;
                            label2.Text = "Montant gagné: " + ((60 * bou.Prix) + (10 * bou.Prix)) + "Gourdes";
                        }
                        else if (bou.Numero == tir.ElementAt(1) && bou.Numero == tir.ElementAt(2))
                        {
                            label1.Visible = true;
                            label1.Text = "Vous avez gagné le deuxième et le troisième lots";
                            i = 0;
                            j = 1;
                            label2.Visible = true;
                            label2.Text = "Montant gagné: " + ((20 * bou.Prix) + (10 * bou.Prix)) + "Gourdes";
                        }
                        else if (bou.Numero == tir.ElementAt(0))
                        {
                            label1.Visible = true;
                            label1.Text = "Vous avez gagné le premier lot";
                            i = 0;
                            j = 1;
                            label2.Visible = true;
                            label2.Text = "Montant gagné: " + (60 * bou.Prix) + "Gourdes";
                        }
                        else if (bou.Numero == tir.ElementAt(1))
                        {
                            label1.Visible = true;
                            label1.Text = "Vous avez gagné le deuxième lot";
                            i = 0;
                            j = 1;
                            label2.Visible = true;
                            label2.Text = "Montant gagné: " + (20 * bou.Prix)+"Gourdes";
                        }
                        else if (bou.Numero == tir.ElementAt(2))
                        {
                            label1.Visible = true;
                            label1.Text = "Vous avez gagné le troisième lot";
                            i = 0;
                            j = 1;
                            label2.Visible = true;
                            label2.Text = "Montant gagné: " + (10 * bou.Prix)+"Gourdes";
                        }
                        else
                        {
                            i=1;
                        }
                    }
                    if (i > 0)
                    {
                        if (j == 0)
                        {
                            MessageBox.Show(" Oups Vous avez perdu!");
                        }
                    }
                    btJouer.Enabled = false;
                    mytest = true;
                }
                ChannelServices.UnregisterChannel(canal0);
                ChannelServices.RegisterChannel(canal0);
                Jower = (InterfaceJoueur)Activator.GetObject(typeof(InterfaceJoueur), "tcp://127.0.0.1:1804/Joueur");
                if (txtmontantdepose.Text !="$$")
                {
                    Jower.diminuerMontant(txtmontantdepose.Text, co);
                }
                ChannelServices.UnregisterChannel(canal0);
            }
            catch (Exception sd)
            {
                MessageBox.Show("0x4: "+sd.Message+" "+txtboul3.Text);
            }
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmontantdepose_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtprix_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtprix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}