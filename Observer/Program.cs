using Observer.Models;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency channel11 = new NewsAgency("Channel 11");
            NewsAgency channel12 = new NewsAgency("Channel 12");
            NewsAgency channel13 = new NewsAgency("Channel 13");
            weatherStation.Attach(channel11);
            weatherStation.Attach(channel12);
            weatherStation.Attach(channel13);

            bool endProgram = false;
            while (!endProgram)
            {
                Console.WriteLine("Press X For Exit OR Insert Update Temperature:");
                var tempRead = Console.ReadLine();
                if (tempRead.Equals("X"))
                    endProgram = true;
                else
                {
                    float.TryParse(tempRead, out float temp);
                    weatherStation.Temperature = temp;
                }
            }

            weatherStation.UnRegister(channel11);
            weatherStation.UnRegister(channel12);
            weatherStation.UnRegister(channel13);

        }
    }
}
