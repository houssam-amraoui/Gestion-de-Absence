namespace Gestion_de_Absence
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
            this.txtactivite = new System.Windows.Forms.TextBox();
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
            this.cbtime = new System.Windows.Forms.ComboBox();
            this.grop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_supr = new System.Windows.Forms.Button();
            this.cbusers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.cbJour.Location = new System.Drawing.Point(70, 21);
            this.cbJour.Name = "cbJour";
            this.cbJour.Size = new System.Drawing.Size(104, 21);
            this.cbJour.TabIndex = 0;
            this.cbJour.Text = "choose a day";
            // 
            // txtactivite
            // 
            this.txtactivite.Location = new System.Drawing.Point(283, 64);
            this.txtactivite.Name = "txtactivite";
            this.txtactivite.Size = new System.Drawing.Size(174, 20);
            this.txtactivite.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temps";
            // 
            // btnEmAjouter
            // 
            this.btnEmAjouter.Location = new System.Drawing.Point(555, 116);
            this.btnEmAjouter.Name = "btnEmAjouter";
            this.btnEmAjouter.Size = new System.Drawing.Size(129, 33);
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
            this.dgvEmploiTemps.Location = new System.Drawing.Point(10, 167);
            this.dgvEmploiTemps.Name = "dgvEmploiTemps";
            this.dgvEmploiTemps.ReadOnly = true;
            this.dgvEmploiTemps.Size = new System.Drawing.Size(670, 192);
            this.dgvEmploiTemps.TabIndex = 5;
            // 
            // jour
            // 
            this.jour.HeaderText = "Jour";
            this.jour.Name = "jour";
            this.jour.ReadOnly = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Activite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jour";
            // 
            // cbtime
            // 
            this.cbtime.FormattingEnabled = true;
            this.cbtime.Items.AddRange(new object[] {
            "08:30 - 11:00",
            "11:00 - 13:30",
            "13:30 - 16:00",
            "16:00 - 18:30"});
            this.cbtime.Location = new System.Drawing.Point(70, 61);
            this.cbtime.Margin = new System.Windows.Forms.Padding(2);
            this.cbtime.Name = "cbtime";
            this.cbtime.Size = new System.Drawing.Size(104, 21);
            this.cbtime.TabIndex = 9;
            this.cbtime.Text = "choose a time";
            // 
            // grop
            // 
            this.grop.FormattingEnabled = true;
            this.grop.Location = new System.Drawing.Point(581, 24);
            this.grop.Name = "grop";
            this.grop.Size = new System.Drawing.Size(99, 21);
            this.grop.TabIndex = 0;
            this.grop.SelectedIndexChanged += new System.EventHandler(this.grop_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Groope";
            // 
            // btn_supr
            // 
            this.btn_supr.Location = new System.Drawing.Point(406, 116);
            this.btn_supr.Name = "btn_supr";
            this.btn_supr.Size = new System.Drawing.Size(129, 33);
            this.btn_supr.TabIndex = 4;
            this.btn_supr.Text = "Supprimer";
            this.btn_supr.UseVisualStyleBackColor = true;
            this.btn_supr.Click += new System.EventHandler(this.btn_supr_Click);
            // 
            // cbusers
            // 
            this.cbusers.FormattingEnabled = true;
            this.cbusers.Location = new System.Drawing.Point(581, 61);
            this.cbusers.Name = "cbusers";
            this.cbusers.Size = new System.Drawing.Size(99, 21);
            this.cbusers.TabIndex = 0;
            this.cbusers.Text = "choose teacher";
            this.cbusers.SelectedIndexChanged += new System.EventHandler(this.grop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Users";
            // 
            // txtsalle
            // 
            this.txtsalle.Location = new System.Drawing.Point(283, 22);
            this.txtsalle.Name = "txtsalle";
            this.txtsalle.Size = new System.Drawing.Size(174, 20);
            this.txtsalle.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salle";
            // 
            // GestionEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.cbtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEmploiTemps);
            this.Controls.Add(this.btn_supr);
            this.Controls.Add(this.btnEmAjouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbusers);
            this.Controls.Add(this.txtsalle);
            this.Controls.Add(this.txtactivite);
            this.Controls.Add(this.grop);
            this.Controls.Add(this.cbJour);
            this.MaximizeBox = false;
            this.Name = "GestionEmploi";
            this.Text = "GestionEmploi";
            this.Load += new System.EventHandler(this.GestionEmploi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiTemps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJour;
        private System.Windows.Forms.TextBox txtactivite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmAjouter;
        private System.Windows.Forms.DataGridView dgvEmploiTemps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox grop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_supr;
        private System.Windows.Forms.ComboBox cbusers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsalle;
        private System.Windows.Forms.Label label7;
    }
}