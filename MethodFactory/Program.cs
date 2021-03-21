
using MethodFactory.Factory;
using MethodFactory.Interface;
using System;
using System.Collections.Generic;

namespace MethodFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            List<IFactory> VehicleList = new List<IFactory>()
            {
                factory.GetVehicle(VehicleType.Scooter),
                factory.GetVehicle(VehicleType.Bike)
            };

            foreach (var vehicle in VehicleList)
            {
                vehicle.Drive(10);
            }

            Console.ReadKey();
        }
    }
}
