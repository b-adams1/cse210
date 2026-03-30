/*I don't think there is any exceeding/comment that needs to be made, but just in case, I didn't really do any excess creativity except for the details on the video!
~ Thanks! ~*/ 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1.SetTitle("Cool Pranks and Tricks to Try");
        v1.SetAuthor("CoolGuyPranker");
        v1.SetLength(250);

        Comment c1 = new Comment();
        c1.SetName("JakeTheDog");
        c1.SetText("lol");
        v1.AddComment(c1);

        Comment c2 = new Comment();
        c2.SetName("InsaneBrain");
        c2.SetText("3:45 i laughed at this part");
        v1.AddComment(c2);

        Comment c3 = new Comment();
        c3.SetName("HankHillLvr");
        c3.SetText("keep making videos");
        v1.AddComment(c3);

        videos.Add(v1);

        Video v2 = new Video();
        v2.SetTitle("How to Draw with Charcoal");
        v2.SetAuthor("Art Tutorials");
        v2.SetLength(400);

        Comment c4 = new Comment();
        c4.SetName("AnnaTheArtist");
        c4.SetText("this helped so much");
        v2.AddComment(c4);

        Comment c5 = new Comment();
        c5.SetName("TomBombadilly");
        c5.SetText("nice tutorial, very helpful");
        v2.AddComment(c5);

        Comment c6 = new Comment();
        c6.SetName("LollipopLily");
        c6.SetText("this helped me get better");
        v2.AddComment(c6);

        videos.Add(v2);

        Video v3 = new Video();
        v3.SetTitle("My Daily Workout");
        v3.SetAuthor("FitnessBro");
        v3.SetLength(800);

        Comment c7 = new Comment();
        c7.SetName("ChrisRB");
        c7.SetText("how do you do this");
        v3.AddComment(c7);

        Comment c8 = new Comment();
        c8.SetName("XxNinaxX");
        c8.SetText("solid routine");
        v3.AddComment(c8);

        Comment c9 = new Comment();
        c9.SetName("CloneWB211");
        c9.SetText("ow");
        v3.AddComment(c9);

        videos.Add(v3);

        Video v4 = new Video();
        v4.SetTitle("New MacBook Review");
        v4.SetAuthor("TheGadgetGuy");
        v4.SetLength(500);

        Comment c10 = new Comment();
        c10.SetName("Evanescence93");
        c10.SetText("doesnt seem worth it");
        v4.AddComment(c10);

        Comment c11 = new Comment();
        c11.SetName("OliviaRodrigoLover");
        c11.SetText("might buy this now");
        v4.AddComment(c11);

        Comment c12 = new Comment();
        c12.SetName("NoahARK");
        c12.SetText("good video");
        v4.AddComment(c12);

        videos.Add(v4);

        foreach (Video v in videos)
        {
            Console.WriteLine("Title: " + v.GetTitle());
            Console.WriteLine("Author: " + v.GetAuthor());
            Console.WriteLine("Length (seconds): " + v.GetLength());
            Console.WriteLine("Number of Comments: " + v.GetCommentCount());

            Console.WriteLine("Comments:");
            v.DisplayComments();

            Console.WriteLine();
        }
    }
}