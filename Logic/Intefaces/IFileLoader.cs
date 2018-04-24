using System.Collections.Generic;

namespace Logic
{
    public interface IFileLoader
    {
        IEnumerable<string> LoadStrings(string filename);
    }
}