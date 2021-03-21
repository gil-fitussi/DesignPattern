using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            var type = base.GetPizzaType();
            type += "\r\n with extra cheese";
            return type;
        }
    }
}
