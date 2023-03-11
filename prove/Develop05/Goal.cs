public class Goal {

    protected string _goalType;
    protected string _goalDescription;
    protected int _completeProgress;
    protected int _pointValue;
    protected int _bonus;
    protected bool _complete;


    public virtual string CreateGoal() {
        return "";
    }

    public virtual void ShowGoal(string[] line)
    {
        // Simple goal format: 0 Goal Type, 1 Description, 2 PointValue, 3 CompleteProgress, 4 Complete?
        // Eternal goal format: 0 Goal Type, 1 Description, 2 PointValue, 3 CompleteProgress, 4 Milestone, 5 Bonus?
        // Checklist goal format: 0 Goal Type, 1 Description, 2 PointValue, 3 InitialProgress, 4 CompleteProgress, 5 Bonus, 6 Completed?
    }

}