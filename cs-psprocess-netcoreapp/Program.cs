using System;
using System.Diagnostics;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base folder: " + AppContext.BaseDirectory);

            var pinfo = new ProcessStartInfo();
            pinfo.FileName = "pwsh.exe";
            pinfo.Arguments = "-File example.ps1 -MyParam \"Hello to PS from C# and back again.\" -Test";
            //pinfo.WorkingDirectory = "";
            pinfo.CreateNoWindow = true;
            pinfo.UseShellExecute = false;
            pinfo.RedirectStandardOutput = true;

            using (Process proc = new Process() { StartInfo = pinfo, EnableRaisingEvents = true })
            {
                proc.Start();
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line = proc.StandardOutput.ReadLine();
                    Console.WriteLine(line);
                }

                proc.WaitForExit();
                Console.WriteLine(proc.ExitCode);
            }
        }
    }
}
