using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    public class Orange : IPeelable
    {
        public void Peel()
        {
            Console.WriteLine("Orange Peel");
        }
    }
}
