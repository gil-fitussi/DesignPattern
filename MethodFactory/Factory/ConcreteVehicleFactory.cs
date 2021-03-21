using MethodFactory.Interface;
using MethodFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodFactory.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(VehicleType veihcleType)
        {
            switch (veihcleType)
            {
                case VehicleType.Scooter:
                    return new Scooter();
                case VehicleType.Bike:
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", veihcleType.ToString()));
            }
        }
    }
}
