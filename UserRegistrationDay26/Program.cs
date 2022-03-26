using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationDay26
{
    public class Program : Exception
    {
        public static string firstName, lastName, email, mobileNumber, password;
        public enum ExceptionType
        {
            Invalid_FirstName, Invalid_LastName, Invalid_Email, Invalid_MobileNumber, Invalid_Password
        }
        private readonly ExceptionType type;

        public static void Main(string[] args)
        {
            Console.WriteLine("User Registration");
            //UC 13
            AddRecords();
           

        }
        public static void AddRecords()
        {
            Console.WriteLine("Enter First Name, Last Name,Email, MobileNumber,Password");
            string firstname=Console.ReadLine();
            string lastname=Console.ReadLine();
            string email=Console.ReadLine();
            string mobileNumber=Console.ReadLine();
            string password=Console.ReadLine();
            Console.WriteLine("First Name Check");
            Check(firstname);
            Console.WriteLine("Last Name Check");
            Check(lastname);
            Console.WriteLine("Email Check");
            Check(email);
            Console.WriteLine("Mobile Check");
            Check(mobileNumber);
            Console.WriteLine("Password Check");
            Check(password);


            void Check(string value)
            {
                Regex firstAndLastName = new Regex("^[A-Z][a-z]{3,}$");
                Regex emailcheck = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                Regex mobileNumbercheck = new Regex(@"^([0-9]{2})\s([0-9]{10})$");
                Regex passwordCheck = new Regex(@"^([A-Za-z]{7,})([`~!@#$%^&*()_+=:;.,'<>/|\?]{1})([0-9]{1,})$");
                if (firstAndLastName.Match(value).Success)
                {
                    Console.WriteLine("Success");
                }
                else if (firstAndLastName.Match(value).Success)
                {
                    Console.WriteLine("Success");
                }
                else if (emailcheck.Match(value).Success)
                {
                    Console.WriteLine("Success");
                }
                else if (mobileNumbercheck.Match(value).Success)
                {
                    Console.WriteLine("Success");
                }
                else if (passwordCheck.Match(value).Success)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
          
        }



    }
}