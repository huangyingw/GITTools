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
            string source = @"E:\temp\source\tools";
            string target = @"E:\temp\target";
            DirectoryInfo sdi = new DirectoryInfo(source);
            foreach (FileSystemInfo item in sdi.GetFileSystemInfos())
            {
                if (Directory.Exists(item.FullName))
                {   
                    
                }   
            }
        }
    }
}
