public class Running : Activity {

    public override void CalcSpeed(int time, double distance){
        _time = time;
        _distance = distance;
        _speed = Math.Round((distance / time) * 60, 1);
    }
    
}