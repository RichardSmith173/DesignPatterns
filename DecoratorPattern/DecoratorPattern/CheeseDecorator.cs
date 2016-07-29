using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class CheeseDecorator : Decorator
    {
        public CheeseDecorator(BurgerComponent burgerComponent)
            : base(burgerComponent)
        {
            _name = "Cheese";
            _price = 0.50m;
        }
    }
}
