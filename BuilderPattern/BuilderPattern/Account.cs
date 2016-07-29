using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class Account
    {
        public string Id { get; set; }
        public ICollection<Contributions> Contributions = new List<Contributions>();
        public ICollection<Fees> Fees = new List<Fees>();

        internal void AddContribution(Contributions contribution)
        {
            Contributions.Add(contribution);
        }

        internal void AddFee(Fees fee)
        {
            Fees.Add(fee);
        }

        internal void Show(Account account)
        {
            Console.WriteLine("Account Summary for: {0}", account.Id);
            Console.WriteLine("Fees: {0}", account.Fees.First());
            Console.WriteLine("Contributions: {0}", account.Contributions.First());

        }
    }
}
