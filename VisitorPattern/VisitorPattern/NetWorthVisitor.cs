using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Entity;

namespace VisitorPattern
{
    public class NetWorthVisitor : IVisitor
    {
        public decimal Total { get; private set; }

        public void Visit(Loan loan) => Total -= loan.Owed;

        public void Visit(RealEstate realEstate) => Total += realEstate.EstimatedValue;

        public void Visit(BankAccount bankAccount) => Total += bankAccount.Amount;
    }
}
