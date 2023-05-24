using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingClub.FieldValidators
{
    public class FieldConstants
    {
        public enum UserRegistrationField
        {
            EmailAddress, 
            FirstName, 
            LastName, 
            Password, 
            PasswordCompare, 
            DateOfBirth, 
            PhoneNumber, 
            AddressFirstLine, 
            AddressSecondLine,
            AdressCity, 
            Postcode
        }
    }
}
