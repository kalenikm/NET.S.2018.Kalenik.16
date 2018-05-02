using BLL.Interface.Interfaces;
using DAL.Interface.Interfaces;
using DependencyResolver;
using Ninject;

namespace ConsoleUI
{
    class Program
    {
        private static readonly IKernel resolver;

        static Program()
        {
            resolver = new StandardKernel();
            resolver.ConfigurateResolver();
        }
        static void Main(string[] args)
        {
            IFileLoader loader = resolver.Get<IFileLoader>();
            IXmlManager manager = resolver.Get<IXmlManager>();
            manager.LoadUrls(loader);
            manager.WriteToXmlFile("xml.txt");
        }
    }
}
