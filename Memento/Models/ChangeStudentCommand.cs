using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Memento.Models
{
    public class ChangeStudentCommand : ICommand
    {
        public Student Student { get; private set; }
        private Stack<Memento> MementoStack = new Stack<Memento>();

        public event EventHandler CanExecuteChanged;

        public ChangeStudentCommand(Student student)
        {
            Student = student;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object student)
        {
            MementoStack.Push(new Memento(student as Student));
        }


        public void Revert()
        {
            if (MementoStack.Count == 0) return;
            var memento = MementoStack.Pop();
            if(memento != null)
            Student = memento.Student;
        }
    }
}
