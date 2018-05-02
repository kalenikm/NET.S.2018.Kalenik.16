using System.Collections.Generic;

namespace BLL.Interface.URL
{
    public class UrlAddress
    {
        public string Scheme { get; set; }
        public string Host { get; set; }
        public string UrlPath { get; set; }
        public List<Parameter> Parameters { get; set; }
    }
}
