using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Entity
{
    public class Client : IAsset
    {
        public List<IAsset> Assets = new List<IAsset>();
        
        public ICollection<BankAccount> BankAccount { get; set; }
        public ICollection<RealEstate> RealEstate { get; set; }
        public ICollection<Loan> Loans { get; set; }

        public void Accept(IVisitor visitor) => Assets.ForEach(x => x.Accept(visitor));
    }
}
