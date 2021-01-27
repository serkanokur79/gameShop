using Day05HW05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day05HW05.Manager
{
    class UserValidationManager : IPersonValidationService
    {
        public bool Validate(IPerson person)
        {
            if(person.TcNo == 1234567890)
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
