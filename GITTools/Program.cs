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
            foreach (FileSystemInfo item in sdi.GetFileSystemInfos())
            {
                if (Directory.Exists(item.FullName))
                {
                    if (!Directory.Exists(item.FullName+@"\.git"))
                    {
                        Console.WriteLine(item.FullName);
                        //string command = @" item.FullName";
                        //System.Diagnostics.Process.Start("cd", command);
                        //command = @" in";
                        //System.Diagnostics.Process.Start("git", command);
                        Process p = new Process();
                        p.StartInfo.FileName = "cmd.exe";
                        // 这里是关键点,不用Shell启动/重定向输入/重定向输出/不显示窗口
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardInput = true;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.CreateNoWindow = true;
                        p.Start();
                        p.StandardInput.WriteLine("ping 127.0.0.1");// 向cmd.exe输入command
                        p.StandardInput.WriteLine("exit");
                        p.WaitForExit(60000);
                        string s = p.StandardOutput.ReadToEnd();// 得到cmd.exe的输出
                        p.Close();
                        Console.WriteLine(s);

                    }
                }   
            }
        }
    }
}
