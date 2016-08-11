using NUnit.Framework;
using PolicyRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyTest.UnitTests
{
    [TestFixture]
    public class PolicyContextTest : DatabaseSetup
    {
        private PolicyContext _policyContext;

        [OneTimeSetUp]
        public void SetupContexts()
        {
            _policyContext = MockPolicyContext();
        }

        [Test]
        public void AddBasicPolicy()
        {

        }

    }
}
