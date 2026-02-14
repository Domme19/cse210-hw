using System.Dynamic;

public class ListingActivity : Activity
{
    private int _count;
    private List<String> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }


    public void Run()
    {
        // TODO
    }


    public void GetRandomPrompt()
    {
        // TODO
    }

    public List<String> GetListFromUser()
    {
        List<string> emptyList = new List<string>();
        emptyList.Add("SOmething"); 
        emptyList.Add("Trying hard"); 
        emptyList.Add("Harder"); 
        return emptyList;
    }
}