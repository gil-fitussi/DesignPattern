using System;
using Template_Method.Models;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var universityBalagan = new UniversityBalagan();
            universityBalagan.RegisterStudent();
           
            
            var universityBardak = new UniversityBardak();
            universityBardak.RegisterStudent();

            Console.ReadLine();
        }
    }
}
