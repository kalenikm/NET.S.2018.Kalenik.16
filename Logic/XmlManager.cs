using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Logic.URL;

namespace Logic
{
    public class XmlManager
    {
        private string _filename;
        private List<UrlAddress> _urls;
        private IParser<UrlAddress> _parser;

        public XmlManager(IParser<UrlAddress> parser)
        {
            _parser = parser;
            _urls = new List<UrlAddress>();
        }

        public void LoadUrls(string filename, IFileLoader loader)
        {
            var urlstrings = loader.LoadStrings(filename);
            foreach (var urlstr in urlstrings)
            {
                UrlAddress url;
                if (_parser.TryParse(urlstr, out url))
                {
                    _urls.Add(url);
                }
            }
        }

        public void WriteToXmlFile(string filename)
        {
            XElement root = new XElement("URLs");
            foreach (var url in _urls)
            {
                root.Add(url.ToXml());
            }
            root.Save(filename);
        }
    }
}