using Decorator2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Models
{
    public abstract class Coffee : ICoffee
    {
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public string Type { get; set; }


        public virtual void GetCoffeeDetails()
        {
            Console.WriteLine("Regular Coffee");
        }

        public void AddToPrice(double price)
        {
            TotalPrice += price;
        }
    }
}
