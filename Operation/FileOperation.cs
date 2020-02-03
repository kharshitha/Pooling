using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Operation
{
    public class FileOperation
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
        public void Write(string text, string path)
        {
            File.WriteAllText(path, text);
        }
    }
}
