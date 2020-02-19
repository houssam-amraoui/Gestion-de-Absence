namespace Gestion_de_Absence
{
    partial class Groupe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroupe = new System.Windows.Forms.TextBox();
            this.btnGAjouter = new System.Windows.Forms.Button();
            this.btnGSupprimer = new System.Windows.Forms.Button();
            this.btnGModifier = new System.Windows.Forms.Button();
            this.btnGValider = new System.Windows.Forms.Button();
            this.btnGAnnuler = new System.Windows.Forms.Button();
            this.pnGNavigation = new System.Windows.Forms.Panel();
            this.pnGZoneTexte = new System.Windows.Forms.Panel();
            this.txtIdgroupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnGModification = new System.Windows.Forms.Panel();
            this.pnGValidation = new System.Windows.Forms.Panel();
            this.pnGNavigation.SuspendLayout();
            this.pnGZoneTexte.SuspendLayout();
            this.pnGModification.SuspendLayout();
            this.pnGValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGroupe
            // 
            this.cbGroupe.FormattingEnabled = true;
            this.cbGroupe.Location = new System.Drawing.Point(18, 37);
            this.cbGroupe.Name = "cbGroupe";
            this.cbGroupe.Size = new System.Drawing.Size(277, 24);
            this.cbGroupe.TabIndex = 0;
            this.cbGroupe.Text = "Selectionner un groupe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Groupe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NomGroupe : ";
            // 
            // txtGroupe
            // 
            this.txtGroupe.Location = new System.Drawing.Point(114, 51);
            this.txtGroupe.Name = "txtGroupe";
            this.txtGroupe.Size = new System.Drawing.Size(193, 22);
            this.txtGroupe.TabIndex = 3;
            // 
            // btnGAjouter
            // 
            this.btnGAjouter.Location = new System.Drawing.Point(17, 16);
            this.btnGAjouter.Name = "btnGAjouter";
            this.btnGAjouter.Size = new System.Drawing.Size(92, 30);
            this.btnGAjouter.TabIndex = 4;
            this.btnGAjouter.Text = "Ajouter";
            this.btnGAjouter.UseVisualStyleBackColor = true;
            this.btnGAjouter.Click += new System.EventHandler(this.btnGAjouter_Click);
            // 
            // btnGSupprimer
            // 
            this.btnGSupprimer.Location = new System.Drawing.Point(68, 52);
            this.btnGSupprimer.Name = "btnGSupprimer";
            this.btnGSupprimer.Size = new System.Drawing.Size(92, 30);
            this.btnGSupprimer.TabIndex = 4;
            this.btnGSupprimer.Text = "Supprimer";
            this.btnGSupprimer.UseVisualStyleBackColor = true;
            this.btnGSupprimer.Click += new System.EventHandler(this.btnGSupprimer_Click);
            // 
            // btnGModifier
            // 
            this.btnGModifier.Location = new System.Drawing.Point(115, 16);
            this.btnGModifier.Name = "btnGModifier";
            this.btnGModifier.Size = new System.Drawing.Size(92, 30);
            this.btnGModifier.TabIndex = 4;
            this.btnGModifier.Text = "Modifier";
            this.btnGModifier.UseVisualStyleBackColor = true;
            this.btnGModifier.Click += new System.EventHandler(this.btnGModifier_Click);
            // 
            // btnGValider
            // 
            this.btnGValider.Location = new System.Drawing.Point(21, 19);
            this.btnGValider.Name = "btnGValider";
            this.btnGValider.Size = new System.Drawing.Size(84, 29);
            this.btnGValider.TabIndex = 4;
            this.btnGValider.Text = "Valider";
            this.btnGValider.UseVisualStyleBackColor = true;
            this.btnGValider.Click += new System.EventHandler(this.btnGValider_Click);
            // 
            // btnGAnnuler
            // 
            this.btnGAnnuler.Location = new System.Drawing.Point(111, 19);
            this.btnGAnnuler.Name = "btnGAnnuler";
            this.btnGAnnuler.Size = new System.Drawing.Size(84, 29);
            this.btnGAnnuler.TabIndex = 4;
            this.btnGAnnuler.Text = "Annuler";
            this.btnGAnnuler.UseVisualStyleBackColor = true;
            this.btnGAnnuler.Click += new System.EventHandler(this.btnGAnnuler_Click);
            // 
            // pnGNavigation
            // 
            this.pnGNavigation.Controls.Add(this.label1);
            this.pnGNavigation.Controls.Add(this.cbGroupe);
            this.pnGNavigation.Location = new System.Drawing.Point(25, 5);
            this.pnGNavigation.Name = "pnGNavigation";
            this.pnGNavigation.Size = new System.Drawing.Size(309, 70);
            this.pnGNavigation.TabIndex = 5;
            // 
            // pnGZoneTexte
            // 
            this.pnGZoneTexte.Controls.Add(this.txtIdgroupe);
            this.pnGZoneTexte.Controls.Add(this.label3);
            this.pnGZoneTexte.Controls.Add(this.txtGroupe);
            this.pnGZoneTexte.Controls.Add(this.label2);
            this.pnGZoneTexte.Enabled = false;
            this.pnGZoneTexte.Location = new System.Drawing.Point(13, 81);
            this.pnGZoneTexte.Name = "pnGZoneTexte";
            this.pnGZoneTexte.Size = new System.Drawing.Size(337, 105);
            this.pnGZoneTexte.TabIndex = 6;
            // 
            // txtIdgroupe
            // 
            this.txtIdgroupe.Enabled = false;
            this.txtIdgroupe.Location = new System.Drawing.Point(114, 23);
            this.txtIdgroupe.Name = "txtIdgroupe";
            this.txtIdgroupe.Size = new System.Drawing.Size(193, 22);
            this.txtIdgroupe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "IdGroupe : ";
            // 
            // pnGModification
            // 
            this.pnGModification.Controls.Add(this.btnGModifier);
            this.pnGModification.Controls.Add(this.btnGSupprimer);
            this.pnGModification.Controls.Add(this.btnGAjouter);
            this.pnGModification.Location = new System.Drawing.Point(12, 201);
            this.pnGModification.Name = "pnGModification";
            this.pnGModification.Size = new System.Drawing.Size(221, 91);
            this.pnGModification.TabIndex = 7;
            // 
            // pnGValidation
            // 
            this.pnGValidation.Controls.Add(this.btnGAnnuler);
            this.pnGValidation.Controls.Add(this.btnGValider);
            this.pnGValidation.Location = new System.Drawing.Point(239, 226);
            this.pnGValidation.Name = "pnGValidation";
            this.pnGValidation.Size = new System.Drawing.Size(203, 57);
            this.pnGValidation.TabIndex = 8;
            this.pnGValidation.Visible = false;
            // 
            // Groupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 304);
            this.Controls.Add(this.pnGValidation);
            this.Controls.Add(this.pnGModification);
            this.Controls.Add(this.pnGZoneTexte);
            this.Controls.Add(this.pnGNavigation);
            this.Name = "Groupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groupe";
            this.Load += new System.EventHandler(this.Groupe_Load);
            this.pnGNavigation.ResumeLayout(false);
            this.pnGNavigation.PerformLayout();
            this.pnGZoneTexte.ResumeLayout(false);
            this.pnGZoneTexte.PerformLayout();
            this.pnGModification.ResumeLayout(false);
            this.pnGValidation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupe;
        private System.Windows.Forms.Button btnGAjouter;
        private System.Windows.Forms.Button btnGSupprimer;
        private System.Windows.Forms.Button btnGModifier;
        private System.Windows.Forms.Button btnGValider;
        private System.Windows.Forms.Button btnGAnnuler;
        private System.Windows.Forms.Panel pnGNavigation;
        private System.Windows.Forms.Panel pnGZoneTexte;
        private System.Windows.Forms.Panel pnGModification;
        private System.Windows.Forms.Panel pnGValidation;
        private System.Windows.Forms.TextBox txtIdgroupe;
        private System.Windows.Forms.Label label3;
    }
}