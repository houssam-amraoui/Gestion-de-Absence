﻿namespace Gestion_de_Absence
{
    partial class GestionEmploi
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
            this.cbJour = new System.Windows.Forms.ComboBox();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmAjouter = new System.Windows.Forms.Button();
            this.dgvEmploiTemps = new System.Windows.Forms.DataGridView();
            this.jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiTemps)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJour
            // 
            this.cbJour.FormattingEnabled = true;
            this.cbJour.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mecredi",
            "Jeudi",
            "Vendredi",
            "Samedi"});
            this.cbJour.Location = new System.Drawing.Point(94, 26);
            this.cbJour.Margin = new System.Windows.Forms.Padding(4);
            this.cbJour.Name = "cbJour";
            this.cbJour.Size = new System.Drawing.Size(137, 24);
            this.cbJour.TabIndex = 0;
            this.cbJour.Text = "choose a day";
            // 
            // txtActivite
            // 
            this.txtActivite.Location = new System.Drawing.Point(377, 114);
            this.txtActivite.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.Size = new System.Drawing.Size(230, 22);
            this.txtActivite.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temps";
            // 
            // btnEmAjouter
            // 
            this.btnEmAjouter.Location = new System.Drawing.Point(715, 126);
            this.btnEmAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmAjouter.Name = "btnEmAjouter";
            this.btnEmAjouter.Size = new System.Drawing.Size(191, 47);
            this.btnEmAjouter.TabIndex = 4;
            this.btnEmAjouter.Text = "Ajouter";
            this.btnEmAjouter.UseVisualStyleBackColor = true;
            this.btnEmAjouter.Click += new System.EventHandler(this.btnEmAjouter_Click);
            // 
            // dgvEmploiTemps
            // 
            this.dgvEmploiTemps.AllowUserToAddRows = false;
            this.dgvEmploiTemps.AllowUserToDeleteRows = false;
            this.dgvEmploiTemps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploiTemps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jour,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvEmploiTemps.Location = new System.Drawing.Point(13, 206);
            this.dgvEmploiTemps.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmploiTemps.Name = "dgvEmploiTemps";
            this.dgvEmploiTemps.Size = new System.Drawing.Size(893, 236);
            this.dgvEmploiTemps.TabIndex = 5;
            // 
            // jour
            // 
            this.jour.HeaderText = "Jour";
            this.jour.Name = "jour";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "08:30 - 11:00";
            this.Column1.Name = "Column1";
            this.Column1.Width = 122;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "11:00 - 13:30";
            this.Column2.Name = "Column2";
            this.Column2.Width = 122;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "13:30 - 16:00";
            this.Column3.Name = "Column3";
            this.Column3.Width = 122;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "16:00 - 18:30";
            this.Column4.Name = "Column4";
            this.Column4.Width = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 470);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Activite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jour";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "08:30 - 11:00",
            "11:00 - 13:30",
            "13:30 - 16:00",
            "16:00 - 18:30"});
            this.comboBox1.Location = new System.Drawing.Point(94, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "choose a time";
            // 
            // grop
            // 
            this.grop.FormattingEnabled = true;
            this.grop.Location = new System.Drawing.Point(775, 29);
            this.grop.Margin = new System.Windows.Forms.Padding(4);
            this.grop.Name = "grop";
            this.grop.Size = new System.Drawing.Size(131, 24);
            this.grop.TabIndex = 0;
            this.grop.SelectedIndexChanged += new System.EventHandler(this.grop_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Groope";
            // 
            // GestionEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEmploiTemps);
            this.Controls.Add(this.btnEmAjouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtActivite);
            this.Controls.Add(this.grop);
            this.Controls.Add(this.cbJour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionEmploi";
            this.Text = "GestionEmploi";
            this.Load += new System.EventHandler(this.GestionEmploi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiTemps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJour;
        private System.Windows.Forms.TextBox txtActivite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmAjouter;
        private System.Windows.Forms.DataGridView dgvEmploiTemps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox grop;
        private System.Windows.Forms.Label label6;
    }
}