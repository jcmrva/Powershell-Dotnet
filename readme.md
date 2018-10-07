Reasonably minimal examples of PowerShell-.NET interaction.


**Hosted**: PowerShell execution is hosted in .NET via System.Management.Automation

|Language|Target     |Folder
|:---:   |:---------:|---------
|C#      |netstandard|[cs-pshosted-netstandard](./cs-pshosted-netstandard)
|C#      |netcoreapp |[cs-pshosted-netcoreapp](./cs-pshosted-netcoreapp)
|C#      |framework  |[cs-pshosted-netframework](./cs-pshosted-netframework)


**Process**: PowerShell files are executed via System.Diagnostics.Process

|Language|Target     |Folder
|:---:   |:---------:|---------
|C#      |netcoreapp |[cs-psprocess-netcoreapp](./cs-psprocess-netcoreapp)
|F#      |netcoreapp |[cs-psprocess-netcoreapp](./cs-psprocess-netcoreapp)


**Library/Embedded**: .NET code is contained in a library referenced by PowerShell or embedded directly 

|Language|Target     |Folder
|:---:   |:---------:|---------
|PS      |netstandard|[ps-librarycs-netstandard](ps-librarycs-netstandard)
|PS      |netstandard|[ps-libraryfs-netstandard](ps-libraryfs-netstandard)
|PS      |PS Core    |[ps-embeddedcs-netstandard](ps-librarycs-netstandard)


**Extras**: Check each project for details. 





https://github.com/PowerShell/PowerShell/tree/master/docs/host-powershell


https://www.red-gate.com/simple-talk/dotnet/net-development/using-c-to-create-powershell-cmdlets-the-basics/

http://executeautomation.com/blog/calling-c-code-in-powershell-and-vice-versa/

