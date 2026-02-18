public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

     private const int CreateNewGoal = 1;
    private  const int ListGoals = 2;
    private  const int SaveGoals = 3;
    private  const int LoadGoals = 4;
    private  const int RecordEvent = 5;
    private  const int Quit = 6;

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


    private static void GoalSelectSwitch()
    {
        const int SimpleGoal = 1;
        const int EternalGoal = 2;
        const int ChecklistGoal = 3;
        Console.Write("Which type of goal would you like to create? ");
        int goalChoice = int.Parse(Console.ReadLine());

        switch (goalChoice)
        {
            case SimpleGoal:
                Console.WriteLine("You created a simple Goal");
                Console.WriteLine("In progress");
            break;

            case EternalGoal:
                Console.WriteLine("You created an Eternal Goal");
                Console.WriteLine("In progress");

            break;

            case ChecklistGoal:
                Console.WriteLine("You created a checklist goal");
                Console.WriteLine("In progress");
            break;

            default: 
                Console.WriteLine("Invalid choice"); 
            break;
        }
    }

    public void Start()
    {
        //    Display Main menu
        DisplayMainMenu();

        // receive input to select menu 
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case CreateNewGoal:
            // display type of goals
                DisplayGoalTypes();
                GoalSelectSwitch();      
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
    


    public void CreateGoal()
    {
        // TODO: create Goal
    }
}