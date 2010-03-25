using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace GITTools
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\source";
            string target = @"E:\temp\target";
            DirectoryInfo sdi = new DirectoryInfo(source);
            foreach (FileSystemInfo item in sdi.GetFileSystemInfos())
            {
                if (Directory.Exists(item.FullName))
                {
                    if (!Directory.Exists(item.FullName + @"\.git"))
                    {
                        Console.WriteLine(item.FullName);
                        Process p = new Process();
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardInput = true;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.CreateNoWindow = true;
                        p.Start();
                        p.StandardInput.WriteLine("cd " + item.FullName);
                        p.StandardInput.WriteLine("git in");
                        p.StandardInput.WriteLine("exit");
                        p.WaitForExit(60000);
                        string s = p.StandardOutput.ReadToEnd();
                        p.Close();
                        Console.WriteLine(s);

                    }
                }
            }
        }
    }
}
