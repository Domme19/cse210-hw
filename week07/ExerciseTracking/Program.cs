using System;
using System.Diagnostics;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        // create a list of activities
        List<Activity> activities = new List<Activity>();
        // adding to the list
        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new StationaryBicycle("04 Nov 2022", 45, 15.0));
        activities.Add(new Swimming("05 Nov 2022", 20, 20));

        Console.WriteLine("Exercise Tracking Summary:\n");
        for (int i = 0; i < activities.Count; i++)
        {
            Activity currentActivity = activities[i];
            string summary = currentActivity.GetSummary();
            Console.WriteLine(summary); 
        }
    }
}