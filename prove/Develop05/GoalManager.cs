using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void GainPoints(int points)
    {
        _totalPoints += points;
        Console.WriteLine($"You gained {points} points!");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void DisplayGoalShort()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];

            string status = "[ ]";

            if (goal.IsComplete())
            {
                status = "[X]";
            }

            Console.WriteLine($"{i + 1}. {status} {goal.GetInfo()}");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void DisplayGoalVerbose()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetInfo()}");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Goal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select type: ");
        string choice = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == "3")
        {
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            Console.Write("Times needed to complete: ");
            int target = int.Parse(Console.ReadLine());

            CheckListGoal goal = new CheckListGoal(name, description, points, bonus, target);
            _goals.Add(goal);
        }

        Console.WriteLine("Goal created!");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            Console.ReadLine();
            return;
        }

        DisplayGoalShort();

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            GainPoints(points);
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);

            for (int i = 0; i < _goals.Count; i++)
            {
                writer.WriteLine(_goals[i].GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
        Console.ReadLine();
    }

    public void LoadGoals(string filename)
    {
           if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "Simple")
            {
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points);

                if (isComplete)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (type == "Checklist")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                CheckListGoal goal = new CheckListGoal(name, description, points, bonus, target);

                for (int j = 0; j < completed; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }
}
