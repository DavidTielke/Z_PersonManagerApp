namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commands = new PersonDisplayCommands();

            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
