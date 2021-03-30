using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Models
{
    public class Student
    {
        public ChangeStudentCommand cmd;
        public string Status { get; private set; }

        public Student()
        {
            cmd = new ChangeStudentCommand(this);
        }

        public void ChangeStatus(string status)
        {
            cmd.Execute(Clone());
            Status = status;
        }

        public void Revert()
        {
            cmd.Revert();
        }

        public Student GetRevertStudent()
        {
            return cmd.Student;
        }

        public Student Clone()
        {
            return MemberwiseClone() as Student;
        }
    }
}
