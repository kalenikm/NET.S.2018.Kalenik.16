using System.Collections.Generic;
using System.Text.RegularExpressions;
using Logic.URL;

namespace Logic
{
    public class UrlParser : IParser<UrlAddress>
    {
        public bool TryParse(string urlstring, out UrlAddress url)
        {
            url = new UrlAddress();
            var match = Regex.Match(urlstring,
                @"^(http|https|ftp)://(([\w\-]+)(\.[\w\-]+)+)(/([\w\-]+(/[\w\-\.]+)*))?(/?|(\?([\w]+=[\w]*(&([\w]+)=([\w]*))*)))$");
            if (!match.Success)
            {
                url = null;
                return false;
            }

            url.Scheme = match.Groups[1].Value;
            url.Host = match.Groups[2].Value;
            url.UrlPath = match.Groups[6].Value;
            url.Parameters = new List<Parameter>();
            foreach (var param in match.Groups[10].ToString().Split('&'))
            {
                var paramMatch = Regex.Match(param, @"([\w]+)=([\w]*)");
                if (!paramMatch.Success)
                {
                    url.Parameters = null;
                    return true;
                }
                url.Parameters.Add(new Parameter(paramMatch.Groups[1].Value, paramMatch.Groups[2].Value));
            }
            return true;
        }
    }
}