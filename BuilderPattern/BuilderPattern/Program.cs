using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder builder1 = new BuildAccountSingleContributions();
            Builder builder2 = new BuildAccountRegularContributions();

            director.Construct(builder1);
            Account account1 = builder1.GetResult();
            account1.Id = "1";
            account1.Show(account1);

            director.Construct(builder2);
            Account account2 = builder2.GetResult();
            account2.Id = "2";
            account1.Show(account2);

            Console.ReadLine();


        }
    }
}
