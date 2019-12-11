using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_de_Absence.model
{
    public class Stagiaire
    {
        public int num;
        public string name;
        public string cin;
        public string groop;
        public Stagiaire() { }
        public Stagiaire(int num, string name, string cin, string groop)
        {
            this.num = num;
            this.name = name;
            this.cin = cin;
            this.groop = groop;
        }

    }
}
