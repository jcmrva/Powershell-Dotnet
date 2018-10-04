Minimal examples of PowerShell-.NET interaction.


|Lang |Method   |Target     |Folder
|:---:|:-------:|:---------:|---------
|C#   |hosted   |netstandard|[cs-pshosted-netstandard](./cs-pshosted-netstandard)
|C#   |hosted   |netcoreapp |[cs-pshosted-netcoreapp](./cs-pshosted-netcoreapp)
|C#   |hosted   |framework  |[cs-pshosted-netframework](./cs-pshosted-netframework)
|C#   |process  |netcoreapp |[cs-psprocess-netcoreapp](./cs-psprocess-netcoreapp)
|F#   |hosted   |netstandard|
|PS   |lib      |netstandard|[ps-librarycs-netstandard](ps-librarycs-netstandard)
|PS   |lib      |netstandard|[ps-libraryfs-netstandard](ps-libraryfs-netstandard)

* **Hosted**: PowerShell execution is hosted in .NET via System.Management.Automation

* **Process**: PowerShell files are executed via System.Diagnostics.Process

* **Nested**: Check each project for details. Following these is not generally recommended.



https://github.com/PowerShell/PowerShell/tree/master/docs/host-powershell


https://www.red-gate.com/simple-talk/dotnet/net-development/using-c-to-create-powershell-cmdlets-the-basics/

http://executeautomation.com/blog/calling-c-code-in-powershell-and-vice-versa/

