using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyHost.Entity;

namespace PolicyRepository
{
    public class PolicyContext : IReadRepository<Policy>, IWriteRepository<Policy>
    {
        private readonly DatabaseContext _context;

        public PolicyContext(DatabaseContext context)
        {
            _context = context;
        }
    }
}
