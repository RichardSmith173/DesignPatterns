using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RulesPattern;

namespace Tests
{
    [TestClass]
    public class ValidationTests
    {
        private List<ICalculate> BuildValidationTests()
        {
            var validationList = new List<ICalculate>();

            validationList.Add(new Small());
            validationList.Add(new Medium());
            validationList.Add(new Large());

            return validationList;
        }

        [TestMethod]
        public void AllFail()
        {
            var value = 5;
            
            var validationList = BuildValidationTests();

            Assert.IsFalse(validationList.All(x => x.Calculate(value)));
        }

        [TestMethod]
        public void LargeFails()
        {
            var value = 9;
            var validationList = BuildValidationTests();

            Assert.IsTrue(validationList.Any(x => x.Calculate(value)));
        }
    }
}
