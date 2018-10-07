## C# embedded in PowerShell (.NET Core)

This isn't notably different from the other example, but if you want to use recent C# features/syntax, you'll need to run it in PowerShell Core.

Steps:

1. Create a PowerShell (.ps1/etc) file.
2. Include some C# code. Other languages don't appear to be supported yet.
3. Use the Add-Type cmdlet with the -TypeDefinition parameter.
