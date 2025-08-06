using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contracts;
using DavidTielke.PMA.Data.FileStoring.Contracts;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _parser;
    private readonly IFileReader _fileReader;

    public PersonRepository(IPersonParser parser, IFileReader fileReader)
    {
        _parser = parser;
        _fileReader = fileReader;
    }
    public IQueryable<Person> Load()
    {
        var dataLines = _fileReader.ReadLines("data.csv");
        var persons = dataLines
            .Select(_parser.Parse)
            .AsQueryable();
        return persons;
    }
}