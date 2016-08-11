using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyHost.Entity;
using System.Reflection;

namespace PolicyRepository
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public virtual IDbSet<PolicyDetails> PolicyDetails { get; set; }

        public DatabaseContext() : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
