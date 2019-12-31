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
        public void settime(string time)
        {
            this.Hous = Convert.ToInt32(time.Substring(0, 2));
            this.min = Convert.ToInt32(time.Substring(3, 5));
        }
        public override string ToString()
        {
            return Hous + ":" + min;
        
    }
        public float getComparTime()
        {
            return Hous + (min / 60);
        }
    }
}
