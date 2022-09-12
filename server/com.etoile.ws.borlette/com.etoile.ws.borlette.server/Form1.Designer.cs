namespace com.etoile.ws.borlette.server
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btSession = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtboule1 = new System.Windows.Forms.TextBox();
            this.txtboule2 = new System.Windows.Forms.TextBox();
            this.txtboule3 = new System.Windows.Forms.TextBox();
            this.btntirage = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo";
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(141, 62);
            this.txtPseudo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(235, 22);
            this.txtPseudo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montant";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(141, 103);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(235, 22);
            this.txtMontant.TabIndex = 3;
            // 
            // btSession
            // 
            this.btSession.Location = new System.Drawing.Point(141, 161);
            this.btSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSession.Name = "btSession";
            this.btSession.Size = new System.Drawing.Size(111, 28);
            this.btSession.TabIndex = 4;
            this.btSession.Text = "Creer session";
            this.btSession.UseVisualStyleBackColor = true;
            this.btSession.Click += new System.EventHandler(this.btSession_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(260, 161);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(117, 28);
            this.btAnnuler.TabIndex = 5;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btAnnuler);
            this.groupBox1.Controls.Add(this.btSession);
            this.groupBox1.Controls.Add(this.txtMontant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPseudo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(515, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session  de Jeu ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnenregistrer);
            this.groupBox2.Controls.Add(this.btntirage);
            this.groupBox2.Controls.Add(this.txtboule3);
            this.groupBox2.Controls.Add(this.txtboule2);
            this.groupBox2.Controls.Add(this.txtboule1);
            this.groupBox2.Location = new System.Drawing.Point(12, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtboule1
            // 
            this.txtboule1.Location = new System.Drawing.Point(35, 74);
            this.txtboule1.Multiline = true;
            this.txtboule1.Name = "txtboule1";
            this.txtboule1.Size = new System.Drawing.Size(77, 54);
            this.txtboule1.TabIndex = 0;
            this.txtboule1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboule2
            // 
            this.txtboule2.Location = new System.Drawing.Point(167, 74);
            this.txtboule2.Multiline = true;
            this.txtboule2.Name = "txtboule2";
            this.txtboule2.Size = new System.Drawing.Size(77, 54);
            this.txtboule2.TabIndex = 1;
            this.txtboule2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboule3
            // 
            this.txtboule3.Location = new System.Drawing.Point(300, 74);
            this.txtboule3.Multiline = true;
            this.txtboule3.Name = "txtboule3";
            this.txtboule3.Size = new System.Drawing.Size(77, 54);
            this.txtboule3.TabIndex = 2;
            this.txtboule3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btntirage
            // 
            this.btntirage.Location = new System.Drawing.Point(56, 180);
            this.btntirage.Name = "btntirage";
            this.btntirage.Size = new System.Drawing.Size(75, 44);
            this.btntirage.TabIndex = 3;
            this.btntirage.Text = "Tirage";
            this.btntirage.UseVisualStyleBackColor = true;
            this.btntirage.Click += new System.EventHandler(this.btntirage_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.Location = new System.Drawing.Point(208, 180);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(102, 44);
            this.btnenregistrer.TabIndex = 4;
            this.btnenregistrer.Text = "sauvegarde";
            this.btnenregistrer.UseVisualStyleBackColor = true;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Unas Loterie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btSession;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btntirage;
        private System.Windows.Forms.TextBox txtboule3;
        private System.Windows.Forms.TextBox txtboule2;
        private System.Windows.Forms.TextBox txtboule1;

    }
}

