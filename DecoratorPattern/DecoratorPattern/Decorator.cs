using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Decorator : BurgerComponent
    {
        BurgerComponent _burgerComponent = null;

        protected string _name = "Undefined Decorator";
        protected decimal _price = 0.0m;

        protected Decorator(BurgerComponent burgerComponent)
        {
            _burgerComponent = burgerComponent;
        }

        public override string GetFilling()
        {
            return string.Format("{0}, {1}", _burgerComponent.GetFilling(), _name);
        }

        public override decimal GetPrice()
        {
            return _price + _burgerComponent.GetPrice();
        }
    }
}
