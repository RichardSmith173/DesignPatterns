using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class FriedOnionDecorator : Decorator
    {
        public FriedOnionDecorator(BurgerComponent burgerComponent)
            : base(burgerComponent)
        {
            _name = "Fried Onions";
            _price = 0.40m;
        }
    }
}
