using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Responsibilty worker = new Worker();
            Responsibilty manager = new Manager();
            Responsibilty director = new Director();

            worker.SetSuccessor(manager);
            manager.SetSuccessor(director);
            director.SetSuccessor(new EndOfChain());

            worker.HandleRequest(250000);

            Console.ReadLine();
        }
    }
}
