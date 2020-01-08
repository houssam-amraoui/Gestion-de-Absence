using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_de_Absence.model
{
    public class Jour
    {
       public List<TimeRegistre> tmr = new List<TimeRegistre>();
        public string jour;
        public string groupe;
    }
}
