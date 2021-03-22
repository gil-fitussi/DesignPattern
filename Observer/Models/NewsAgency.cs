using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Models
{
    public class NewsAgency : IObserver
    {
        public NewsAgency(string agencyName)
        {
            AgencyName = agencyName;
        }

        public string AgencyName { get; set; }

        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
                Console.WriteLine($"AgencyName: {AgencyName} reporting the temperature: {weatherStation.Temperature} degree");
        }
    }
}
