using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BurgerBase burger = new BurgerBase();
            PrintProductDetails(burger);

            CheeseDecorator cheese = new CheeseDecorator(burger);
            PrintProductDetails(cheese);

            FriedOnionDecorator friedOnions = new FriedOnionDecorator(burger);
            PrintProductDetails(friedOnions);

            FriedOnionDecorator friedOnionsWithCheese = new FriedOnionDecorator(cheese);
            PrintProductDetails(friedOnionsWithCheese);

            Console.ReadLine();

        }

        private static void PrintProductDetails(BurgerComponent burgerComponent)
        {
            Console.WriteLine(string.Format("Item: {0}. Price: {1}.", burgerComponent.GetFilling(), burgerComponent.GetPrice()));
        }
    }
}
