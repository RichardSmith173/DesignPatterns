using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class MotorPolicy : Policy
    {
        public MotorPolicy()
        {
            PolicyType = PolicyType.Motor;
        }
    }
}
