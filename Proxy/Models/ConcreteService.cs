using Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Models
{
    public class ConcreteService : IService
    {
        public void Login(int age)
        {
            Console.WriteLine($"You are logged in. Your age is {age}");
        }
    }
}
