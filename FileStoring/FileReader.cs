﻿using DavidTielke.PMA.Data.FileStoring.Contracts;

namespace DavidTielke.PMA.Data.FileStoring;

public class FileReader : IFileReader
{
    public IEnumerable<string> ReadLines(string path)
    {
        return File.ReadLines(path);
    }
}