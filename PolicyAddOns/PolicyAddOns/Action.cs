using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class AddOnsActions
    {
        internal AddOns ReturnAddOn(IPolicy policy, AddOnName addOnName)
        {
            var factory = new AddOnFactory(policy);
            var addOn = factory.ReturnAddOn(addOnName);

            return addOn;
        }
    }
}
