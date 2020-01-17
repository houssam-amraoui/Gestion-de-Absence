using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_de_Absence.model
{
    public class Users
    {
        public int idusers;
        public string nameusers;
        public int priorite;
       public Users() { }
       public Users(int idusers , string nameusers, int priorite) {
            this.idusers = idusers;
            this.nameusers = nameusers;
            this.priorite = priorite;
        }
        
    }
}
