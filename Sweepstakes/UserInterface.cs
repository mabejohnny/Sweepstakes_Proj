using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
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
            //set regNumber equal to dictionary key
            Console.WriteLine("Your registration number is:" + regNumber);
            return regNumber;
       }

        public static string GetManangerInput()
        {
            Console.WriteLine("Would you like to work with Stack or Queue Manager?");
            Console.WriteLine(" Press : '1'  for Stack Manager" + "\n" + " Press : '2' for Queue Manager");
            string managerChoice = Console.ReadLine();

            switch (managerChoice)
            {
                case "1":
                return "Stack";
                case "2":
                    return "Queue";
                default:
                    Console.WriteLine(" * Error *  Please Try Again");
                    Console.Clear();
                    GetManangerInput();
                    break;
            }
            return null;
        }
    }
}
