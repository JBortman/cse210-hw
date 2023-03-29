public class Activity {

    private string _date;
    protected int _time;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    
    public virtual void CalcSpeed(int time, double distance){
    }

    public void CalcPace(){
        _pace = Math.Round(_time / _distance, 1);

    }

    public string CollectInfo(string name){
    _date = DateTime.Now.ToString("dd MMM yyyy");
    return $"{_date},{name},{_time},{_distance},{_speed},{_pace}";
    }

    public void GetSummary(string date, string activity, string time, string distance, string speed, string pace){    
        Console.WriteLine($"{date} {activity} ({time} min): Distance {distance} miles, Speed {speed} mph, Pace {pace} min per mile");
    }

    
    
}