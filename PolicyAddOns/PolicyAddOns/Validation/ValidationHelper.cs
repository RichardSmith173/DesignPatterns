using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class ValidationHelper<Policy>
    {
        internal static Dictionary<PolicyType, List<AddOnName>> validPolicyAddOns { get; set; } = new Dictionary<PolicyType, List<AddOnName>>
        {
            [PolicyType.Home] = new List<AddOnName>
            {
                AddOnName.LegalCover,
                AddOnName.BikeProtection,
                AddOnName.AccidentalDamage
            },
            [PolicyType.Motor] = new List<AddOnName>
            {
                AddOnName.LegalCover,
                AddOnName.NCDProtection
            }
        };
    }
}
