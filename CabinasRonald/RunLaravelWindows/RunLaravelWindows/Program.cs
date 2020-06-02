using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLaravelWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            /* execute "dir" */

            cmd.StandardInput.WriteLine("dir");
            cmd.StandardInput.WriteLine("cd C:/Users/Casa/Documents/CabinasRonald/CabinasRonald");
            cmd.StandardInput.WriteLine("php artisan serve");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();

            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
    }
}
