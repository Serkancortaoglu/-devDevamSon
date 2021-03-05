using System;
using System.Collections.Generic;
using System.Text;

namespace ÖdevDevamSon
{
    class Validation : IValidation
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1998 && gamer.IdentiytNumber==46771 && gamer.FirstName=="SERKAN" && gamer.LastName == "CORTA")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
