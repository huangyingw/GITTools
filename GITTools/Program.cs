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
            string source = @"E:\temp\source\tools";
            string target = @"E:\temp\target";
            DirectoryInfo sdi = new DirectoryInfo(source);
            string result = null;
            foreach (FileSystemInfo item in sdi.GetFileSystemInfos())
            {
                if (Directory.Exists(item.FullName))
                {
                    if (!Directory.Exists(item.FullName + @"\.git"))
                    {
                        result = null;
                        Console.WriteLine(item.FullName);
                        Console.WriteLine(CallDos(item.FullName, "git in"));
                        Console.WriteLine(CallDos(item.FullName, "git ad ."));
                        Console.WriteLine(CallDos(item.FullName, "git ci \"Init\""));
                    }
                    else
                    {
                        string filepath = item.FullName + @"\.gitignore";
                        if (!File.Exists(filepath))
                        {
                            File.Create(filepath);
                        }
                        using (StreamWriter sw = File.AppendText(filepath))
                        {
                            sw.WriteLine(string.Format("*.bak"));
                        }
                    }
                }
            }
        }

        static string CallDos(string path, string command)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine("cd " + path);
            p.StandardInput.WriteLine(command);
            p.StandardInput.WriteLine("exit");
            p.WaitForExit(60000);
            string s = p.StandardOutput.ReadToEnd();
            p.Close();
            return s;
        }
    }
}
