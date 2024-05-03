using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1991;
        job1._endYear = 1993;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Operations Manager";
        job2._startYear = 1994;
        job2._endYear = 2003;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        // job1.Display();
        // job2.Display();

        Resume resume = new Resume();
        resume._name = "Gospel Levi";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Console.WriteLine($"{resume._jobs[1]._jobTitle}");

        resume.Display();
    }

   
}