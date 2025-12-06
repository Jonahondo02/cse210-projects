// Goal.cs
public abstract class Goal
{
    protected string _title;
    protected int _points;

    public abstract void Record();
    public virtual string GetDetailsString() => $"{_title}: {_points} points";
}

// SimpleGoal.cs
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public override void Record()
    {
        _isComplete = true;
        Console.WriteLine("Simple goal completed!");
    }

    public override string GetDetailsString() => $"{base.GetDetailsString()} - Completed: {_isComplete}";
}

// EternalGoal.cs
public class EternalGoal : Goal
{
    public override void Record() => _points += 100; // Example points

    // No need to override GetDetailsString() for default behavior
}

// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public override void Record()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            _points += 50; // Points per record
        }
    }

    public override string GetDetailsString() =>
        $"{base.GetDetailsString()} - Completed: {_currentCount}/{_targetCount}";
}

// GoalManager.cs
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine("Goal added!");
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void SaveGoals() { /* Implementation for saving */ }
    public void LoadGoals() { /* Implementation for loading */ }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        // User interaction logic
    }
}