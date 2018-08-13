// ReSharper disable CheckNamespace
namespace WeatherStation
{
    public delegate void Observers(float temp, float hum, float pres);
    class WeatherData
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public float Temperature { get => _temperature; set => _temperature = value; }
        public float Humidity { get => _humidity; set => _humidity = value; }
        public float Pressure { get => _pressure; set => _pressure = value; }
        public event Observers Observers;

        public void NotifyObservers()
        {
            if (Observers != null) Observers.Invoke(_temperature, _humidity, _pressure);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
