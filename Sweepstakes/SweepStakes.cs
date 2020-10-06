using System;
using System.Collections.Generic;
using System.Linq;
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
        

        //Constructor
        public Sweepstakes(string name)
        {
            this.Name = name; 

        }

        //Member Methods
        public void RegisterContestant(Contestant contestant)
        {

        }

        public Contestant PickWinner()
        {
            

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.registrationNumber);

        }
    }
}
