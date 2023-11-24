using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    private static ActivityLog activityLog = new ActivityLog();

    static void Main()
    {
        while (true)
        {
            DisplayMenu();
            int selectedActivity = GetSelectedActivity();

            if (selectedActivity == 0)
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }

            int duration = GetActivityDuration();

            switch (selectedActivity)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity(duration, activityLog);
                    breathingActivity.StartActivity();
                    break;
                case 2:
                    ListingActivity listingActivity = new ListingActivity(duration, activityLog);
                    listingActivity.StartActivity();
                    break;
                case 3:
                    ReflectionActivity reflectionActivity = new ReflectionActivity(duration, activityLog);
                    reflectionActivity.StartActivity();
                    break;
                case 4: // Added VisualizationActivity
                    VisualizationActivity visualizationActivity = new VisualizationActivity(duration, activityLog);
                    visualizationActivity.StartActivity();
                    break;
                default:
                    Console.WriteLine("Invalid activity selection. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("       Mindfulness Program          ");
        Console.WriteLine("=====================================");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");
        Console.WriteLine("4. Visualization Activity"); // Added Visualization Activity
        Console.WriteLine("0. Exit");
        Console.WriteLine("=====================================");
    }

    private static int GetSelectedActivity()
    {
        Console.Write("Select an activity (0 to exit): ");
        int selectedActivity;
        while (!int.TryParse(Console.ReadLine(), out selectedActivity) || selectedActivity < 0 || selectedActivity > 4)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
            Console.Write("Select an activity (0 to exit): ");
        }
        return selectedActivity;
    }

    private static int GetActivityDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Enter the duration of the activity in seconds: ");
        }
        return duration;
    }
}