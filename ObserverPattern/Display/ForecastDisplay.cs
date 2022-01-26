using ObserverPattern.Abtractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Display
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private WeatherData weatherData;
        private float currentPressure = 29.92f;
        private float lastPressure;
        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this.lastPressure = this.currentPressure;
            this.currentPressure = weatherData.GetPressure();
        }

        public void Display()
        {

            Console.WriteLine("Forecast: ");
        }
    }
}
