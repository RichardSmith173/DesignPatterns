using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Entity;

namespace VisitorPattern
{
    public class IncomeVisitor : IVisitor
    {
        public decimal Amount { get; private set;}

        public void Visit(Loan loan) => Amount -= loan.MonthlyPayment;

        public void Visit(RealEstate realEstate) => Amount += realEstate.MonthlyRent;

        public void Visit(BankAccount bankAccount) => Amount += bankAccount.Amount * bankAccount.MonthlyInterest;
    }
}
