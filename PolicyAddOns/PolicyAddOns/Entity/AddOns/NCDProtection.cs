using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class NCDProtection : AddOns
    {
        public NCDProtection(IPolicy policy) : base(policy)
        {
            Name = AddOnName.NCDProtection;
            Price = 39.99m;
            TermsAndConditions = "This is NCD Protection";
        }
    }
}
