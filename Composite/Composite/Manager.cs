using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Composite
{
    public class Manager : IEmployee
    {
        public List<IEmployee> SubOrdinates;
        public string Name { get; set; }
        public string Department { get; set; }

        public Manager(string name, string department)
        {
            Name = name;
            Department = department;
            SubOrdinates = new List<IEmployee>();
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Department: {Department}");
            foreach (var sub in SubOrdinates)
            {
                sub.GetDetails();
            }
        }
    }
}
