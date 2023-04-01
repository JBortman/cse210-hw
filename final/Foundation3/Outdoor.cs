public class Outdoor : Event
{

    private string _weather;

    public Outdoor(string title, string description, string date, string time, string type, string weather) : base(title, description, date, time, type)
    {
        _weather = weather;
    }

    public string GetOutdoorInfo()
    {
        return $"FULL DESCRIPTION:\n{_type}: {_title}\n{_description}\n{_date} | {_time}\n{_address}\nWeather Forecast: {_weather}";
    }

}