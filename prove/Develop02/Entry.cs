public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public void Display()
    {
        Console.WriteLine($"Date: {this._date}");
        Console.WriteLine($"Prompt: {this._prompt}");
        Console.WriteLine($"Entry: {this._entry}");
    }
}