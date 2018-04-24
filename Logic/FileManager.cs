using System;
using System.Collections.Generic;
using System.IO;

namespace Logic
{
    public class FileManager : IFileLoader
    {
        public IEnumerable<string> LoadStrings(string filename)
        {
            List<string> list = new List<string>();
            if (File.Exists(filename))
            {
                return File.ReadAllLines(filename);
            }
            throw new Exception();
        }
    }
}