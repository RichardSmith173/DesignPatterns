using System;
using PolicyHost.Entity;

namespace PolicyValidate.Validators
{
    internal class AllMandatoryFieldsGiven : Validate<Policy>
    {
        internal override ValidationResult ValidateRule(Policy entity)
        {
            if (AllFieldsAreGiven(entity))
            {
                _nextRule?.ValidateRule(entity);
            }
            else
            {
                ValidationResult error = new ValidationResult
                {
                    Message = "Failed to validate rule AllMandatoryFieldsGiven."
                };

                return error;
            }

            return null;
        }


        private bool AllFieldsAreGiven(Policy entity)
        {
            throw new NotImplementedException();
        }
    }
}