using System;
// ReSharper disable UnusedVariable

namespace WeatherStation
{
    class Program
    {
        static void Main()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            Console.WriteLine("++++++++++++++++++++++");
            weatherData.SetMeasurements(82, 70, 29.2f);
            Console.WriteLine("++++++++++++++++++++++");
            weatherData.SetMeasurements(78, 90, 29.2f);

            //currentDisplay.Display();
            //Console.WriteLine("=======================");
            //statisticsDisplay.Display();
            //Console.WriteLine("=======================");
            //forecastDisplay.Display();
            //Console.WriteLine("=======================");
        }
    }
}
