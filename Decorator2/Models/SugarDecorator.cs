using Decorator2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Models
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
            AddToPrice(0.25);
        }

        public override void GetCoffeeDetails()
        {
            Coffee.GetCoffeeDetails();
            Console.WriteLine($"With Sugar Cost:0.25");
        }
    }
}
