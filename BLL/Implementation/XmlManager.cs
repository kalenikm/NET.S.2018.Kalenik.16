using System;
using System.Collections.Generic;
using System.Xml.Linq;
using BLL.Extensions;
using BLL.Interface.Interfaces;
using BLL.Interface.URL;
using DAL.Interface.Interfaces;

namespace BLL.Implementation
{
    public class XmlManager : IXmlManager
    {
        private string _filename;
        private List<UrlAddress> _urls;
        private IParser _parser;

        public XmlManager(IParser parser)
        {
            _parser = parser;
            _urls = new List<UrlAddress>();
        }

        public void LoadUrls(IFileLoader loader)
        {
            var urlstrings = loader.LoadStrings();
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
