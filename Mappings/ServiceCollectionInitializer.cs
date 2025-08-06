using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.DataStoring.Contracts;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Data.FileStoring.Contracts;
using DavidTielke.PMA.Logic.PersonManagement;
using DavidTielke.PMA.Logic.PersonManagement.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Mappings
{
    public class ServiceCollectionInitializer
    {
        public void Initialize(IServiceCollection collection)
        {
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IFileReader, FileReader>();
        }
    }
}
