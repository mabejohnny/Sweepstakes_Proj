using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        static Contestant contestant = new Contestant();




        //Member Methods
        static string GetUserInputForFirstName()
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine(); 

            if(firstName == string.Empty)
            {
                Console.WriteLine("Error! Please try again:");
                GetUserInputForFirstName();
                Console.Clear();
            }
            else
            {
                return firstName;  
            }
            return firstName;
        }

        static string GetUserInputForLastName()
        {
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            if (lastName == string.Empty)
            {
                Console.WriteLine("Error! Please try again:");
                GetUserInputForLastName();
                Console.Clear();
            }
            else
            {
                return lastName;
            }
            return lastName;
        }

        static string GetUserInputForEmail()
        {
            Console.WriteLine("Please enter your email address:");
            string emailAddress = Console.ReadLine();

            if (emailAddress == string.Empty)
            {
                Console.WriteLine("Error! Please try again:");
                GetUserInputForLastName();
                Console.Clear();
            }
            else
            {
                return emailAddress;
            }
            return emailAddress;
        }

        static string GetUserInputForRegistrationNumber()
        {
            Console.WriteLine("Please enter your registration number:");
            string registrationNumber = Console.ReadLine();

            if (registrationNumber == string.Empty)
            {
                Console.WriteLine("Error! Please try again:");
                GetUserInputForLastName();
                Console.Clear();
            }
            else
            {
                return registrationNumber;
            }
            return registrationNumber;
        }




    }
}
