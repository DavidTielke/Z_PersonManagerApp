namespace DavidTielke.PMA.Data.FileStoring.Contracts;

public interface IFileReader
{
    IEnumerable<string> ReadLines(string path);
}