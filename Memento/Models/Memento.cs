using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Models
{
    public class Memento
    {
        public Student Student { get; set; }

        public Memento(Student student)
        {
            Student = student.Clone();
        }
    }
}
