using DavidTielke.PMA.Logic.PersonManagement.Contracts;

namespace DavidTielke.PMA.UI.ConsoleClient;


public class PersonDisplayCommands : IPersonDisplayCommands
{
    private readonly IPersonManager _manager;

    public PersonDisplayCommands(IPersonManager manager)
    {
        _manager = manager;
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