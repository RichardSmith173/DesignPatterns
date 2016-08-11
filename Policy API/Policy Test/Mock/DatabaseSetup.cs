using Moq;
using PolicyRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PolicyHost.Entity;

namespace PolicyTest
{
    public class DatabaseSetup
    {
        private Mock<DatabaseContext> mockDbContext = new Mock<DatabaseContext>();

        protected PolicyContext MockPolicyContext()
        {
            var policyDetails = Seed.PolicyDetails.PolicyDetailsData.ToList();
            var mockDbSet = SetupTable(policyDetails, new Mock<IDbSet<PolicyDetails>>());
            mockDbContext.Setup(x => x.PolicyDetails).Returns(mockDbSet.Object);

            return new PolicyContext(mockDbContext.Object);
        }

        private static Mock<IDbSet<T>> SetupTable<T>(List<T> data, Mock<IDbSet<T>> dbSetMock) where T : BaseEntity
        {
            var queryable = data.AsQueryable();

            dbSetMock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());
            dbSetMock.Setup(d => d.Add(It.IsAny<T>())).Callback<T>((s) => data.Add(s));
            dbSetMock.Setup(m => m.Remove(It.IsAny<T>())).Callback<T>((s) => data.Remove(s));

            return dbSetMock;
        }
    }
}
