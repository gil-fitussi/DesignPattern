using Decorator.Interface;
using Decorator.Models;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza cheeseDecorator = new CheeseDecorator(pizza);
            IPizza tomatoDecorator = new TomatoDecorator(cheeseDecorator);

            Console.WriteLine(tomatoDecorator.GetPizzaType());
            Console.ReadLine();
        }
    }
}
