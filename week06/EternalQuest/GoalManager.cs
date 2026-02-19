using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private const int CreateNewGoalChoice = 1;
    private  const int ListGoalsChoice = 2;
    private  const int SaveGoalsChoice = 3;
    private  const int LoadGoalsChoice = 4;
    private  const int RecordEventChoice = 5;
    private  const int QuitChoice = 6;


    // goal select constant
    private  const int SimpleGoal = 1;
    private  const int EternalGoal = 2;
    private  const int ChecklistGoal = 3;

    public GoalManager()
    {
        // _goals = goals;
        // _score = score; 
    }


    private void DisplayMainMenu()
    {
         // Create the Menu
        Console.WriteLine($"You have {_score} points");
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
                SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, points, false); 
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
                int amountCompleted = 0; 
                ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDescription, points, target, bonus, amountCompleted);
                _goals.Add(newChecklistGoal); 
            break;

            default: 
                Console.WriteLine("Invalid choice"); 
            break;
        }
        
      
    }


    public void ListGoalDetails()
    {
        // TODO
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal currentGoal = _goals[i]; 
            Console.WriteLine($"{i + 1}. {currentGoal.GetDetailsString()}");
        }
    }
    

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string goalFileName = Console.ReadLine();
        // SOME VALIDATION HERE
        using (StreamWriter sw = new StreamWriter(goalFileName))
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                if (i == 0)
                {
                    sw.WriteLine(_score); 
                }
                Goal currentGoal = _goals[i];
                sw.WriteLine(currentGoal.GetStringRepresentation()); 
            }
        }
    }

    public void LoadGoals()
    {
        const string simpleGoalName = "SimpleGoal";
        const string eternalGoalName = "EternalGoal";
        const string checkListGoalName = "ChecklistGoal"; 

        Console.Write("What is the filename for the goal file? ");
        string path = Console.ReadLine(); 
        int k = 0;
        
        if (File.Exists(path))
        {
            foreach(string line in File.ReadLines(path))
            {

                if (k == 0)
                {
                    _score = int.Parse(line);
                    k++;
                    continue; 
                }
                string[] mainParts = line.Split(":");
                string goalType = mainParts[0].Trim();
                string [] goalData = mainParts[1].Split(",");

                if (goalType == simpleGoalName)
                {
                    string name = goalData[0].Trim();
                    string description = goalData[1].Trim();
                    int points = int.Parse(goalData[2].Trim());
                    string boolValue = goalData[3].Trim(); 
                    bool isComplete = false;
                    if (boolValue == "False")
                    {
                        isComplete = false;
                    }else if(boolValue == "True")
                    {
                        isComplete = true;
                    }

                    SimpleGoal newGoal = new SimpleGoal(name, description, points, isComplete);

                    _goals.Add(newGoal); 
                    
                }else if(goalType == eternalGoalName)
                {
                    string name = goalData[0].Trim();
                    string description = goalData[1].Trim();
                    int points = int.Parse(goalData[2].Trim());
                    EternalGoal newGoal = new EternalGoal(name, description, points);
                    _goals.Add(newGoal);
                }
                else if (goalType == checkListGoalName)
                {
                    string name = goalData[0].Trim();
                    string description = goalData[1].Trim();
                    int points = int.Parse(goalData[2].Trim());
                    int bonus = int.Parse(goalData[3].Trim());
                    int target = int.Parse(goalData[4].Trim());
                    int amountCompleted = int.Parse(goalData[5].Trim()); 
                    ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                    _goals.Add(newGoal);
                }

                k++;

            }
        }

        Console.WriteLine("Goals successfully loaded"); 
        Console.WriteLine($"the goals list length is: {_goals.Count}"); 

    }


    public void RecordEvent()
    {
        // TODO: completing goals
        const string simpleGoalName = "SimpleGoal";
        const string eternalGoalName = "EternalGoal";
        const string checkListGoalName = "ChecklistGoal";
        Console.Write("Which goals did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()); 
        for (int i = 0; i < _goals.Count; i++)
        {
            string currentString = _goals[i].GetStringRepresentation();
            string [] mainParts = currentString.Split(":");
            string goalType = mainParts[0].Trim();
            string[] goalData = mainParts[1].Split(","); 

            if (choice == i + 1)
            {
                if (goalType == simpleGoalName)
                {
                    if (!_goals[i].IsCompleted())
                    {
                        _goals[i].RecordEvent();
                        _score += _goals[i].GetPoints();
                    }
                    else
                    {
                        Console.WriteLine("This simple goal was completed"); 
                    }

                }else if (goalType == eternalGoalName)
                {
                    _goals[i].RecordEvent();
                    _score += _goals[i].GetPoints(); 
                    
                }else if (goalType == checkListGoalName)
                {
                    int target = int.Parse(goalData[4].Trim());

                    if (!_goals[i].IsCompleted())
                    {                       
                         _goals[i].RecordEvent();  
                        _score += _goals[i].GetPoints();
                        if (_goals[i].GetAmountCompleted() == target)
                        {
                            _score += _goals[i].GetBonus(); 
                        }
                    }
                }
            }
           
        }
    }



    public void Start()
    {
        bool hasStopped = false;

        while (!hasStopped)
        {
            DisplayMainMenu();

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case CreateNewGoalChoice:
                // display type of goals
                    DisplayGoalTypes(); 
                    CreateGoal();
                break;

                case ListGoalsChoice:
                    ListGoalDetails(); 
                break;

                case SaveGoalsChoice:
                    SaveGoals(); 
                break;

                case LoadGoalsChoice:
                    LoadGoals(); 
                break;

                case RecordEventChoice:
                    RecordEvent(); 
                break;

                case QuitChoice:
                    Console.WriteLine("You have terminated the program.");
                    hasStopped = true;
                break;

                default:
                    Console.WriteLine("Invalid choice");
                break;


            }
        }
    }
       
    


   
}