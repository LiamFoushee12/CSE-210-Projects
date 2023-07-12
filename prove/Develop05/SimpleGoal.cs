using System;
using System.Collections.Generic;
using System.IO;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void RecordEvent()
    {
        Score += Value;
        IsComplete = true;
    }
}