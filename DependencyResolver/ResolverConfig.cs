using BLL.Interface.Interfaces;
using BLL.Implementation;
using DAL.Implentation;
using DAL.Interface.Interfaces;
using Ninject;

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolver(this IKernel kernel)
        {
            kernel.Bind<IXmlManager>().To<XmlManager>();
            kernel.Bind<IFileLoader>().To<FileLoader>().WithConstructorArgument("test.txt");
            kernel.Bind<IParser>().To<UrlParser>();
        }
    }
}
