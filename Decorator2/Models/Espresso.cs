using Decorator2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Models
{
    public class Espresso : Coffee
    {
        public Espresso()
        {
            Price = 2;
            TotalPrice = Price;
            Type = "Espresso";
        }

        public override void GetCoffeeDetails()
        {
            Console.WriteLine($"{Type} Cost: {Price} Total:{TotalPrice}$");
        }
    }
}
