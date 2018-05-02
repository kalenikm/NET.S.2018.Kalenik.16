using System.Xml.Linq;
using BLL.Interface.URL;

namespace BLL.Extensions
{
    public static class XmlExtension
    {
        public static XElement ToXml(this UrlAddress url)
        {
            XElement xml = new XElement("URL");
            xml.Add(new XElement("Schema", url.Scheme));
            xml.Add(new XElement("Host", url.Host));
            if(ReferenceEquals(null, url.UrlPath))
            {
                return xml;
            }
            xml.Add(new XElement("UrlPath", url.UrlPath));
            xml.Add(new XElement("Parameters"));
            if (!ReferenceEquals(null, url.Parameters))
            {
                foreach (var param in url.Parameters)
                {
                    xml.Element("Parameters")?.Add(
                    new XElement("Parameter",
                        new XElement("Name", param.Name),
                        new XElement("Value", param.Value)));
                }
            }
            return xml;
        }
    }
}