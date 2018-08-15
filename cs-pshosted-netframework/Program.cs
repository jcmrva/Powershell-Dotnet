using System;
using System.Linq;
using System.Management.Automation;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PowerShell ps = PowerShell.Create())
            {
                var results = ps.AddScript("Get-Command Write-Output").Invoke();
                Console.WriteLine(results[0].ToString());
                
                foreach (var r in ps.AddScript("Get-Verb").Invoke().Take(5))
                {
                    Console.WriteLine(r.ToString());
                }
              
            }

            Console.ReadLine();
        }
    }
}
