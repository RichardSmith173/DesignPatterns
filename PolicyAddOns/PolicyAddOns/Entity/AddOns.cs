using System;
using System.Collections.Generic;

namespace PolicyAddOns
{
    public class AddOns : IPolicy
    {
        IPolicy _policy = null;
        
        public AddOnName Name { get; set; } = AddOnName.Blank;
        public decimal Price { get; set; } = 0.00m;
        public string TermsAndConditions { get; set; } = string.Empty;
       

        public AddOns(IPolicy policy)
        {
            _policy = policy;
        }
        
        public AddOnName GetAddOnName()
        {
            return Name;
        }

        public decimal CalculatePrice()
        {
            return Price + _policy.CalculatePrice();
        }
    }
}