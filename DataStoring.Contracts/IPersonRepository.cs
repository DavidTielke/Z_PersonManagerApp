using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring.Contracts;

public interface IPersonRepository
{
    IQueryable<Person> Load();
}