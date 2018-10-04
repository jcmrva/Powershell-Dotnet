
$root = (Get-Item -Path ".\").FullName

Set-Location .\lib\Example

dotnet publish --output (Join-Path $root -ChildPath "publish")

Set-Location ..\..

Add-Type -Path ".\publish\Example.dll"

[Example.ClassName]::FsHello

$instance = [Example.ClassName]::new("PS")
$instance.Greeting()

[Example.Math]::cube(2)
