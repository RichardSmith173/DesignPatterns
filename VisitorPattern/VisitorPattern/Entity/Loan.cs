using System;

namespace VisitorPattern.Entity
{
    public class Loan : IAsset
    {
        public decimal Owed { get; set; }
        public decimal MonthlyPayment { get; set; }

        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}