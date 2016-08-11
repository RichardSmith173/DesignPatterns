using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns.DataAccess
{
    class PolicyAction : IWritePolicyAction
    {
        private ValidatePolicy validator = new ValidatePolicy();
        private WritePolicyRepository repository = new WritePolicyRepository();

        public void AddAddOnToPolicy(AddOns policyWithAddOn, Policy policy)
        {
            if (validator.Validate(policy))
            {
                policy.Price += policyWithAddOn.Price;
                policy.AddOns.Add(policyWithAddOn);
                repository.Update(policy);
            }
            else
            {
                Console.WriteLine($"Invalid add on {policyWithAddOn.Name} for policy type {policy.PolicyType}."); 
            }
        }
    }
}
