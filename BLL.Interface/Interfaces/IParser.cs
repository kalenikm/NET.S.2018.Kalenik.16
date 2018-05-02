using BLL.Interface.URL;

namespace BLL.Interface.Interfaces
{
    public interface IParser
    {
        bool TryParse(string str, out UrlAddress url);
    }
}