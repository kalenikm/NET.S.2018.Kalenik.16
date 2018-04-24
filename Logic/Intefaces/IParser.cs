using Logic.URL;

namespace Logic
{
    public interface IParser<T>
    {
        bool TryParse(string str, out T url);
    }
}