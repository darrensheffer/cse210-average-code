public class RecurringChecklistGoal : ChecklistGoal
{
    public RecurringChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
    : base(name, description, points, targetCount, bonusPoints)
    {
        
    }

    public RecurringChecklistGoal(string name, string description, int points, int completionCount, int targetCount, int bonusPoints) 
    : base(name, description, points, completionCount, targetCount, bonusPoints)
    {
        
    }

    public override int RecordEvent()
    {
        int basePoints = GetPoints();

        if (IsComplete())
        {
            _completionCount = 1;
            return basePoints;
        }
        else
        {
            _completionCount ++;
            if (IsComplete())
            {
                return basePoints + _bonusPoints;
            }
            else
            {
                return basePoints;
            }
        }
    }

    public override string GetStringRepresentation()
    {
        string goal = $"RecurringChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_completionCount},{_targetCount},{_bonusPoints}";
        return goal;
    }
}