using Decorator2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Models
{
    public class CoffeeDecorator : ICoffee
    {
        public ICoffee Coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            Coffee = coffee;
        }

        public void AddToPrice(double price)
        {
            Coffee.AddToPrice(price);
        }

        public virtual void GetCoffeeDetails()
        {
            Coffee.GetCoffeeDetails();
        }
    }
}
