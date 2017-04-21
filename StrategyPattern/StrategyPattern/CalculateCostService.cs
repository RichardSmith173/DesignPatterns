using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CalculateCostService
    {
        private readonly ICalculateCost _calculateCost;

        public CalculateCostService(ICalculateCost calculateCost)
        {
            _calculateCost = calculateCost;
        }

        public decimal Calculate() => _calculateCost.Calculate();
    }
}
