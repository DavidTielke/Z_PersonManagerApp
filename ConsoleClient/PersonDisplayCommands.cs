namespace ConsoleClient;


public class PersonCloner
{

}

public class PersonDisplayCommands
{
    private readonly PersonManager _manager;
    public PersonDisplayCommands()
    {
        _manager = new PersonManager();
    }
        
    public void DisplayAllAdults()
    {
        var adults = _manager.GetAllAdults().ToList();
        PrintTitle("Erwachsene", adults.Count);
        adults.ForEach(a => Console.WriteLine(a.Name));
    }

    private void PrintTitle(string title, int count)
    {
        Console.WriteLine($"### {title} ({count}) ###");
    }

    public void DisplayAllChildren()
    {
        var children = _manager.GetAllChildren().ToList();
        PrintTitle("Erwachsene", children.Count);
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}