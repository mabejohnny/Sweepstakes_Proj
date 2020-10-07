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
        MarketingFirm marketingFirm = new MarketingFirm(); 

        //Constructor
        public Simulation()
        {

        }

        //Member Methods
        public void CreateMarketingFirmWithManager()
        {
            UserInterface.GetManangerInput();

        }
    }
}
