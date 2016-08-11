using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class AccidentalDamage : AddOns
    {
        public AccidentalDamage(IPolicy policy) :base(policy)
        {
            Name = AddOnName.AccidentalDamage;
            Price = 24.99m;
            TermsAndConditions = "This is Accidental Damage";
        }
    }
}
