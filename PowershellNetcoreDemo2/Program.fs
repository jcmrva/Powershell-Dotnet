
open System
open System.Management.Automation

let PsVersion = 
    use ps = PowerShell.Create()
    ps.AddScript("$PSVersionTable.PSVersion").Invoke().Item(0).ToString()

    

[<EntryPoint>]
let main _ =
    printfn "The PowerShell version is: %s" PsVersion

    printfn "\nPress any key to exit."
    Console.Read() |> ignore
    0 // return an integer exit code
