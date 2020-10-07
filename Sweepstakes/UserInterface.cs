using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static Contestant contestant = new Contestant();
        public static int regNumber = 0;

        //Member Methods
        public static string GetUserInputForFirstName()
        {
            Console.WriteLine("Please enter your first name:");
            return Console.ReadLine(); 
        }

        public static string GetUserInputForLastName()
        {
            Console.WriteLine("Please enter your last name:");
            return Console.ReadLine();
        }

       public static string GetUserInputForEmail()
       {
            Console.WriteLine("Please enter your email address:");
            return Console.ReadLine();
       }

       public static int GetUserInputForRegistrationNumber()
       {
            regNumber = + 1; 
            Console.WriteLine("Your registration number is:" + regNumber);
            
            return regNumber;
       }
    }
}
