using System;
using System.Collections.Generic;
using System.IO;

class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    public override void RecordEvent()
    {
        Score += Value;
    }
}