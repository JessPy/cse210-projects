using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._companyName = "Apple";
        job2._jobTitle = "UX Developer";
        job2._startYear = 2015;
        job2._endYear = 2018;

        Job job3 = new Job();
        job3._companyName = "Google";
        job3._jobTitle = "IA Specialist";
        job3._startYear = 2010;
        job3._endYear = 2018;

        Resume myResume = new Resume();
        myResume._personName = "Jessica";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.DisplayResume();
    
    }
}
