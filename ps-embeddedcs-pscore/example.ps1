$cs = @"
using System;
using static System.Math;

public class Calc
{
    public static int RandomInt() => (new Random()).Next();

    public void WriteTuple()
    {
        var tuple = (A: "one", B: "two");
        Console.WriteLine(tuple.A);
        Console.WriteLine(tuple.B);
    }
}
"@

Add-Type -TypeDefinition $cs -Language CSharp # -ReferencedAssemblies $assemblies

[Calc]::RandomInt()

$calc = New-Object Calc 
$calc.WriteTuple()

# https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/add-type?view=powershell-6
