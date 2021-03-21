using Decorator2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Models
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            AddToPrice(0.5);
        }
        public override void GetCoffeeDetails()
        {
            Coffee.GetCoffeeDetails();
            Console.WriteLine($"With Milk Cost:0.5");
        }
    }
}
