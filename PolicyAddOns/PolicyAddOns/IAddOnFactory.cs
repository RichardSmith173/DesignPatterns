using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    interface IAddOnFactory
    {
        AddOns ReturnAddOn(AddOnName addOnName);
    }
}
