public class Swimming : Activity {


    public override void CalcSpeed(int time, double laps){
        _time = time;
        _distance = Math.Round(laps * 50 / 1000 * 0.62, 1);
        _speed = Math.Round((_distance / time) * 60, 1);
    }
    
}