using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}

//www.plantuml.com/plantuml/png/SoWkIImgAStDuKhEIImkLl3AJrAevjADJyxFBKZCgxHIA2ufoinB1ufavIU5P9Raf289WVL6fYOMMIbavfK01LBpKX1SRPVCueASn4eDJIk5ilpC5AvQg1r1gSMbkQbWQ_8ISrDHxIYsKl39B2wn0Jh43fiHKCqsDRgw8CToEG3j13eV0000