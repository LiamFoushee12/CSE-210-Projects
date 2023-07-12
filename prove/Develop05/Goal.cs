using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string Name { get; }
    public int Value { get; }
    public int Score { get; protected set; }
    public bool IsComplete { get; protected set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Score = 0;
        IsComplete = false;
    }

    public abstract void RecordEvent();

    public virtual string GetGoalStatus()
    {
        if (IsComplete)
            return "[X] Completed";
        else
            return "[ ] Not Completed";
    }

    public virtual string GetGoalProgress()
    {
        return $"{Score}/{Value}";
    }
}