
//open System
open System.Diagnostics

[<EntryPoint>]
let main _ =
    
    let pinfo = ProcessStartInfo();
    pinfo.FileName <- "powershell.exe";
    pinfo.Arguments <- "-File example.ps1 -MyParam \"Hello to PS from C# and back again.\" -Test";
    pinfo.CreateNoWindow <- true;
    pinfo.UseShellExecute <- false;
    pinfo.RedirectStandardOutput <- true;

    use proc = new Process()
    proc.StartInfo <- pinfo
    proc.EnableRaisingEvents <- true

    let started = proc.Start()
    if not started then printfn "Process failed to start."


    proc.WaitForExit()

    0