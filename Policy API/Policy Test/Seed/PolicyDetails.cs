using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyHost.Entity;
using PolicyHost.Enumerations;

namespace PolicyTest.Seed
{
    static class PolicyDetails
    {
        internal static ICollection<PolicyHost.Entity.PolicyDetails> PolicyDetailsData { get; set; } = SeedPolicyDetails();

        private static ICollection<PolicyHost.Entity.PolicyDetails> SeedPolicyDetails()
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
