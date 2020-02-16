namespace Gestion_de_Absence
{
    partial class User_Inscription
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameUsers = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMatiere = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbFonction = new System.Windows.Forms.ComboBox();
            this.txtId_Inscrire = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom d\'Utilisateur : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Matiére : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mot de passe : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fonction : ";
            // 
            // txtNameUsers
            // 
            this.txtNameUsers.Location = new System.Drawing.Point(148, 149);
            this.txtNameUsers.Name = "txtNameUsers";
            this.txtNameUsers.Size = new System.Drawing.Size(214, 22);
            this.txtNameUsers.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(148, 218);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(214, 22);
            this.txtLogin.TabIndex = 3;
            // 
            // txtMatiere
            // 
            this.txtMatiere.Location = new System.Drawing.Point(148, 182);
            this.txtMatiere.Name = "txtMatiere";
            this.txtMatiere.Size = new System.Drawing.Size(214, 22);
            this.txtMatiere.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 254);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(14, 355);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(181, 65);
            this.btnInscrire.TabIndex = 5;
            this.btnInscrire.Text = "Inscription";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(220, 355);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(181, 65);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cbFonction
            // 
            this.cbFonction.FormattingEnabled = true;
            this.cbFonction.Items.AddRange(new object[] {
            "Directeur",
            "Surviant Général",
            "Professeur"});
            this.cbFonction.Location = new System.Drawing.Point(148, 291);
            this.cbFonction.Name = "cbFonction";
            this.cbFonction.Size = new System.Drawing.Size(214, 24);
            this.cbFonction.TabIndex = 6;
            this.cbFonction.Text = "Choisissez votre fonction";
            // 
            // txtId_Inscrire
            // 
            this.txtId_Inscrire.Enabled = false;
            this.txtId_Inscrire.Location = new System.Drawing.Point(148, 109);
            this.txtId_Inscrire.Name = "txtId_Inscrire";
            this.txtId_Inscrire.Size = new System.Drawing.Size(214, 22);
            this.txtId_Inscrire.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(11, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id_Inscription : ";
            // 
            // User_Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 427);
            this.Controls.Add(this.cbFonction);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMatiere);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtId_Inscrire);
            this.Controls.Add(this.txtNameUsers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User_Inscription";
            this.Text = "User_Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameUsers;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMatiere;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cbFonction;
        private System.Windows.Forms.TextBox txtId_Inscrire;
        private System.Windows.Forms.Label label7;
    }
}