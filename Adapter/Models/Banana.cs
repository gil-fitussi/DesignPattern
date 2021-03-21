using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    public class Banana : IPeelable
    {
        public void Peel()
        {
            Console.WriteLine("Banana Peel");
        }
    }
}
