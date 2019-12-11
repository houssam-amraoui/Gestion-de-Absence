using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_de_Absence.model
{
    public class EmTime
    {
        public int Hous;
        public int min;

        public override string ToString()
        {
            return Hous + ":" + min;
        }
    }
}
