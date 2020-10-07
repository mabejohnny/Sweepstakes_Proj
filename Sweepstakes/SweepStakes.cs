using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //Member Variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;
        public int winnerRandomNumber;

        //Constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.Name = name; 
        }

        //Member Methods
        public void RegisterContestant(Contestant contestant) 
        {

            contestants.Add(contestant.RegistrationNumber, contestant); 
        }

        public Contestant PickWinner()
        {
            Random random = new Random();
            winnerRandomNumber = random.Next(1,contestants.Count);

            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(winnerRandomNumber == contestant.Key)
                {
                    return contestant.Value;  
                }
            }
            return null; 
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName + contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);
        }
    }
}
