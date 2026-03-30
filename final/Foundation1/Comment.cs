using System;

class Comment
{
    private string name;
    private string text;

    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }

    public void SetText(string t)
    {
        text = t;
    }

    public string GetText()
    {
        return text;
    }
}