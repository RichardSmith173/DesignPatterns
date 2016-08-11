using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class LegalCover : AddOns
    {
        public LegalCover(IPolicy policy) : base(policy)
        {
            Name = AddOnName.LegalCover;
            Price = 29.99m;
            TermsAndConditions = "This is legal cover";
        }
    }
}
