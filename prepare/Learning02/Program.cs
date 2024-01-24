using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2001";
        job1._endYear = "2024";

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Data Analyst";
        job2._startYear = "1998";
        job2._endYear = "2024";

        Resume resume1 = new Resume();
        resume1._name = "Ruby Higdon";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}