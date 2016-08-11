using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Worker : Responsibilty
    {
        public override void HandleRequest(decimal expenseAmount)
        {
            if (expenseAmount < 100 && expenseAmount > 0)
            {
                Console.WriteLine("Handled request by Worker");
            }
            else
            {
                _successor?.HandleRequest(expenseAmount);
            }
        }
    }
}
