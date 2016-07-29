using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class TomatoDecorator : Decorator
    {
        public TomatoDecorator(BurgerComponent burgerComponent) : base(burgerComponent)
        {
            _name = "Tomato";
            _price = 0.25m;
        }
    }
}
