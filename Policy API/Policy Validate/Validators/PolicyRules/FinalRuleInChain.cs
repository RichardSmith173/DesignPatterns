using PolicyHost.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyValidate.Validators.PolicyRules
{
    class FinalRuleInChain : Validate<Policy>
    {
        internal override ValidationResult ValidateRule(Policy entity)
        {
            return new ValidationResult
            {
                Message = "All rules have been validated successfully.",
                Severity = Severity.Success
            };
        }
    }
}
