using PolicyHost.Entity;
using PolicyValidate.Validators.PolicyRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyValidate.Validators
{
    public class ValidatePolicy : IValidate<Policy>
    {
        private Validate<Policy> RuleStart;

        public ValidatePolicy()
        {
            SetRuleChain();
        }

        private void SetRuleChain()
        {
            RuleStart = new AllMandatoryFieldsGiven();
            var rule2 = new PolicyNumberConsistentWithBrandAndProduct();
            var finalRule = new FinalRuleInChain();

            RuleStart.SetNextRule(rule2);
            rule2.SetNextRule(finalRule);
        }

        public ValidationResult Validate(Policy policy) => RuleStart.ValidateRule(policy);
    }
}
