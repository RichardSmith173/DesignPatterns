using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyHost.Entity;
using PolicyHost.Enumerations;

namespace PolicyTest.Seed
{
    class PolicyDetails : DataGenerator<PolicyHost.Entity.PolicyDetails>
    {
        CreateEntity policyDetails = new CreateEntity(SeedEntity);

        internal static IEnumerable<PolicyHost.Entity.PolicyDetails> PolicyDetailsData { get; set; } = SeedEntity();

        private static IEnumerable<PolicyHost.Entity.PolicyDetails> SeedEntity()
        {
            var policyDetails = new List<PolicyHost.Entity.PolicyDetails>
            {
                new PolicyHost.Entity.PolicyDetails
                {
                    BrandId = (int)Brand.Axa,
                    ProductId = (int)Product.Motor,
                    PolicyNumber = 309999999,
                    StartDate = DateTime.Now,
                    ExpirationDate = DateTime.Now,
                    IsPolicySourceMigration = false
                }
            };

            return policyDetails;
        }
    }
}
