using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        //Member Variables
        

        //Constructor
        public Simulation()
        {

        }

        //Member Methods
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm marketingFirm;
            ISweepstakesManager manager = null;
            string managerChoice = UserInterface.GetManangerInput();

            if(managerChoice == "Stack")
            {
                manager = new SweepstakesStackManager(); 
            }
            else if(managerChoice == "Queue")
            {
                manager = new SweepstakesQueueManager();
            }
            marketingFirm = new MarketingFirm(manager); 

        }
    }
}
