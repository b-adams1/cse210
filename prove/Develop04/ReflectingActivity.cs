using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _promptsListReflection;
    private List<string> _reflectionQuestionsList;

    public ReflectingActivity() 
        : base("Reflection", "This activity helps you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _promptsListReflection = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you overcame a fear.",
            "Think of a time when you showed leadership.",
            "Think of a time when you made a positive difference.",
            "Think of a time when you stayed calm under pressure.",
            "Think of a time when you learned from a mistake.",
            "Think of a time when you achieved a personal goal.",
            "Think of a time when you helped someone without being asked.",
            "Think of a time when you persevered through a challenge.",
            "Think of a time when you showed kindness to someone.",
            "Think of a time when you worked hard for something important.",
            "Think of a time when you handled a difficult situation well.",
        };

        _reflectionQuestionsList = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself?",
            "How can you apply this experience in the future?",
            "What challenges did you overcome?",
            "What strengths did you use in this moment?",
            "How did others benefit from your actions?",
            "What would you do differently next time?",
            "What motivated you to act?",
            "How did this experience change your perspective?",
            "What does this say about your character?",
        };
    }

    public void Run()
    {
        StartMessage();

        string prompt = GetRandomPrompt(_promptsListReflection);
        DisplayPrompt(prompt);

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nReflect on the following questions:");

        List<string> usedQuestions = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            // Reset if all questions have been used
            if (usedQuestions.Count == _reflectionQuestionsList.Count)
            {
                usedQuestions.Clear();
            }

            string question = GetUniqueQuestion(usedQuestions);

            Console.WriteLine($"\n{question}");

            usedQuestions.Add(question);

            PauseSpinner(10);
        }

        EndMessage();
    }

    private string GetUniqueQuestion(List<string> usedQuestions)
    {
        Random rand = new Random();

        while (true)
        {
            int index = rand.Next(_reflectionQuestionsList.Count);
            string question = _reflectionQuestionsList[index];

            bool alreadyUsed = false;

            for (int i = 0; i < usedQuestions.Count; i++)
            {
                if (usedQuestions[i] == question)
                {
                    alreadyUsed = true;
                    break;
                }
            }

            if (!alreadyUsed)
            {
                return question;
            }
        }
    }
}