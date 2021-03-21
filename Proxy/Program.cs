using Proxy.Interface;
using Proxy.Models;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IService concreteService = new ConcreteService(); 
            IService proxy = new Proxy.Models.Proxy(concreteService);

            concreteService.Login(15);
            proxy.Login(15);

            concreteService.Login(25);
            proxy.Login(25);

            Console.ReadLine();
        }
    }
}
