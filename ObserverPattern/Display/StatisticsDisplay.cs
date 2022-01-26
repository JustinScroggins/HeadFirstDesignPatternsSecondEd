using ObserverPattern.Abtractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Display
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private WeatherData weatherData;
        private float average;
        private float min;
        private float max;
        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " +average+ "/" +max+ "/" +min );
        }

        public void Update()
        {
            GetData();
        }

        public void GetData()
        {
            var temp = weatherData.GetTemperature();
            if (min > temp)
                min = temp;
            if (max < temp)
                max = temp;
            average = (min + max) / 2;
        }
    }
}
