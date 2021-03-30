using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interface
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
        void UnRegister(IObserver observer);
    }
}
