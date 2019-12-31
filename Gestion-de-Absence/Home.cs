using System;
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
        BindingSource bs;
        BindingSource bs2;
        public Home()
        {
            InitializeComponent();
        }
          private void Home_Load(object sender, EventArgs e)
          {
            bs= model.BaseDonnee.RemplirListControl(cbGroupe,"Groupe", "nomgroupe", "idgroupe");
            bs2 = model.BaseDonnee.remplirListeRel(lsPresence, "Stagiaire", "name", "idstagiaire", "Groupe", "idgroupe", "idgroupe", bs);
         }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lsAbsence.Items.Add(lsPresence.Text);
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            lsPresence.Items.Add(lsAbsence.Text);
        }
    }
}
