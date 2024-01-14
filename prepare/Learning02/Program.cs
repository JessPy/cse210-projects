using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Nissei";
        job1._jobTitle = "Assistant";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "PUCPR";
        job2._jobTitle = "Undergraduate Research Project";
        job2._startYear = 2023;
        job2._endYear = 2024;
        
        Resume myResume = new Resume();
        myResume._name = "Jessica Bodart Guimarães";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();

    }
}
