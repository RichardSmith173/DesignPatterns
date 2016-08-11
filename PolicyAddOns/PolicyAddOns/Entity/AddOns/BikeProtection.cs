using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class BikeProtection : AddOns
    {
        public BikeProtection(IPolicy policy) : base(policy)
        {
            Name = AddOnName.BikeProtection;
            Price = 19.99m;
            TermsAndConditions = "This is Bike Protection";
        }
    }
}
