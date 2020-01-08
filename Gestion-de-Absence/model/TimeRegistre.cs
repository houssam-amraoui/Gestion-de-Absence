using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_de_Absence.model
{
    public class TimeRegistre
    {
        public string text;
        public int timestart;
        
        public Boolean isOutTime(TimeRegistre time)
        {
            return true;
        }
    }
}
