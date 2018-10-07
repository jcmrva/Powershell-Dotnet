$cs = @"
using System;

public class Calc
{
    private int increment = 0;
    
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public int Increment(int b = 0)
    {
        if (b > 0) { this.increment += b; }
        else { this.increment += 1; }

        return this.increment;
    }
}
"@

$assemblies = ( 
    "__, Version=14.0.0.0, Culture=neutral, PublicKeyToken=__" , 
    "__, Version=14.0.0.0, Culture=neutral, PublicKeyToken=__"
    ) 

Add-Type -TypeDefinition $cs -Language CSharp  # -ReferencedAssemblies $assemblies

[Calc]::Add(4, 3)

$calc = New-Object Calc 
$calc.Increment(2)
$calc.increment() # C# is case-sensitive but PS isn't.


$csmethod = @"
public static string Greet(string name)
{
    return "Hello " + name + " from a C# method.";
}
"@

$greet = Add-Type -Name "GeneratedClass" -MemberDefinition $csmethod -Language CSharp -PassThru
$greet::Greet("PS")

# https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/add-type?view=powershell-6
# https://technet.microsoft.com/en-us/library/dd315241.aspx
