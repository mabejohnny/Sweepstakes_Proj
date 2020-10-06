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
            return Console.ReadLine(); 
        }

        static string GetUserInputForLastName()
        {
            Console.WriteLine("Please enter your last name:");
            return Console.ReadLine();
        }

        static string GetUserInputForEmail()
        {
            Console.WriteLine("Please enter your email address:");
            return Console.ReadLine();
        }

        static string GetUserInputForRegistrationNumber()
        {
            Console.WriteLine("Please enter your registration number:");
            return Console.ReadLine();
        }
    }
}
