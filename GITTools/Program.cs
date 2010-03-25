using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GITTools
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"E:\temp\source";
            string target = @"E:\temp\target";
            FileSystemInfo fsi = null;
            if (File.Exists(source))
                fsi = new FileInfo(source);
            else if (Directory.Exists(source))
                fsi = new DirectoryInfo(source);

        }
    }
}
