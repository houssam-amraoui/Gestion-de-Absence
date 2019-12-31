using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_de_Absence.model
{
    public class TimeRegistre
    {
        public string text;
        public EmTime timestart;
        public EmTime timeend;
        public Boolean isOutTime(TimeRegistre time)
        {
            if((this.timestart.getComparTime() > time.timestart.getComparTime() || 
                time.timestart.getComparTime()< this.timeend.getComparTime())&&
                (this.timestart.getComparTime() > time.timeend.getComparTime() ||
                time.timeend.getComparTime() < this.timeend.getComparTime()))
            return false;
            return true;
        }
    }
}
