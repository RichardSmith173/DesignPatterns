using FluentValidation;
using PolicyAddOns;
using PolicyAddOns.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class ValidatePolicy : IValidate<Policy>
    {
        private WritePolicyRepository repository = new WritePolicyRepository();
        private delegate bool Validator(Policy policy);

        private static bool HaveCorrectType(Policy policy)
        {
            var validItems = ValidationHelper<Policy>.validPolicyAddOns[policy.PolicyType];

            foreach (var item in policy.AddOns)
            {
                if (!validItems.Contains(item.Name))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Validate(Policy policy)
        {
            var list = new List<Validator>();
            list.Add(HaveCorrectType);

            return list.TakeWhile(x => x.Invoke(policy));
        }
    }
}
