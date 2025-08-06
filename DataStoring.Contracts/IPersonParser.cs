using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring.Contracts;

public interface IPersonParser
{
    Person Parse(string dataLine);
}