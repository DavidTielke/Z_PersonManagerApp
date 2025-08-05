using ConsoleClient.DataClasses;

namespace ConsoleClient;

public class PersonRepository
{
    private readonly PersonParser _parser;
    private readonly FileReader _fileReader;

    public PersonRepository()
    {
        _parser = new PersonParser();
        _fileReader = new FileReader();
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