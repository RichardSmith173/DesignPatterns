using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorPattern.Entity;

namespace VisitorPattern
{
    [TestClass]
    public class VisitorTest
    {
        [TestMethod]
        public void CalculateNetWorth()
        {
            var client = new Client();
            client.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01m });
            client.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02m });
            client.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            client.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            var netWorthVisitor = new NetWorthVisitor();
            client.Accept(netWorthVisitor);

            Assert.AreEqual(42000, netWorthVisitor.Total);
        }

        [TestMethod]
        public void CalculateMonthlyIncome()
        {
            var client = new Client();
            client.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01m });
            client.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02m });
            client.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            client.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            var incomeVisitor = new IncomeVisitor();
            client.Accept(incomeVisitor);

            Assert.AreEqual(510, incomeVisitor.Amount);
        }
    }
}
