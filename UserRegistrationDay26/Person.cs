using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationDay26
{
    internal class Person
    {
        public string FirstName, LastName, Email, MobileNumber, Password;
        public Person(string firstName, string lastName, string email, string mobileNumber, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            MobileNumber = mobileNumber;
            Password = password;


        }
    }
}

