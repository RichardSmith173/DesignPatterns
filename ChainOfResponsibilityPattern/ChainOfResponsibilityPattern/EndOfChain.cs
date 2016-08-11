using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class EndOfChain : Responsibilty
    {
        public override void HandleRequest(decimal expenseAmount)
        {
            Console.WriteLine("This request cannot be handled.");
        }
    }
}
