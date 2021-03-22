using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Models
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> Observers;

        private float temperature;

        public float Temperature
        {
            get { return temperature; }
            set 
            { 
                temperature = value;
                Notify();
            }
        }

        public WeatherStation()
        {
            Observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var obs in Observers)
            {
                obs.Update(this);
            }
        }

        public void UnRegister(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
