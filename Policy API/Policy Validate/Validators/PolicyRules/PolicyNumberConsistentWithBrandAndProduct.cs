using PolicyHost.Entity;
using System;

namespace PolicyValidate.Validators
{
    internal class PolicyNumberConsistentWithBrandAndProduct : Validate<Policy>
    {
        internal override ValidationResult ValidateRule(Policy entity)
        {
            if (ConsistentPolicyNumberWithBrandAndProduct(entity))
            {
                _nextRule?.ValidateRule(entity);
            }
            else
            {
                ValidationResult error = new ValidationResult
                {
                    Message = "Failed to validate rule PolicyNumberConsistentWithBrandAndProduct.",
                    Severity = Severity.Error
                };
            }

            return null;
        }
        
        private bool ConsistentPolicyNumberWithBrandAndProduct(Policy entity)
        {
            throw new NotImplementedException();
        }
    }
}