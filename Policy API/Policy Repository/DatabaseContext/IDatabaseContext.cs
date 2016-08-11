using PolicyHost.Entity;
using System.Data.Entity;

namespace PolicyRepository
{
    public interface IDatabaseContext
    {
        IDbSet<PolicyDetails> PolicyDetails { get; set; }
    }
}