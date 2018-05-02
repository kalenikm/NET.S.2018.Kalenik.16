using System.Collections.Generic;

namespace DAL.Interface.Interfaces
{
    public interface IFileLoader
    {
        IEnumerable<string> LoadStrings();
    }
}