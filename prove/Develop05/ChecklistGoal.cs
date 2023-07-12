using System;
using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    private int completionCount;

    public ChecklistGoal(string name, int value, int completionCount) : base(name, value)
    {
        this.completionCount = completionCount;
    }

    public override void RecordEvent()
    {
        Score += Value;
        if (Score >= completionCount * Value)
        {
            Score += Value * 10; // Bonus points for completing all checklist items
            IsComplete = true;
        }
    }

    public override string GetGoalProgress()
    {
        return $"Completed {Score / Value}/{completionCount} times";
    }
}
