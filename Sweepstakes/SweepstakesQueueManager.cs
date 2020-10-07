using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Member Variables
        Queue<Sweepstakes> queue;

        //Constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        //Member Methods
        public void InsertSweepstakes (Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
           return queue.Dequeue();  
        }
    }
}
