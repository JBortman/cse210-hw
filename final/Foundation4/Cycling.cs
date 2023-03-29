public class Cycling : Activity {

    public void SetTime(int time){
        _time = time;
    }
    public void CalcDistance(double speed){
        _speed = speed;
        _distance = Math.Round((speed / 60) * _time, 1);
    }
    
}