using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Entities
{
    interface IPersonValidationService
    {
        bool Validate(IPerson person);
    }
}
