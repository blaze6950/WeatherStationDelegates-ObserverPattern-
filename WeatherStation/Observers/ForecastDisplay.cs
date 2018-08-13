using System;

// ReSharper disable once CheckNamespace
namespace WeatherStation
{
    class ForecastDisplay
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public float Temperature { get => _temperature; set => _temperature = value; }
        public float Humidity { get => _humidity; set => _humidity = value; }
        public float Pressure { get => _pressure; set => _pressure = value; }

        public ForecastDisplay(WeatherData weatherData)
        {
            weatherData.Observers += this.Update;

        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions : " + Pressure + " mm hg" + Temperature + "C degrees and " + Humidity + "% humidity");
            Console.WriteLine("==============================================");
        }
    }
}
