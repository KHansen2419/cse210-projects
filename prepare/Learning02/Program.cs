using System;

class Program
{
    static void Main(string[] args)
    {

    

    Job job1= new Job();
    job1._jobTitle = "Software Engineer";
    job1._jobCompany = "Microsoft";
    job1._jobStartYear = 2019;
    job1._jobEndYear = 2022;

    Job job2= new Job();
    job2._jobTitle = "Manager";
    job2._jobCompany = "Apple";
    job2._jobStartYear = 2014;
    job2._jobEndYear = 2019;

     Resume myResume = new Resume();
    myResume._name = "Allison Rose";

    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.Display();
    }
}