using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
}

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    static void Write()
    {
        
    }

    static void Display()
    {
        
    }

    static void Save()
    {
        
    }

    static void Load()
    {
        
    }
}

class Entry
{
    public string _filename;
    public int _prompt;
    public string _date;
    public string _content;
    static void Display()
    {
        
    }
}

class PromptGenerator
{
    public List<String> _prompts = new List<String>();
    static int GeneratePrompt()
    {
        
    }

    static string Display(int)
    {
        
    }
}