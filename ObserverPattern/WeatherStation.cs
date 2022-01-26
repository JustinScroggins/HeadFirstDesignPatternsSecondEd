// See https://aka.ms/new-console-template for more information
using ObserverPattern;
using ObserverPattern.Display;
using ObserverPattern.Views;

WeatherData weatherData = new WeatherData();

CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);

currentDisplay.Display();
statsDisplay.Display();
forecastDisplay.Display();
Console.ReadLine();


