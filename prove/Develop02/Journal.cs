public class Journal
{
    public List<Entry> _entries = [];

    public void DisplayJournal()
    {
        Console.WriteLine("All Journal Entries: ");
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void SaveFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }

    public void LoadFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] secs = line.Split("|");
            string date = secs[0];
            string prompt = secs[1];
            string text = secs[2];

            Entry newEntry = new Entry();
            newEntry._date = date;
            newEntry._prompt = prompt;
            newEntry._entry = text;

            _entries.Add(newEntry);
        }
    }
}