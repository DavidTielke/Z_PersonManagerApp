using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring.Contracts;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonParser : IPersonParser
{
    public Person Parse(string dataLine)
    {
        var parts = dataLine.Split(',');
        return new Person
        {
            Id = int.Parse(parts[0]),
            Name = parts[1],
            Age = int.Parse(parts[2])
        };
    }
}