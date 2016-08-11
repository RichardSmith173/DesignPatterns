using System.Collections.Generic;

namespace PolicyAddOns
{
    public interface IPolicy
    {
        AddOnName GetAddOnName();
        decimal CalculatePrice();
    }
}