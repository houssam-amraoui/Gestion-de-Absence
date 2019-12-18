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
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmAjouter = new System.Windows.Forms.Button();
            this.dgvEmploiTemps = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiTemps)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJour
            // 
            this.cbJour.FormattingEnabled = true;
            this.cbJour.Location = new System.Drawing.Point(111, 26);
            this.cbJour.Margin = new System.Windows.Forms.Padding(4);
            this.cbJour.Name = "cbJour";
            this.cbJour.Size = new System.Drawing.Size(224, 24);
            this.cbJour.TabIndex = 0;
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Location = new System.Drawing.Point(500, 111);
            this.txtTimeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.Size = new System.Drawing.Size(225, 22);
            this.txtTimeEnd.TabIndex = 1;
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Location = new System.Drawing.Point(111, 114);
            this.txtTimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(251, 22);
            this.txtTimeStart.TabIndex = 1;
            // 
            // txtActivite
            // 
            this.txtActivite.Location = new System.Drawing.Point(292, 203);
            this.txtActivite.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.Size = new System.Drawing.Size(292, 22);
            this.txtActivite.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TempsFin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "TempsDepart";
            // 
            // btnEmAjouter
            // 
            this.btnEmAjouter.Location = new System.Drawing.Point(788, 108);
            this.btnEmAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmAjouter.Name = "btnEmAjouter";
            this.btnEmAjouter.Size = new System.Drawing.Size(171, 28);
            this.btnEmAjouter.TabIndex = 4;
            this.btnEmAjouter.Text = "Ajouter";
            this.btnEmAjouter.UseVisualStyleBackColor = true;
            // 
            // dgvEmploiTemps
            // 
            this.dgvEmploiTemps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploiTemps.Location = new System.Drawing.Point(16, 310);
            this.dgvEmploiTemps.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmploiTemps.Name = "dgvEmploiTemps";
            this.dgvEmploiTemps.Size = new System.Drawing.Size(1035, 185);
            this.dgvEmploiTemps.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 523);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Activite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jour";
            // 
            // GestionEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEmploiTemps);
            this.Controls.Add(this.btnEmAjouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActivite);
            this.Controls.Add(this.txtTimeStart);
            this.Controls.Add(this.txtTimeEnd);
            this.Controls.Add(this.cbJour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionEmploi";
            this.Text = "GestionEmploi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiTemps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJour;
        private System.Windows.Forms.TextBox txtTimeEnd;
        private System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.TextBox txtActivite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmAjouter;
        private System.Windows.Forms.DataGridView dgvEmploiTemps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}