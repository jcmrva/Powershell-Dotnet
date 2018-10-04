C# embedded in PowerShell

This isn't notably different from the other example, but if you want to use recent C# features, you'll need to run it in PowerShell Core.

1. Create a PowerShell (.ps1) file.
2. Use the Add-Type cmdlet with the -TypeDefinition parameter.