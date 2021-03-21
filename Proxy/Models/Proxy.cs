using Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Models
{
    public class Proxy : IService
    {
        private IService Service;

        public Proxy(IService service)
        {
            Service = service;
        }
        public void Login(int age)
        {
            if (age < 18)
                Console.WriteLine("You are too young.");
            else
                Service.Login(age);
        }
    }
}
