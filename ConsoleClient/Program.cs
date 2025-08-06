using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Logic.PersonManagement;
using Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            new ServiceCollectionInitializer().Initialize(collection);

            collection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();
            var provider = collection.BuildServiceProvider();

            var commands = provider.GetRequiredService<IPersonDisplayCommands>();

            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
