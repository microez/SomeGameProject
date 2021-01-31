using SomeGameP.Props;
using System;
using System.Collections.Generic;
using System.Text;

namespace SomeGameP.Validation
{
    class UserValidation : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDate == 2003 && gamer.FirstName=="DON" && gamer.LastName=="OMAR")
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
