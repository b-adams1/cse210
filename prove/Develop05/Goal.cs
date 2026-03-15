abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalScoreValue;

    public Goal(string name, string description, int pointsValue)
    {
        _goalName = name;
        _goalDescription = description;
        _goalScoreValue = pointsValue;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetInfo()
    {
        return $"{_goalName}: {_goalDescription}";
    }
    public abstract string GetStringRepresentation();
}