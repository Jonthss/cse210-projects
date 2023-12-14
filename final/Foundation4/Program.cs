using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating activities
        var runningActivity = new Running("03 Nov 2022", 30, 3.0);
        var cyclingActivity = new Cycling("03 Nov 2022", 30, 15.0);
        var swimmingActivity = new Swimming("03 Nov 2022", 30, 10);

        // Adding activities to a list
        List<Activity> activities = new List<Activity> { runningActivity, cyclingActivity, swimmingActivity };

        // Displaying summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("------------");
        }
    }
}
