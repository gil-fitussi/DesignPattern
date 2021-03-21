using Composite.Composite;
using Composite.Interface;
using Composite.Models;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp1 = new Employee("Emp1", "IT");
            IEmployee emp2 = new Employee("Emp2", "IT");
            IEmployee emp3 = new Employee("Emp3", "HR");
            IEmployee emp4 = new Employee("Emp4", "HR");
            IEmployee emp5 = new Employee("Emp5", "HR");

            IEmployee mgr1 = new Manager("Mgr1", "IT")
            {
                SubOrdinates = { emp1, emp2 }
            };

            IEmployee mgr2 = new Manager("Mgr2", "IT")
            {
                SubOrdinates = { emp3, emp4, emp5 }
            };

            IEmployee mgr3 = new Manager("Mgr3", "Head")
            {
                SubOrdinates = { mgr1, mgr2 }
            };

            mgr3.GetDetails();

            Console.ReadLine();
        }
    }
}
