using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Manager : Responsibilty
    {
        public override void HandleRequest(decimal expenseAmount)
        {
            if (expenseAmount < 10000 && expenseAmount > 100)
            {
                Console.WriteLine("Handled request by Manager");
            }
            else
            {
                _successor?.HandleRequest(expenseAmount);
            }
        }
    }
}
