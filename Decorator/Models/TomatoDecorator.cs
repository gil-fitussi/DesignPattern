using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n with extra tomato";
            return type;
        }
    }
}
