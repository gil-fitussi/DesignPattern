using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Models
{
    // The Leaf
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Department: {Department}");
        }
    }
}
