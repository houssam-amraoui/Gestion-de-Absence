namespace Gestion_de_Absence
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiGroupe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(47, 32);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(161, 33);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifer";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(845, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lsPresence
            // 
            this.lsPresence.FormattingEnabled = true;
            this.lsPresence.ItemHeight = 16;
            this.lsPresence.Location = new System.Drawing.Point(28, 300);
            this.lsPresence.Margin = new System.Windows.Forms.Padding(4);
            this.lsPresence.Name = "lsPresence";
            this.lsPresence.Size = new System.Drawing.Size(365, 340);
            this.lsPresence.TabIndex = 3;
            // 
            // lsAbsence
            // 
            this.lsAbsence.FormattingEnabled = true;
            this.lsAbsence.ItemHeight = 16;
            this.lsAbsence.Location = new System.Drawing.Point(511, 300);
            this.lsAbsence.Margin = new System.Windows.Forms.Padding(4);
            this.lsAbsence.Name = "lsAbsence";
            this.lsAbsence.Size = new System.Drawing.Size(380, 340);
            this.lsAbsence.TabIndex = 3;
            // 
            // dgvEmploiGroupe
            // 
            this.dgvEmploiGroupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploiGroupe.Location = new System.Drawing.Point(28, 108);
            this.dgvEmploiGroupe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmploiGroupe.Name = "dgvEmploiGroupe";
            this.dgvEmploiGroupe.Size = new System.Drawing.Size(864, 185);
            this.dgvEmploiGroupe.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(403, 300);
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
            this.btnPrevious.Location = new System.Drawing.Point(403, 613);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 28);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 656);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvEmploiGroupe);
            this.Controls.Add(this.lsAbsence);
            this.Controls.Add(this.lsPresence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGroupe);
            this.Controls.Add(this.btnModifier);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploiGroupe)).EndInit();
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
    }
}

