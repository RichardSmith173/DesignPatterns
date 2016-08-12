using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyHost.Entity;
using PolicyValidate.Validators;

namespace PolicyRepository
{
    public class PolicyContext : IReadRepository<Policy>, IWriteRepository<Policy>
    {
        private readonly DatabaseContext _context;
        private readonly IValidate<Policy> _validator;

        public PolicyContext(DatabaseContext context, IValidate<Policy> validator)
        {
            _context = context;
            _validator = validator;
        }

        public void Add(Policy policy)
        {
            if (_validator.Validate(policy) != null)
            {
                _context.PolicyDetails.Add(policy.Details);
            }
        }
    }
}
