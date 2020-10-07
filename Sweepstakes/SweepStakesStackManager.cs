using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepStakesStackManager : ISweepstakesManager
    {
        //Member Variables
        private Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

      

        //Member Methods

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
