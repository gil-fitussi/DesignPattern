using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "Regular pizza";
        }
    }
}
