namespace Gestion_de_Absence
{
    partial class Stagiaire
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
            this.cbGroupe = new System.Windows.Forms.ComboBox();
            this.btnGAjouter = new System.Windows.Forms.Button();
            this.txtGroupe = new System.Windows.Forms.TextBox();
            this.btnGValider = new System.Windows.Forms.Button();
            this.btnGModifier = new System.Windows.Forms.Button();
            this.btnGSupprimer = new System.Windows.Forms.Button();
            this.lsStagiaire = new System.Windows.Forms.ListBox();
            this.txtChercher = new System.Windows.Forms.TextBox();
            this.btnSChercher = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.btnSAjouter = new System.Windows.Forms.Button();
            this.btnSModifier = new System.Windows.Forms.Button();
            this.btnSSupprimer = new System.Windows.Forms.Button();
            this.btnGAnnuler = new System.Windows.Forms.Button();
            this.btnSAnnuler = new System.Windows.Forms.Button();
            this.btnSValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnSNavigation = new System.Windows.Forms.Panel();
            this.btnSLast = new System.Windows.Forms.Button();
            this.btnSPrevious = new System.Windows.Forms.Button();
            this.btnSNext = new System.Windows.Forms.Button();
            this.btnSFirst = new System.Windows.Forms.Button();
            this.pnGValidation = new System.Windows.Forms.Panel();
            this.pnGModification = new System.Windows.Forms.Panel();
            this.pnSModification = new System.Windows.Forms.Panel();
            this.pnGroupe = new System.Windows.Forms.Panel();
            this.txtIDgroupe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnSZoneText = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdStagiaire = new System.Windows.Forms.TextBox();
            this.pnSValidation = new System.Windows.Forms.Panel();
            this.pnSNavigation.SuspendLayout();
            this.pnGValidation.SuspendLayout();
            this.pnGModification.SuspendLayout();
            this.pnSModification.SuspendLayout();
            this.pnGroupe.SuspendLayout();
            this.pnSZoneText.SuspendLayout();
            this.pnSValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGroupe
            // 
            this.cbGroupe.FormattingEnabled = true;
            this.cbGroupe.Location = new System.Drawing.Point(149, 15);
            this.cbGroupe.Margin = new System.Windows.Forms.Padding(4);
            this.cbGroupe.Name = "cbGroupe";
            this.cbGroupe.Size = new System.Drawing.Size(160, 24);
            this.cbGroupe.TabIndex = 0;
            // 
            // btnGAjouter
            // 
            this.btnGAjouter.Location = new System.Drawing.Point(24, 32);
            this.btnGAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnGAjouter.Name = "btnGAjouter";
            this.btnGAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnGAjouter.TabIndex = 1;
            this.btnGAjouter.Text = "Ajouter";
            this.btnGAjouter.UseVisualStyleBackColor = true;
            this.btnGAjouter.Click += new System.EventHandler(this.btnGAjouter_Click);
            // 
            // txtGroupe
            // 
            this.txtGroupe.Location = new System.Drawing.Point(268, 17);
            this.txtGroupe.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroupe.Name = "txtGroupe";
            this.txtGroupe.Size = new System.Drawing.Size(160, 22);
            this.txtGroupe.TabIndex = 2;
            // 
            // btnGValider
            // 
            this.btnGValider.Location = new System.Drawing.Point(8, 15);
            this.btnGValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnGValider.Name = "btnGValider";
            this.btnGValider.Size = new System.Drawing.Size(100, 28);
            this.btnGValider.TabIndex = 1;
            this.btnGValider.Text = "Valider";
            this.btnGValider.UseVisualStyleBackColor = true;
            this.btnGValider.Click += new System.EventHandler(this.btnGValider_Click);
            // 
            // btnGModifier
            // 
            this.btnGModifier.Location = new System.Drawing.Point(132, 15);
            this.btnGModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnGModifier.Name = "btnGModifier";
            this.btnGModifier.Size = new System.Drawing.Size(100, 28);
            this.btnGModifier.TabIndex = 1;
            this.btnGModifier.Text = "Modifier";
            this.btnGModifier.UseVisualStyleBackColor = true;
            this.btnGModifier.Click += new System.EventHandler(this.btnGModifier_Click);
            // 
            // btnGSupprimer
            // 
            this.btnGSupprimer.Location = new System.Drawing.Point(132, 51);
            this.btnGSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnGSupprimer.Name = "btnGSupprimer";
            this.btnGSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnGSupprimer.TabIndex = 1;
            this.btnGSupprimer.Text = "Supprimer";
            this.btnGSupprimer.UseVisualStyleBackColor = true;
            this.btnGSupprimer.Click += new System.EventHandler(this.btnGSupprimer_Click);
            // 
            // lsStagiaire
            // 
            this.lsStagiaire.FormattingEnabled = true;
            this.lsStagiaire.ItemHeight = 16;
            this.lsStagiaire.Location = new System.Drawing.Point(27, 40);
            this.lsStagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.lsStagiaire.Name = "lsStagiaire";
            this.lsStagiaire.Size = new System.Drawing.Size(348, 404);
            this.lsStagiaire.TabIndex = 3;
            // 
            // txtChercher
            // 
            this.txtChercher.Location = new System.Drawing.Point(25, 4);
            this.txtChercher.Margin = new System.Windows.Forms.Padding(4);
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.Size = new System.Drawing.Size(240, 22);
            this.txtChercher.TabIndex = 4;
            this.txtChercher.TextChanged += new System.EventHandler(this.txtChercher_TextChanged);
            // 
            // btnSChercher
            // 
            this.btnSChercher.Location = new System.Drawing.Point(275, 4);
            this.btnSChercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnSChercher.Name = "btnSChercher";
            this.btnSChercher.Size = new System.Drawing.Size(100, 28);
            this.btnSChercher.TabIndex = 1;
            this.btnSChercher.Text = "Chercher";
            this.btnSChercher.UseVisualStyleBackColor = true;
            this.btnSChercher.Click += new System.EventHandler(this.btnSChercher_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(133, 67);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(160, 22);
            this.txtNum.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(133, 106);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(160, 22);
            this.txtNom.TabIndex = 2;
            // 
            // txtCin
            // 
            this.txtCin.Location = new System.Drawing.Point(133, 145);
            this.txtCin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(160, 22);
            this.txtCin.TabIndex = 2;
            // 
            // btnSAjouter
            // 
            this.btnSAjouter.Location = new System.Drawing.Point(25, 32);
            this.btnSAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnSAjouter.Name = "btnSAjouter";
            this.btnSAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnSAjouter.TabIndex = 1;
            this.btnSAjouter.Text = "Ajouter";
            this.btnSAjouter.UseVisualStyleBackColor = true;
            this.btnSAjouter.Click += new System.EventHandler(this.btnSAjouter_Click);
            // 
            // btnSModifier
            // 
            this.btnSModifier.Location = new System.Drawing.Point(147, 32);
            this.btnSModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnSModifier.Name = "btnSModifier";
            this.btnSModifier.Size = new System.Drawing.Size(100, 28);
            this.btnSModifier.TabIndex = 1;
            this.btnSModifier.Text = "Modifier";
            this.btnSModifier.UseVisualStyleBackColor = true;
            this.btnSModifier.Click += new System.EventHandler(this.btnSModifier_Click);
            // 
            // btnSSupprimer
            // 
            this.btnSSupprimer.Location = new System.Drawing.Point(279, 32);
            this.btnSSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSSupprimer.Name = "btnSSupprimer";
            this.btnSSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSSupprimer.TabIndex = 1;
            this.btnSSupprimer.Text = "Supprimer";
            this.btnSSupprimer.UseVisualStyleBackColor = true;
            this.btnSSupprimer.Click += new System.EventHandler(this.btnSSupprimer_Click);
            // 
            // btnGAnnuler
            // 
            this.btnGAnnuler.Location = new System.Drawing.Point(8, 50);
            this.btnGAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnGAnnuler.Name = "btnGAnnuler";
            this.btnGAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnGAnnuler.TabIndex = 5;
            this.btnGAnnuler.Text = "Annuler";
            this.btnGAnnuler.UseVisualStyleBackColor = true;
            this.btnGAnnuler.Click += new System.EventHandler(this.btnGAnnuler_Click);
            // 
            // btnSAnnuler
            // 
            this.btnSAnnuler.Location = new System.Drawing.Point(177, 11);
            this.btnSAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnSAnnuler.Name = "btnSAnnuler";
            this.btnSAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnSAnnuler.TabIndex = 1;
            this.btnSAnnuler.Text = "Annuler";
            this.btnSAnnuler.UseVisualStyleBackColor = true;
            this.btnSAnnuler.Click += new System.EventHandler(this.btnSAnnuler_Click);
            // 
            // btnSValider
            // 
            this.btnSValider.Location = new System.Drawing.Point(32, 11);
            this.btnSValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnSValider.Name = "btnSValider";
            this.btnSValider.Size = new System.Drawing.Size(100, 28);
            this.btnSValider.TabIndex = 1;
            this.btnSValider.Text = "Valider";
            this.btnSValider.UseVisualStyleBackColor = true;
            this.btnSValider.Click += new System.EventHandler(this.btnSValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "NumStagiaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "NomStagiaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "CinStagiaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "NomGroupe";
            // 
            // pnSNavigation
            // 
            this.pnSNavigation.Controls.Add(this.btnSLast);
            this.pnSNavigation.Controls.Add(this.btnSPrevious);
            this.pnSNavigation.Controls.Add(this.btnSNext);
            this.pnSNavigation.Controls.Add(this.btnSFirst);
            this.pnSNavigation.Controls.Add(this.txtChercher);
            this.pnSNavigation.Controls.Add(this.lsStagiaire);
            this.pnSNavigation.Controls.Add(this.btnSChercher);
            this.pnSNavigation.Location = new System.Drawing.Point(449, 11);
            this.pnSNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.pnSNavigation.Name = "pnSNavigation";
            this.pnSNavigation.Size = new System.Drawing.Size(391, 551);
            this.pnSNavigation.TabIndex = 9;
            // 
            // btnSLast
            // 
            this.btnSLast.Location = new System.Drawing.Point(333, 465);
            this.btnSLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnSLast.Name = "btnSLast";
            this.btnSLast.Size = new System.Drawing.Size(41, 28);
            this.btnSLast.TabIndex = 5;
            this.btnSLast.Text = ">>";
            this.btnSLast.UseVisualStyleBackColor = true;
            this.btnSLast.Click += new System.EventHandler(this.btnSLast_Click);
            // 
            // btnSPrevious
            // 
            this.btnSPrevious.Location = new System.Drawing.Point(288, 465);
            this.btnSPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnSPrevious.Name = "btnSPrevious";
            this.btnSPrevious.Size = new System.Drawing.Size(41, 28);
            this.btnSPrevious.TabIndex = 5;
            this.btnSPrevious.Text = ">";
            this.btnSPrevious.UseVisualStyleBackColor = true;
            this.btnSPrevious.Click += new System.EventHandler(this.btnSPrevious_Click);
            // 
            // btnSNext
            // 
            this.btnSNext.Location = new System.Drawing.Point(71, 466);
            this.btnSNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnSNext.Name = "btnSNext";
            this.btnSNext.Size = new System.Drawing.Size(41, 28);
            this.btnSNext.TabIndex = 5;
            this.btnSNext.Text = "<";
            this.btnSNext.UseVisualStyleBackColor = true;
            this.btnSNext.Click += new System.EventHandler(this.btnSNext_Click);
            // 
            // btnSFirst
            // 
            this.btnSFirst.Location = new System.Drawing.Point(25, 466);
            this.btnSFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnSFirst.Name = "btnSFirst";
            this.btnSFirst.Size = new System.Drawing.Size(41, 28);
            this.btnSFirst.TabIndex = 5;
            this.btnSFirst.Text = "<<";
            this.btnSFirst.UseVisualStyleBackColor = true;
            this.btnSFirst.Click += new System.EventHandler(this.btnSFirst_Click);
            // 
            // pnGValidation
            // 
            this.pnGValidation.Controls.Add(this.btnGAnnuler);
            this.pnGValidation.Controls.Add(this.btnGValider);
            this.pnGValidation.Location = new System.Drawing.Point(13, 110);
            this.pnGValidation.Margin = new System.Windows.Forms.Padding(4);
            this.pnGValidation.Name = "pnGValidation";
            this.pnGValidation.Size = new System.Drawing.Size(116, 91);
            this.pnGValidation.TabIndex = 10;
            this.pnGValidation.Visible = false;
            // 
            // pnGModification
            // 
            this.pnGModification.Controls.Add(this.btnGSupprimer);
            this.pnGModification.Controls.Add(this.btnGModifier);
            this.pnGModification.Controls.Add(this.btnGAjouter);
            this.pnGModification.Location = new System.Drawing.Point(199, 110);
            this.pnGModification.Margin = new System.Windows.Forms.Padding(4);
            this.pnGModification.Name = "pnGModification";
            this.pnGModification.Size = new System.Drawing.Size(242, 91);
            this.pnGModification.TabIndex = 11;
            // 
            // pnSModification
            // 
            this.pnSModification.Controls.Add(this.btnSSupprimer);
            this.pnSModification.Controls.Add(this.btnSModifier);
            this.pnSModification.Controls.Add(this.btnSAjouter);
            this.pnSModification.Location = new System.Drawing.Point(52, 409);
            this.pnSModification.Margin = new System.Windows.Forms.Padding(4);
            this.pnSModification.Name = "pnSModification";
            this.pnSModification.Size = new System.Drawing.Size(397, 73);
            this.pnSModification.TabIndex = 12;
            // 
            // pnGroupe
            // 
            this.pnGroupe.Controls.Add(this.txtIDgroupe);
            this.pnGroupe.Controls.Add(this.label5);
            this.pnGroupe.Controls.Add(this.label4);
            this.pnGroupe.Controls.Add(this.txtGroupe);
            this.pnGroupe.Location = new System.Drawing.Point(13, 47);
            this.pnGroupe.Margin = new System.Windows.Forms.Padding(4);
            this.pnGroupe.Name = "pnGroupe";
            this.pnGroupe.Size = new System.Drawing.Size(435, 55);
            this.pnGroupe.TabIndex = 13;
            this.pnGroupe.Visible = false;
            // 
            // txtIDgroupe
            // 
            this.txtIDgroupe.Location = new System.Drawing.Point(32, 19);
            this.txtIDgroupe.Name = "txtIDgroupe";
            this.txtIDgroupe.Size = new System.Drawing.Size(143, 22);
            this.txtIDgroupe.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // pnSZoneText
            // 
            this.pnSZoneText.Controls.Add(this.label6);
            this.pnSZoneText.Controls.Add(this.txtIdStagiaire);
            this.pnSZoneText.Controls.Add(this.label3);
            this.pnSZoneText.Controls.Add(this.label2);
            this.pnSZoneText.Controls.Add(this.label1);
            this.pnSZoneText.Controls.Add(this.txtCin);
            this.pnSZoneText.Controls.Add(this.txtNom);
            this.pnSZoneText.Controls.Add(this.txtNum);
            this.pnSZoneText.Enabled = false;
            this.pnSZoneText.Location = new System.Drawing.Point(57, 215);
            this.pnSZoneText.Margin = new System.Windows.Forms.Padding(4);
            this.pnSZoneText.Name = "pnSZoneText";
            this.pnSZoneText.Size = new System.Drawing.Size(312, 186);
            this.pnSZoneText.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "IdStagiaire";
            // 
            // txtIdStagiaire
            // 
            this.txtIdStagiaire.Location = new System.Drawing.Point(133, 23);
            this.txtIdStagiaire.Name = "txtIdStagiaire";
            this.txtIdStagiaire.Size = new System.Drawing.Size(160, 22);
            this.txtIdStagiaire.TabIndex = 9;
            // 
            // pnSValidation
            // 
            this.pnSValidation.Controls.Add(this.btnSValider);
            this.pnSValidation.Controls.Add(this.btnSAnnuler);
            this.pnSValidation.Location = new System.Drawing.Point(92, 495);
            this.pnSValidation.Margin = new System.Windows.Forms.Padding(4);
            this.pnSValidation.Name = "pnSValidation";
            this.pnSValidation.Size = new System.Drawing.Size(315, 66);
            this.pnSValidation.TabIndex = 15;
            this.pnSValidation.Visible = false;
            // 
            // Stagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 572);
            this.Controls.Add(this.pnSValidation);
            this.Controls.Add(this.pnSZoneText);
            this.Controls.Add(this.pnGroupe);
            this.Controls.Add(this.pnSModification);
            this.Controls.Add(this.pnGModification);
            this.Controls.Add(this.pnGValidation);
            this.Controls.Add(this.pnSNavigation);
            this.Controls.Add(this.cbGroupe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stagiaire";
            this.Text = "Stagiaire";
            this.Load += new System.EventHandler(this.Stagiaire_Load);
            this.pnSNavigation.ResumeLayout(false);
            this.pnSNavigation.PerformLayout();
            this.pnGValidation.ResumeLayout(false);
            this.pnGModification.ResumeLayout(false);
            this.pnSModification.ResumeLayout(false);
            this.pnGroupe.ResumeLayout(false);
            this.pnGroupe.PerformLayout();
            this.pnSZoneText.ResumeLayout(false);
            this.pnSZoneText.PerformLayout();
            this.pnSValidation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroupe;
        private System.Windows.Forms.Button btnGAjouter;
        private System.Windows.Forms.TextBox txtGroupe;
        private System.Windows.Forms.Button btnGValider;
        private System.Windows.Forms.Button btnGModifier;
        private System.Windows.Forms.Button btnGSupprimer;
        private System.Windows.Forms.ListBox lsStagiaire;
        private System.Windows.Forms.TextBox txtChercher;
        private System.Windows.Forms.Button btnSChercher;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.Button btnSAjouter;
        private System.Windows.Forms.Button btnSModifier;
        private System.Windows.Forms.Button btnSSupprimer;
        private System.Windows.Forms.Button btnGAnnuler;
        private System.Windows.Forms.Button btnSAnnuler;
        private System.Windows.Forms.Button btnSValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnSNavigation;
        private System.Windows.Forms.Panel pnGValidation;
        private System.Windows.Forms.Panel pnGModification;
        private System.Windows.Forms.Panel pnSModification;
        private System.Windows.Forms.Panel pnGroupe;
        private System.Windows.Forms.Panel pnSZoneText;
        private System.Windows.Forms.Panel pnSValidation;
        private System.Windows.Forms.Button btnSLast;
        private System.Windows.Forms.Button btnSPrevious;
        private System.Windows.Forms.Button btnSNext;
        private System.Windows.Forms.Button btnSFirst;
        private System.Windows.Forms.TextBox txtIDgroupe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdStagiaire;
    }
}