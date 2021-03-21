using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    public class Pear : ISkinnable
    {
        public void Skin()
        {
            Console.WriteLine("Pear Skin");
        }
    }
}
