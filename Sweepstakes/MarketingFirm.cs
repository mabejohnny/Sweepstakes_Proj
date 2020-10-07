using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //Member Variables
        private ISweepstakesManager manager;

        //Constructor
        public MarketingFirm(ISweepstakesManager manager) // This is depending on any manager type (would need multiple constructors if dependency injection is not 
        {
            this.manager = manager;
        }


        //Member Methods
        public void CreateSweepStakes()
        {
            Sweepstakes newSweep = new Sweepstakes();

        }
    }
}
