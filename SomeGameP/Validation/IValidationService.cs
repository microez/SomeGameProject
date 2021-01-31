using System;
using System.Collections.Generic;
using System.Text;
using SomeGameP.Props;

namespace SomeGameP
{
    public interface IValidationService
    {
        bool Validate(Gamer gamer);
    }
}
