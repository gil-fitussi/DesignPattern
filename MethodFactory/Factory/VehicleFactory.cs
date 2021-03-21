using MethodFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodFactory.Factory
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(VehicleType veihcleType);
    }
}
