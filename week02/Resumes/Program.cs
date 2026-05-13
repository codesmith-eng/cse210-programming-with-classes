using System;

class Program
{
    static void Main(string[] args)
    {
        //creating an instance of the Job class and invoking it with the constructor keyword "new"
        //Here, the Job class is like custom data type that holds different data types, like the data type is Job
        Job job1 = new Job();

        //The new variable here is job1 and the custom data type is "Job"

        //passing values into the members of the class or variables in the class
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;


        //creating another instance of the Job class, the new variable here is job2 and the custom data type is Job
        Job job2 = new Job();
        //passing values into the variables in the class
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //creating an instance of the Resume class and invoking it with the constructor keyword "new"
        Resume myResume = new Resume();

        myResume._name = "Allison Rose";
        //Adding the two created jobs with Job class to the List created in the Resume class
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        //calling the displayResume() method from the Resume class to display its content
        myResume.displayResume();
    }
}
