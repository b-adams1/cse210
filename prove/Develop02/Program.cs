using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int userInput = 0;
        Console.WriteLine("This is the Journal Program");
        Console.Write("");

        while (userInput != 5)
        {
            Console.WriteLine("Please choose one of the following: ");
            Console.WriteLine("1. Write in the Journal");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the Journal");
            Console.WriteLine("4. Load the Journal");
            Console.WriteLine("5. Quit");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                string prompt = promptGenerator.Prompt();
                Console.WriteLine(prompt);
                Console.Write("Entry: ");
                string userEntry = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._prompt = prompt;
                newEntry._entry = userEntry;

                journal.AddEntry(newEntry);
            }
            else if (userInput == 2)
            {
                journal.DisplayJournal();
            }
            else if (userInput == 3)
            {
                Console.Write("What name would you like to save under? ");
                string filename = Console.ReadLine();
                journal.SaveFile(filename);
            }
            else if (userInput == 4)
            {
                Console.Write("What name would you like to load? ");
                string filename = Console.ReadLine();
                journal.LoadFile(filename);
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Thank you for using the Journal");
            }
        }
    }
}
