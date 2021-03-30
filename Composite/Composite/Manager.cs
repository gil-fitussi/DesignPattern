using Composite.Interface;
using Composite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Composite
{
    public class Manager : Employee
    {
        public List<IEmployee> SubOrdinates;
 
        public Manager(string name, string department) : base(name, department)
        {
            SubOrdinates = new List<IEmployee>();
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Department: {Department}");
            foreach (var sub in SubOrdinates)
            {
                sub.GetDetails();
            }
        }
    }
}
