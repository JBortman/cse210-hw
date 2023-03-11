public class Goal {

    protected int _userPoints;
    protected string _goalType;
    protected string _goalDescription;
    protected int _completeProgress;
    protected int _pointValue;
    protected int _bonus;
    protected bool _complete;
    protected string[] _selSplit;
    protected bool check;
    protected string _newString;



    public virtual string CreateGoal() {
        return "";
    }

    public virtual void ShowGoal(string[] line){}

    public virtual int MarkProgress(List<string> list, int index){
        return 0;
    }

}