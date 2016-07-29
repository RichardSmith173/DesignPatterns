using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientFactory factory = new ClientFactory();

            var clientFactory = factory.GetClient();

            var name = clientFactory.GetClientName();

            Console.WriteLine(name);
            Console.ReadLine();

        }
    }
}
