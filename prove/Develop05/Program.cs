/*I haven't done any exceeding yet, I believe this meets all the core main requirements successfully (hopefully), 
so I want to see if this is all good minus the creativity and then add special flair after that in a resubmission
 ~ Thank you! ~ */

using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine($"Total Points: {manager.TotalPoints}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.DisplayGoalShort();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    Console.Write("Enter filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "5":
                    Console.Write("Enter filename to load goals: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
