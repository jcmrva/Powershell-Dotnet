using System;
using System.Management.Automation;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (PowerShell ps = PowerShell.Create())
            {
                var results = ps.AddScript("Get-Command Write-Output").Invoke();
                Console.WriteLine(results[0].ToString());
            }

            Console.ReadLine();
        }
    }
}
