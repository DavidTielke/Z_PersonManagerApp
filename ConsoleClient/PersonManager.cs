using System.Reflection.Metadata.Ecma335;
using ConsoleClient.DataClasses;

namespace ConsoleClient;

public class PersonManager
{
    private readonly PersonRepository _repository;
    public PersonManager()
    {
        _repository = new PersonRepository();
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