using System;
using System.Collections.Generic;

class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments = new List<Comment>();

    public void SetTitle(string t)
    {
        title = t;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetAuthor(string a)
    {
        author = a;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetLength(int l)
    {
        length = l;
    }

    public int GetLength()
    {
        return length;
    }

    public void AddComment(Comment c)
    {
        comments.Add(c);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayComments()
    {
        for (int i = 0; i < comments.Count; i++)
        {
            Console.WriteLine(comments[i].GetName() + ": " + comments[i].GetText());
        }
    }
}