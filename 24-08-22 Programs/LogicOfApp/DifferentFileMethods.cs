using System;
using System.IO;

namespace LogicOfApp
{
    public class DifferentFileMethods
    {
        public static void MakeFile()
        {
            string path = @"S:\Apps\Dot Net\Day7\demo.txt";
            File.Create(path);
        }
    }
}
