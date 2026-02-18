using System.Diagnostics;
using System.Drawing;
using System.Security;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private const int CreateNewGoal = 1;
    private  const int ListGoals = 2;
    private  const int SaveGoals = 3;
    private  const int LoadGoals = 4;
    private  const int RecordEvent = 5;
    private  const int Quit = 6;


    // goal select constant
    private  const int SimpleGoal = 1;
    private  const int EternalGoal = 2;
    private  const int ChecklistGoal = 3;

    public GoalManager()
    {
        // _goals = goals;
        // _score = score; 
    }


    private static void DisplayMainMenu()
    {
         // Create the Menu
        Console.WriteLine("You have 0 points");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }


    private static void DisplayGoalTypes()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal"); 
    }


    public void CreateGoal()
    {
        // initialized variables;
        string goalName = "";
        string goalDescription = "";
        int points = 0;

        Console.Write("Which type of goal would you like to create? ");
        int goalChoice = int.Parse(Console.ReadLine());

        // TODO: create Goal
         switch (goalChoice)
        {
            case SimpleGoal:
                Console.Write("What is the name of your Goal? ");
                goalName = Console.ReadLine(); 
                Console.WriteLine(""); 
                Console.Write("What is a short description of it? ");
                goalDescription = Console.ReadLine(); 
                Console.Write("\n"); 
                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine()); 

                // adding a goal to the 
                SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, points); 
                _goals.Add(newSimpleGoal); 
            break;

            case EternalGoal:
                Console.Write("What is the name of your Goal? ");
                goalName = Console.ReadLine(); 
                Console.WriteLine(); 
                Console.Write("What is a short description of it? ");
                goalDescription = Console.ReadLine(); 
                Console.Write("\n"); 
                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine()); 

                // adding goals
                EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, points);
                _goals.Add(newEternalGoal); 
            break;

            case ChecklistGoal:
                Console.Write("What is the name of your Goal? ");
                goalName = Console.ReadLine(); 
                Console.WriteLine(""); 
                Console.Write("What is a short description of it? ");
                goalDescription = Console.ReadLine(); 
                Console.Write("\n"); 
                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine()); 
                Console.Write("\n"); 
                Console.Write("How many times does this goal need to be accomplished for a bonus? "); 
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine()); 

                // adding goal
                ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDescription, points, target, bonus);
                _goals.Add(newChecklistGoal); 
            break;

            default: 
                Console.WriteLine("Invalid choice"); 
            break;
        }
        
      
    }


    public void ListGoalNames()
    {
        // TODO
        Console.WriteLine("The goals are: ");
    }



    public void Start()
    {
        DisplayMainMenu();

        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case CreateNewGoal:
            // display type of goals
                DisplayGoalTypes();
                // Console.Write("Which type of goal would you like to create? ");
                // int goalChoice = int.Parse(Console.ReadLine());     
                CreateGoal();
            break;

            case ListGoals:
                Console.WriteLine("List goals");
                Console.WriteLine("In progress");
            break;

            case SaveGoals:
                Console.WriteLine("Save Goals");
                Console.WriteLine("In progress");
            break;

            case LoadGoals:
                Console.WriteLine("Load Goals");
                Console.WriteLine("In progress");
            break;

            case RecordEvent:
                Console.WriteLine("Record Event");
                Console.WriteLine("In progress");
            break;

            case Quit:
                Console.WriteLine("You have terminated the program.");
            break;

            default:
                Console.WriteLine("Invalid choice");
            break;


        }
    }
    


   
}