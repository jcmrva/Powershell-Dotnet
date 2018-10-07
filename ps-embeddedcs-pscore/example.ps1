$cs = @"
using System;
using static System.Console;

public class Calc
{
    public static int RandomInt() => (new Random()).Next();

    public void WriteTuple()
    {
        var tuple = (A: "one", B: "two");
        WriteLine(tuple.A);
        WriteLine(tuple.B);
    }
}
"@

if ($PSVersionTable.PSEdition -eq "Desktop") {
    "This will fail at the Add-Type function under Windows Powershell."
    return
}
else {
    Add-Type -TypeDefinition $cs -Language CSharp # -ReferencedAssemblies $assemblies

    [Calc]::RandomInt()

    $calc = New-Object Calc 
    $calc.WriteTuple()

    $csmethod = @"
public static string Greet(string name) =>
    return "Hello " + name + " from a C# method.";

"@
    
    $greet = Add-Type -Name "GeneratedClass" -MemberDefinition $csmethod -Language CSharp -PassThru
    $greet::Greet("PS")
    
    # https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/add-type?view=powershell-6
}
