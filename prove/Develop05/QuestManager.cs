using System;
using System.Collections.Generic;
using System.IO;

class QuestManager
{
    private List<Goal> goals;

    public QuestManager()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.Name} - {goal.GetGoalStatus()} - {goal.GetGoalProgress()}");
        }
    }

    public int CalculateTotalScore()
    {
        int totalScore = 0;
        foreach (Goal goal in goals)
        {
            totalScore += goal.Score;
        }
        return totalScore;
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                string goalType = goal.GetType().Name;
                writer.WriteLine($"{goalType},{goal.Name},{goal.Value},{goal.Score},{goal.IsComplete}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        goals.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                if (data.Length == 5)
                {
                    string goalType = data[0];
                    string name = data[1];
                    int value = int.Parse(data[2]);
                    int score = int.Parse(data[3]);
                    bool isComplete = bool.Parse(data[4]);

                    Goal goal;

                    switch (goalType)
                    {
                        case nameof(SimpleGoal):
                            goal = new SimpleGoal(name, value);
                            break;
                        case nameof(EternalGoal):
                            goal = new EternalGoal(name, value);
                            break;
                        case nameof(ChecklistGoal):
                            goal = new ChecklistGoal(name, value, value / 50); // Assuming 50 points per checklist item
                            break;
                        default:
                            continue;
                    }

                    goal.Score = score;
                    goal.IsComplete = isComplete;

                    goals.Add(goal);
                }
            }
        }
    }
}
