using DAL.Interface.Interfaces;

namespace BLL.Interface.Interfaces
{
    public interface IXmlManager
    {
        void LoadUrls(IFileLoader loader);

        void WriteToXmlFile(string filename);
    }
}