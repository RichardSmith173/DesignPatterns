using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setting the Account up.");

            var account = new AccountFacade();

            account.CreateAccount();

            Console.WriteLine("Account set up.");
            Console.ReadLine();
        }
    }
}
