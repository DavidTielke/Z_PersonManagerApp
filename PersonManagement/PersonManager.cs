using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contracts;
using DavidTielke.PMA.Logic.PersonManagement.Contracts;

namespace DavidTielke.PMA.Logic.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _repository;

    public PersonManager(IPersonRepository repository)
    {
        _repository = repository;
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _repository.Load().Where(p => p.Age >= 18);
    }

    public Person Copy(Person source) => default;

    public IQueryable<Person> GetAllChildren()
    {
        return _repository.Load().Where(p => p.Age < 18);
    }
}