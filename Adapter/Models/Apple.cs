using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    public class Apple : ISkinnable
    {
        public void Skin()
        {
            Console.WriteLine("Apple Skin");
        }
    }
}
