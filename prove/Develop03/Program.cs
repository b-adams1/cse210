/*I haven't done any exceeding yet, I believe this meets all the core main requirements successfully (hopefully), 
so I want to see if this is all good minus the creativity and then add special flair after that in a resubmission
 ~ Thank you! ~ */

using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureGenerator scriptures = new ScriptureGenerator();
        Scripture scripture = scriptures.GetRandomScripture();
        while (true)
        {
            scripture.Display();
            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || scripture.AllHidden())
                break;
            scripture.HideRandomWords();
        }
    }
}