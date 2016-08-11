using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyHost.Entity
{
    public class PolicyDetails : BaseEntity
    {
        public DateTime? StorageDate { get; set; }
        public int? RelationId { get; set; }
        public decimal PolicyNumber { get; set; }
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int BrandId { get; set; }
        public bool IsPolicySourceMigration { get; set; }
    }
}
