using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class Responsibilty
    {
        protected Responsibilty _successor;

        public abstract void HandleRequest(decimal expenseAmount);

        public void SetSuccessor(Responsibilty successor)
        {
            _successor = successor;
        }
    }
}
