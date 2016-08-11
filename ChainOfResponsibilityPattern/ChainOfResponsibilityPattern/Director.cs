using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Director : Responsibilty
    {
        public override void HandleRequest(decimal expenseAmount)
        {
            if (expenseAmount < 100000 && expenseAmount > 10000)
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
