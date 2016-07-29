using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Decorator : BurgerComponent
    {
        BurgerComponent _burger = null;
        protected decimal _price = 0.0m;

        public Decorator(BurgerComponent burger)
        {
            _burger = burger;
        }

        override decimal GetPrice()
        {
            return _price += _burger.GetPrice();
        }
    }
}
