using Memento.Models;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ChangeStatus("Admited");
            Console.WriteLine($"Initial Student Status: {student.Status}");
            try
            {
                student.ChangeStatus("Start Proccessing..");
                Console.WriteLine($"Student Status After Proccess: {student.Status}");
                throw new Exception();
            }
            catch (Exception)
            {
                student.Revert();
            }
            Console.WriteLine($"Student Status After Error: {student.Status}");
            Console.WriteLine($"Student Status After Error: {student.GetRevertStudent().Status}");

            Console.ReadLine();
        }
    }
}
