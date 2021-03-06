﻿namespace Gestion_de_Absence
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
            this.lsStagiaire = new System.Windows.Forms.ListBox();
            this.txtChercher = new System.Windows.Forms.TextBox();
            this.btnSChercher = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.btnSAjouter = new System.Windows.Forms.Button();
            this.btnSModifier = new System.Windows.Forms.Button();
            this.btnSSupprimer = new System.Windows.Forms.Button();
            this.btnSAnnuler = new System.Windows.Forms.Button();
            this.btnSValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnSNavigation = new System.Windows.Forms.Panel();
            this.btnSLast = new System.Windows.Forms.Button();
            this.btnSPrevious = new System.Windows.Forms.Button();
            this.btnSNext = new System.Windows.Forms.Button();
            this.btnSFirst = new System.Windows.Forms.Button();
            this.pnSModification = new System.Windows.Forms.Panel();
            this.pnSZoneText = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdStagiaire = new System.Windows.Forms.TextBox();
            this.pnSValidation = new System.Windows.Forms.Panel();
            this.pnSNavigation.SuspendLayout();
            this.pnSModification.SuspendLayout();
            this.pnSZoneText.SuspendLayout();
            this.pnSValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsStagiaire
            // 
            this.lsStagiaire.FormattingEnabled = true;
            this.lsStagiaire.ItemHeight = 16;
            this.lsStagiaire.Location = new System.Drawing.Point(27, 40);
            this.lsStagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.lsStagiaire.Name = "lsStagiaire";
            this.lsStagiaire.Size = new System.Drawing.Size(348, 404);
            this.lsStagiaire.TabIndex = 12;
            // 
            // txtChercher
            // 
            this.txtChercher.Location = new System.Drawing.Point(25, 4);
            this.txtChercher.Margin = new System.Windows.Forms.Padding(4);
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.Size = new System.Drawing.Size(240, 22);
            this.txtChercher.TabIndex = 10;
            this.txtChercher.TextChanged += new System.EventHandler(this.txtChercher_TextChanged);
            // 
            // btnSChercher
            // 
            this.btnSChercher.Location = new System.Drawing.Point(275, 4);
            this.btnSChercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnSChercher.Name = "btnSChercher";
            this.btnSChercher.Size = new System.Drawing.Size(100, 28);
            this.btnSChercher.TabIndex = 11;
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
            this.txtNom.TabIndex = 3;
            // 
            // txtCin
            // 
            this.txtCin.Location = new System.Drawing.Point(133, 145);
            this.txtCin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(160, 22);
            this.txtCin.TabIndex = 4;
            // 
            // btnSAjouter
            // 
            this.btnSAjouter.Location = new System.Drawing.Point(25, 32);
            this.btnSAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnSAjouter.Name = "btnSAjouter";
            this.btnSAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnSAjouter.TabIndex = 5;
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
            this.btnSModifier.TabIndex = 6;
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
            this.btnSSupprimer.TabIndex = 7;
            this.btnSSupprimer.Text = "Supprimer";
            this.btnSSupprimer.UseVisualStyleBackColor = true;
            this.btnSSupprimer.Click += new System.EventHandler(this.btnSSupprimer_Click);
            // 
            // btnSAnnuler
            // 
            this.btnSAnnuler.Location = new System.Drawing.Point(177, 11);
            this.btnSAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnSAnnuler.Name = "btnSAnnuler";
            this.btnSAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnSAnnuler.TabIndex = 9;
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
            this.btnSValider.TabIndex = 8;
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
            // pnSNavigation
            // 
            this.pnSNavigation.Controls.Add(this.btnSLast);
            this.pnSNavigation.Controls.Add(this.btnSPrevious);
            this.pnSNavigation.Controls.Add(this.btnSNext);
            this.pnSNavigation.Controls.Add(this.btnSFirst);
            this.pnSNavigation.Controls.Add(this.txtChercher);
            this.pnSNavigation.Controls.Add(this.lsStagiaire);
            this.pnSNavigation.Controls.Add(this.btnSChercher);
            this.pnSNavigation.Location = new System.Drawing.Point(13, 8);
            this.pnSNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.pnSNavigation.Name = "pnSNavigation";
            this.pnSNavigation.Size = new System.Drawing.Size(391, 507);
            this.pnSNavigation.TabIndex = 9;
            // 
            // btnSLast
            // 
            this.btnSLast.Location = new System.Drawing.Point(333, 465);
            this.btnSLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnSLast.Name = "btnSLast";
            this.btnSLast.Size = new System.Drawing.Size(41, 28);
            this.btnSLast.TabIndex = 16;
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
            this.btnSPrevious.TabIndex = 15;
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
            this.btnSNext.TabIndex = 14;
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
            this.btnSFirst.TabIndex = 13;
            this.btnSFirst.Text = "<<";
            this.btnSFirst.UseVisualStyleBackColor = true;
            this.btnSFirst.Click += new System.EventHandler(this.btnSFirst_Click);
            // 
            // pnSModification
            // 
            this.pnSModification.Controls.Add(this.btnSSupprimer);
            this.pnSModification.Controls.Add(this.btnSModifier);
            this.pnSModification.Controls.Add(this.btnSAjouter);
            this.pnSModification.Location = new System.Drawing.Point(430, 271);
            this.pnSModification.Margin = new System.Windows.Forms.Padding(4);
            this.pnSModification.Name = "pnSModification";
            this.pnSModification.Size = new System.Drawing.Size(397, 73);
            this.pnSModification.TabIndex = 12;
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
            this.pnSZoneText.Location = new System.Drawing.Point(446, 60);
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
            this.txtIdStagiaire.Enabled = false;
            this.txtIdStagiaire.Location = new System.Drawing.Point(133, 23);
            this.txtIdStagiaire.Name = "txtIdStagiaire";
            this.txtIdStagiaire.Size = new System.Drawing.Size(160, 22);
            this.txtIdStagiaire.TabIndex = 1;
            // 
            // pnSValidation
            // 
            this.pnSValidation.Controls.Add(this.btnSValider);
            this.pnSValidation.Controls.Add(this.btnSAnnuler);
            this.pnSValidation.Location = new System.Drawing.Point(446, 352);
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
            this.ClientSize = new System.Drawing.Size(835, 516);
            this.Controls.Add(this.pnSValidation);
            this.Controls.Add(this.pnSZoneText);
            this.Controls.Add(this.pnSModification);
            this.Controls.Add(this.pnSNavigation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stagiaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stagiaire";
            this.Load += new System.EventHandler(this.Stagiaire_Load);
            this.pnSNavigation.ResumeLayout(false);
            this.pnSNavigation.PerformLayout();
            this.pnSModification.ResumeLayout(false);
            this.pnSZoneText.ResumeLayout(false);
            this.pnSZoneText.PerformLayout();
            this.pnSValidation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lsStagiaire;
        private System.Windows.Forms.TextBox txtChercher;
        private System.Windows.Forms.Button btnSChercher;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.Button btnSAjouter;
        private System.Windows.Forms.Button btnSModifier;
        private System.Windows.Forms.Button btnSSupprimer;
        private System.Windows.Forms.Button btnSAnnuler;
        private System.Windows.Forms.Button btnSValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnSNavigation;
        private System.Windows.Forms.Panel pnSModification;
        private System.Windows.Forms.Panel pnSZoneText;
        private System.Windows.Forms.Panel pnSValidation;
        private System.Windows.Forms.Button btnSLast;
        private System.Windows.Forms.Button btnSPrevious;
        private System.Windows.Forms.Button btnSNext;
        private System.Windows.Forms.Button btnSFirst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdStagiaire;
    }
}