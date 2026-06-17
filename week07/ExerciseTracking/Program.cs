using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list that holds "Activity" objects
        List<Activity> activities = new List<Activity>();

        // Create one instance of each type of activity
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("04 Nov 2022", 45, 12.0);
        Swimming swimmingActivity = new Swimming("05 Nov 2022", 40, 20);

        // Put them all into the same list
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Iterate (loop) through the list and print the summary for each
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}