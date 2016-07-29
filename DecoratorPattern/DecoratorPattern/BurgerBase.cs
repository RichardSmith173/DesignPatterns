using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class BurgerBase : BurgerComponent
    {
        private string _filling = "Burger Base";
        private decimal _price = 2.50m;

        public override string GetFilling()
        {
            return _filling;
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }
}
