﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_Absence
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.ShowDialog();
        }
    }
}
