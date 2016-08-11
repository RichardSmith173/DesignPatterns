using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class AddOnFactory : IAddOnFactory
    {
        private static IPolicy _policy;

        public AddOnFactory(IPolicy policy)
        {
            _policy = policy;
        }

        public AddOns ReturnAddOn(IPolicy policy, AddOnName addOnName)
        {
            switch (addOnName)
            {
                case AddOnName.LegalCover:
                    return new LegalCover(policy);

                case AddOnName.BikeProtection:
                    return new BikeProtection(policy);

                case AddOnName.AccidentalDamage:
                    return new AccidentalDamage(policy);

                case AddOnName.NCDProtection:
                    return new NCDProtection(policy);

                default:
                    throw new NotImplementedException();
            }
        }

        public AddOns ReturnAddOn(AddOnName addOnName)
        {
            return addOnDictonary[addOnName];
        }

        private Dictionary<AddOnName, AddOns> addOnDictonary = new Dictionary<AddOnName, AddOns>
        {
            [AddOnName.LegalCover] = new LegalCover(_policy),
            [AddOnName.BikeProtection] = new BikeProtection(_policy),
            [AddOnName.AccidentalDamage] = new AccidentalDamage(_policy),
            [AddOnName.NCDProtection] = new NCDProtection(_policy)
        };
    }
}

