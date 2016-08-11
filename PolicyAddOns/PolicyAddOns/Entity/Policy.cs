using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    public class Policy : IPolicy
    {
        public decimal Price { get; set; } = 499m;
        public PolicyType PolicyType { get; protected set; }
        public List<AddOns> AddOns { get; set; } = new List<AddOns>();

        public decimal CalculatePrice()
        {
            return Price + AddOns.Sum(x => x.Price);
        }

        public AddOnName GetAddOnName()
        {
            return AddOnName.Blank;
        }
    }
}
