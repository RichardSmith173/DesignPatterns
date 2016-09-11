using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Entity;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(BankAccount bankAccount);
        void Visit(RealEstate realEstate);
        void Visit(Loan loan);
    }
}
