using System;
using System.Collections.Generic;
using System.IO;
using DAL.Interface.Interfaces;

namespace DAL.Implentation
{
    public class FileLoader : IFileLoader
    {
        private readonly string _filename;

        public FileLoader(string filename)
        {
            if (String.IsNullOrEmpty(filename))
            {
                throw new ArgumentException($"{nameof(filename)} is null or empty.");
            }

            _filename = filename;
        }

        public IEnumerable<string> LoadStrings()
        {
            if (File.Exists(_filename))
            {
                return File.ReadAllLines(_filename);
            }

            throw new FileNotFoundException();
        }
    }
}