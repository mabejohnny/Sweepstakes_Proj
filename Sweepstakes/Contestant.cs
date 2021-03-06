﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //Member Variables
        public static Contestant contestant = new Contestant();
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        //Constructor
        public Contestant() 
        {
            FirstName = UserInterface.GetUserInputForFirstName();
            LastName = UserInterface.GetUserInputForLastName();
            EmailAddress = UserInterface.GetUserInputForEmail();
            RegistrationNumber = UserInterface.GetUserInputForRegistrationNumber();
        }
    }
}
