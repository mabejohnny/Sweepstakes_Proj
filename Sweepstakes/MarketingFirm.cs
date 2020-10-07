using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{

    // (5 points) As a developer, I want to document (text file, comment in code, etc.)
    // where I am using dependency injection and what benefits it adds to the structure of my application.

    // I am using dependency injection in my MarketingFirm when it comes to choosing between SweepstakesQueueManager and SweepstakesStackManager
    // I have it structured so that I am only using one constructor in this class, passing in the manager object that was chosen by the user
    // prior to this.  This structure benefits my application because it elliminates extra code (multiple constructors based on both a stack and queue manager
    // this is dependent on any manager type, not hard coded to a paticular manager.

    class MarketingFirm
    {
        //Member Variables
        public ISweepstakesManager manager;

        //Constructor
        public MarketingFirm(ISweepstakesManager manager) 
        {
            this.manager = manager;
        }

        //Member Methods
        public void CreateSweepStakes(string name)
        {
            
            manager.InsertSweepstakes(UserInterface.NewSweepstakes(name));

        }
    }
}
