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
            FileSystemInfo so = null;
            if (File.Exists(source))
                so = new FileInfo(source);
            else if (Directory.Exists(source))
                so = new DirectoryInfo(source);
            foreach (FileSystemInfo item in so.g)
            {
                
            }
        }
    }
}
