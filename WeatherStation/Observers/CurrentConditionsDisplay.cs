using System;

// ReSharper disable once CheckNamespace
namespace WeatherStation
{
    class CurrentConditionsDisplay
    {
        private float _temperature;
        private float _humidity;

        public float Temperature { get => _temperature; set => _temperature = value; }
        public float Humidity { get => _humidity; set => _humidity = value; }

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            weatherData.Observers += Update;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions : " + Temperature + "C degrees and " + Humidity + "% humidity");
            Console.WriteLine("==============================================");
        }
    }
}
