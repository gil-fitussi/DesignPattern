using Decorator2.Interface;
using Decorator2.Models;
using System;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new Espresso();
            coffee = new MilkDecorator(coffee);
            coffee = new SugarDecorator(coffee);

            coffee.GetCoffeeDetails();
            Console.ReadLine();
        }
    }
}
