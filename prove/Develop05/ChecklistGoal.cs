class CheckListGoal : Goal
{
    private int _goalBonusPoints;
    private int _timesCompleted;
    private int _targetCompletedAmount;

    public CheckListGoal(string name, string description, int value, int bonus, int target)
        : base(name, description, value)
    {
        _goalBonusPoints = bonus;
        _targetCompletedAmount = target;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCompletedAmount)
        {
            _timesCompleted++;

            if (_timesCompleted == _targetCompletedAmount)
            {
                return _goalScoreValue + _goalBonusPoints;
            }

            return _goalScoreValue;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCompletedAmount;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{_goalName}|{_goalDescription}|{_goalScoreValue}|{_goalBonusPoints}|{_targetCompletedAmount}|{_timesCompleted}";
    }

    public override string GetInfo()
    {
        return $"{_goalName}: {_goalDescription} (Completed {_timesCompleted}/{_targetCompletedAmount} times)";
    }
}
