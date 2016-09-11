using System;

namespace VisitorPattern.Entity
{
    public class BankAccount : IAsset
    {
        public decimal Amount { get; set; }
        public decimal MonthlyInterest { get; set; }

        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}