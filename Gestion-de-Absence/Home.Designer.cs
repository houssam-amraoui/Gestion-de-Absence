﻿namespace Gestion_de_Absence
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModifier = new System.Windows.Forms.Button();
            this.cbGroupe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsPresence = new System.Windows.Forms.ListBox();
            this.lsAbsence = new System.Windows.Forms.ListBox();
            this.dgvEmploiGroupe = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.empt = new System.Windows.Forms.Button();
            this.panelabs = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.Picker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ref1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiGroupe)).BeginInit();
            this.panelabs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(47, 32);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(161, 33);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Inscrire/Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // cbGroupe
            // 
            this.cbGroupe.FormattingEnabled = true;
            this.cbGroupe.Location = new System.Drawing.Point(47, 73);
            this.cbGroupe.Margin = new System.Windows.Forms.Padding(4);
            this.cbGroupe.Name = "cbGroupe";
            this.cbGroupe.Size = new System.Drawing.Size(160, 24);
            this.cbGroupe.TabIndex = 1;
            this.cbGroupe.SelectedIndexChanged += new System.EventHandler(this.cbGroupe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 2;
            // 
            // lsPresence
            // 
            this.lsPresence.FormattingEnabled = true;
            this.lsPresence.ItemHeight = 16;
            this.lsPresence.Location = new System.Drawing.Point(19, 15);
            this.lsPresence.Margin = new System.Windows.Forms.Padding(4);
            this.lsPresence.Name = "lsPresence";
            this.lsPresence.Size = new System.Drawing.Size(365, 340);
            this.lsPresence.TabIndex = 3;
            // 
            // lsAbsence
            // 
            this.lsAbsence.FormattingEnabled = true;
            this.lsAbsence.ItemHeight = 16;
            this.lsAbsence.Location = new System.Drawing.Point(501, 15);
            this.lsAbsence.Margin = new System.Windows.Forms.Padding(4);
            this.lsAbsence.Name = "lsAbsence";
            this.lsAbsence.Size = new System.Drawing.Size(380, 340);
            this.lsAbsence.TabIndex = 3;
            // 
            // dgvEmploiGroupe
            // 
            this.dgvEmploiGroupe.AllowUserToAddRows = false;
            this.dgvEmploiGroupe.AllowUserToDeleteRows = false;
            this.dgvEmploiGroupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploiGroupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvEmploiGroupe.Location = new System.Drawing.Point(28, 108);
            this.dgvEmploiGroupe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmploiGroupe.Name = "dgvEmploiGroupe";
            this.dgvEmploiGroupe.ReadOnly = true;
            this.dgvEmploiGroupe.Size = new System.Drawing.Size(917, 213);
            this.dgvEmploiGroupe.TabIndex = 4;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jour";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 122;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "08:30 - 11:00";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 122;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "11:00 - 13:30";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 122;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "13:30 - 16:00";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 122;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "16:00 - 18:30";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 122;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(393, 15);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(393, 327);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 28);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // empt
            // 
            this.empt.Location = new System.Drawing.Point(784, 65);
            this.empt.Margin = new System.Windows.Forms.Padding(4);
            this.empt.Name = "empt";
            this.empt.Size = new System.Drawing.Size(161, 33);
            this.empt.TabIndex = 0;
            this.empt.Text = "Modifer empt";
            this.empt.UseVisualStyleBackColor = true;
            this.empt.Click += new System.EventHandler(this.empt_Click);
            // 
            // panelabs
            // 
            this.panelabs.Controls.Add(this.btnPrevious);
            this.panelabs.Controls.Add(this.btnNext);
            this.panelabs.Controls.Add(this.lsAbsence);
            this.panelabs.Controls.Add(this.lsPresence);
            this.panelabs.Location = new System.Drawing.Point(28, 431);
            this.panelabs.Margin = new System.Windows.Forms.Padding(4);
            this.panelabs.Name = "panelabs";
            this.panelabs.Size = new System.Drawing.Size(917, 370);
            this.panelabs.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bonjour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 8;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "08:30 - 11:00",
            "11:00 - 13:30",
            "13:30 - 16:00",
            "16:00 - 18:30"});
            this.cb1.Location = new System.Drawing.Point(225, 6);
            this.cb1.Margin = new System.Windows.Forms.Padding(4);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(147, 24);
            this.cb1.TabIndex = 9;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_date_Changed);
            // 
            // Picker1
            // 
            this.Picker1.Location = new System.Drawing.Point(381, 6);
            this.Picker1.Margin = new System.Windows.Forms.Padding(4);
            this.Picker1.Name = "Picker1";
            this.Picker1.Size = new System.Drawing.Size(265, 22);
            this.Picker1.TabIndex = 10;
            this.Picker1.ValueChanged += new System.EventHandler(this.cb1_date_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "modifier un ancien absence";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Picker1);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(139, 379);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 44);
            this.panel1.TabIndex = 12;
            // 
            // ref1
            // 
            this.ref1.Location = new System.Drawing.Point(811, 338);
            this.ref1.Margin = new System.Windows.Forms.Padding(4);
            this.ref1.Name = "ref1";
            this.ref1.Size = new System.Drawing.Size(135, 28);
            this.ref1.TabIndex = 5;
            this.ref1.Text = "refreach to now";
            this.ref1.UseVisualStyleBackColor = true;
            this.ref1.Click += new System.EventHandler(this.ref1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 338);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "modifier absence ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 816);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ref1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelabs);
            this.Controls.Add(this.dgvEmploiGroupe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGroupe);
            this.Controls.Add(this.empt);
            this.Controls.Add(this.btnModifier);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiGroupe)).EndInit();
            this.panelabs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cbGroupe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsPresence;
        private System.Windows.Forms.ListBox lsAbsence;
        private System.Windows.Forms.DataGridView dgvEmploiGroupe;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button empt;
        private System.Windows.Forms.Panel panelabs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.DateTimePicker Picker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ref1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

