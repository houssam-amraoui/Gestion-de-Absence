namespace Gestion_de_Absence
{
    partial class Inscription
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
            this.cbGroupe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtAnneScholaire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStagiaire = new System.Windows.Forms.Button();
            this.btnGroupe = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.pnModification = new System.Windows.Forms.Panel();
            this.pnValidation = new System.Windows.Forms.Panel();
            this.pnNouveautie = new System.Windows.Forms.Panel();
            this.txtidStagiaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnNavigation.SuspendLayout();
            this.pnModification.SuspendLayout();
            this.pnValidation.SuspendLayout();
            this.pnNouveautie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsStagiaire
            // 
            this.lsStagiaire.FormattingEnabled = true;
            this.lsStagiaire.ItemHeight = 16;
            this.lsStagiaire.Location = new System.Drawing.Point(3, 22);
            this.lsStagiaire.Name = "lsStagiaire";
            this.lsStagiaire.Size = new System.Drawing.Size(198, 260);
            this.lsStagiaire.TabIndex = 0;
            // 
            // cbGroupe
            // 
            this.cbGroupe.Enabled = false;
            this.cbGroupe.FormattingEnabled = true;
            this.cbGroupe.Location = new System.Drawing.Point(382, 152);
            this.cbGroupe.Name = "cbGroupe";
            this.cbGroupe.Size = new System.Drawing.Size(206, 24);
            this.cbGroupe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(249, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NomStagiaire :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(248, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Groupe :";
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(40, 21);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(114, 34);
            this.btnmodifier.TabIndex = 4;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(160, 21);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(114, 34);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(19, 19);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(114, 34);
            this.btnvalider.TabIndex = 4;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(137, 19);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(114, 34);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtAnneScholaire
            // 
            this.txtAnneScholaire.Enabled = false;
            this.txtAnneScholaire.Location = new System.Drawing.Point(382, 182);
            this.txtAnneScholaire.Name = "txtAnneScholaire";
            this.txtAnneScholaire.Size = new System.Drawing.Size(206, 22);
            this.txtAnneScholaire.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(248, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "AnneeScholaire :";
            // 
            // btnStagiaire
            // 
            this.btnStagiaire.Location = new System.Drawing.Point(2, 24);
            this.btnStagiaire.Name = "btnStagiaire";
            this.btnStagiaire.Size = new System.Drawing.Size(239, 37);
            this.btnStagiaire.TabIndex = 6;
            this.btnStagiaire.Text = "Nouveau Stagiaire";
            this.btnStagiaire.UseVisualStyleBackColor = true;
            this.btnStagiaire.Click += new System.EventHandler(this.btnStagiaire_Click);
            // 
            // btnGroupe
            // 
            this.btnGroupe.Location = new System.Drawing.Point(359, 24);
            this.btnGroupe.Name = "btnGroupe";
            this.btnGroupe.Size = new System.Drawing.Size(239, 37);
            this.btnGroupe.TabIndex = 6;
            this.btnGroupe.Text = "Nouveau Groupe";
            this.btnGroupe.UseVisualStyleBackColor = true;
            this.btnGroupe.Click += new System.EventHandler(this.btnGroupe_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(382, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 22);
            this.txtName.TabIndex = 1;
            // 
            // pnNavigation
            // 
            this.pnNavigation.Controls.Add(this.lsStagiaire);
            this.pnNavigation.Location = new System.Drawing.Point(9, 14);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(213, 298);
            this.pnNavigation.TabIndex = 7;
            // 
            // pnModification
            // 
            this.pnModification.Controls.Add(this.btnSupprimer);
            this.pnModification.Controls.Add(this.btnmodifier);
            this.pnModification.Location = new System.Drawing.Point(251, 210);
            this.pnModification.Name = "pnModification";
            this.pnModification.Size = new System.Drawing.Size(288, 64);
            this.pnModification.TabIndex = 9;
            // 
            // pnValidation
            // 
            this.pnValidation.Controls.Add(this.btnAnnuler);
            this.pnValidation.Controls.Add(this.btnvalider);
            this.pnValidation.Location = new System.Drawing.Point(258, 276);
            this.pnValidation.Name = "pnValidation";
            this.pnValidation.Size = new System.Drawing.Size(269, 74);
            this.pnValidation.TabIndex = 10;
            this.pnValidation.Visible = false;
            // 
            // pnNouveautie
            // 
            this.pnNouveautie.Controls.Add(this.btnGroupe);
            this.pnNouveautie.Controls.Add(this.btnStagiaire);
            this.pnNouveautie.Location = new System.Drawing.Point(10, 356);
            this.pnNouveautie.Name = "pnNouveautie";
            this.pnNouveautie.Size = new System.Drawing.Size(607, 74);
            this.pnNouveautie.TabIndex = 11;
            // 
            // txtidStagiaire
            // 
            this.txtidStagiaire.Enabled = false;
            this.txtidStagiaire.Location = new System.Drawing.Point(382, 96);
            this.txtidStagiaire.Name = "txtidStagiaire";
            this.txtidStagiaire.Size = new System.Drawing.Size(206, 22);
            this.txtidStagiaire.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(249, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "IdSagiaire:";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidStagiaire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnNouveautie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnValidation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnModification);
            this.Controls.Add(this.cbGroupe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAnneScholaire);
            this.Controls.Add(this.pnNavigation);
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inscription_FormClosing);
            this.Load += new System.EventHandler(this.Inscription_Load);
            this.pnNavigation.ResumeLayout(false);
            this.pnModification.ResumeLayout(false);
            this.pnValidation.ResumeLayout(false);
            this.pnNouveautie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsStagiaire;
        private System.Windows.Forms.ComboBox cbGroupe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtAnneScholaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStagiaire;
        private System.Windows.Forms.Button btnGroupe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Panel pnModification;
        private System.Windows.Forms.Panel pnValidation;
        private System.Windows.Forms.Panel pnNouveautie;
        private System.Windows.Forms.TextBox txtidStagiaire;
        private System.Windows.Forms.Label label1;
    }
}