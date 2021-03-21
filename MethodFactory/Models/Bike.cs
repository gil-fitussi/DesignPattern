using MethodFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodFactory.Models
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }
}
